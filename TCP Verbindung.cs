namespace Übertragung_BDE
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    public class TcpClientSingleton
    {
        private static TcpClientSingleton? _instance;
        private static readonly object _lock = new();
        private TcpListener tcpListener = null!;
        private TcpClient client = null!;
        private NetworkStream stream = null!;
        private bool isRunning = false;
        public event Action<string> DataReceived = delegate { };
        public event Action<bool> ConnectionStatusChanged = delegate { };
        public event Action<string> MessageSent = delegate { };
        private string IpAddresseSPS = Properties.Settings.Default.IpAdresseSPS; 
        private  int port = Convert.ToInt32(Properties.Settings.Default.PortSPS);
        private TcpClientSingleton() { }
        public static TcpClientSingleton Instance
        {
            get
            {
                lock (_lock)
                {
                    _instance ??= new TcpClientSingleton();
                    return _instance;
                }
            }
        }
        public void StartServer()
        {
            if (isRunning) return;         
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, port);
                tcpListener.Start();
                isRunning = true;
                ConnectionStatusChanged?.Invoke(true);
                Task.Run(() => ListenForClients());
                //MessageBox.Show($"Server gestartet und hört auf {allowedIpAddress} : {port}.");
            }
            catch (Exception ex)
            {
                ConnectionStatusChanged?.Invoke(false);
                Logging.ErrorLog($" Fehler beim Starten des TCP Servers :{ex.Message}");
            }
        }
        private async Task ListenForClients()
        {
            while (isRunning)
            {
                try
                {
                    TcpClient tempClient = await tcpListener.AcceptTcpClientAsync();
                    // Prüfen, ob RemoteEndPoint vorhanden ist
                    if (tempClient.Client.RemoteEndPoint is not IPEndPoint remoteEndPoint)
                    {
                        Logging.ErrorLog("Client hat keine gültige RemoteEndPoint-Adresse. Verbindung geschlossen.");
                        tempClient.Close();
                        continue;
                    }
                    string clientIP = remoteEndPoint.Address.ToString();
                    if (clientIP != IpAddresseSPS)
                    {
                        Logging.ErrorLog($"Unbekannte IP {clientIP} versucht sich zu verbinden. Verbindung abgelehnt.");
                        tempClient.Close();
                        continue;
                    }
                    // Verbindung akzeptieren
                    client = tempClient;
                    stream = client.GetStream();
                    ReceiveData();
                }
                catch (Exception ex)
                {
                    Logging.ErrorLog($"Fehler beim Verbinden des TCP Clients: {ex.Message}");
                    ConnectionStatusChanged?.Invoke(false);
                }
            }
        }
        private async void ReceiveData()
        {
            byte[] buffer = new byte[1024];
            while (client.Connected)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break; // Verbindung geschlossen
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    DataReceived?.Invoke(receivedMessage);
                }
                catch (Exception ex)
                {
                    Logging.ErrorLog($" Fehler beim Empfang der TCP Daten :{ex.Message}");
                    break;
                }
            }
        }
        public async Task<string> WaitForResponse()
        {
            var tcs = new TaskCompletionSource<string>();

            void Handler(string data)
            {
                tcs.TrySetResult(data);
                DataReceived -= Handler; // Event abmelden nach Empfang
            }

            DataReceived += Handler; // Event registrieren

            return await tcs.Task; // Warten, bis die SPS eine Antwort sendet
        }
        public void SendMessage(string message)
        {
            if (stream != null && client.Connected)
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
                stream.Flush();
                // Event auslösen
                MessageSent?.Invoke(message);
            }
        }
        public void StopServer()
        {
            isRunning = false;
            tcpListener?.Stop();
            client?.Close();
            stream?.Close();
            ConnectionStatusChanged?.Invoke(false);
        }
        public void UpdateAllowedIp(string newIp)
        {
            IpAddresseSPS = newIp;
            StopServer();
            StartServer();
        }
    }
}
