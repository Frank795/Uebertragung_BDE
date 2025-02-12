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

        private string allowedIpAddress = Properties.Settings.Default.IpAdresseSPS; // Standard-IP, später über Settings setzbar
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
                MessageBox.Show($"Server gestartet und hört auf {allowedIpAddress} : {port}.");

            }
            catch (Exception ex)
            {
                ConnectionStatusChanged?.Invoke(false);
                MessageBox.Show($"Fehler beim Starten des Servers: {ex.Message}");
            }
        }

        private async Task ListenForClients()
        {
            while (isRunning)
            {
                try
                {
                    client = await tcpListener.AcceptTcpClientAsync();
                    stream = client.GetStream();
                    ReceiveData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Verbinden mit Client: {ex.Message}");
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

                    // Event auslösen, damit die UI reagieren kann
                    DataReceived?.Invoke(receivedMessage);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Empfangen der Daten: {ex.Message}");
                    break;
                }
            }
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
            allowedIpAddress = newIp;
            StopServer();
            StartServer();
        }
    }

}
