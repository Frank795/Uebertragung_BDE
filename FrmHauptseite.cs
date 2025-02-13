using System.Data;
using System.Threading;

namespace Übertragung_BDE
{
    public partial class FrmHauptseite : Form
    {
        private CancellationTokenSource? _cancellationTokenSource;
        private bool antwortSPSerhalten = false;
        private string letzteNachrichtSPS = "";
        private bool datenSPSerhalten = false;
        public FrmHauptseite()
        {
            InitializeComponent();
            //TcpClientSingleton.Instance.StartServer();
        }
       

        private void Btn_Einstellungen_Click(object sender, EventArgs e)
        {
            FrmEinstellungen einstellungen = new FrmEinstellungen();
            if (einstellungen.ShowDialog() == DialogResult.OK)
            {
                //// Server neu starten, um die neue IP-Adresse zu übernehmen
                //TCPListenerRestart = true;
                //StopTCPServer();
                //Thread.Sleep(3000);
                //StartTCPServer();
                //TCPListenerRestart = false;
            }


        }

        private void Hauptseite_Load(object sender, EventArgs e)
        {
            TcpClientSingleton.Instance.DataReceived += NeueDatenEingegangen;
            TcpClientSingleton.Instance.MessageSent += AddSentMessageToListBox;
            TcpClientSingleton.Instance.StartServer();
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => AutomatischerProzess(_cancellationTokenSource.Token));
        }
        private void NeueDatenEingegangen(string message)
        {
            if (listEmpfang.InvokeRequired)
            {
                listEmpfang.Invoke(new Action(() => NeueDatenEingegangen(message)));
            }
            else
            {
                string currentTime = DateTime.Now.ToString("MM.dd. | HH:mm:ss:ff");
                ListViewItem item = new ListViewItem(currentTime);
                item.SubItems.Add(message);
                listEmpfang.Items.Insert(0, item); // Neueste Meldung oben einfügen
                if (message.Length == 2)
                {
                    antwortSPSerhalten = true;
                    letzteNachrichtSPS = message;

                }
                else
                {
                    MessageBox.Show($"{message.Length}");
                    datenSPSerhalten = true;
                    letzteNachrichtSPS = message;
                }
                    

                
            }
        }
        private void AddSentMessageToListBox(string message)
        {
            if (listGesendet.InvokeRequired)
            {
                listGesendet.Invoke(new Action(() => AddSentMessageToListBox(message)));
            }
            else
            {
                string currentTime = DateTime.Now.ToString("MM.dd. | HH:mm:ss:ff");
                ListViewItem item = new(currentTime);
                item.SubItems.Add(message);
                listGesendet.Items.Insert(0, item); // Neueste Meldung oben einfügen

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            TcpClientSingleton.Instance.SendMessage(txtSenden.Text);
        }


        private async Task AutomatischerProzess(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {

                    // 1️⃣ DB prüfen & Steuerbefehl senden

                    string query1 = " SELECT * from sgm ";
                    DataTable anlagen = DbHelper.Instance.ExecuteSelectQuery(query1);

                    foreach (DataRow row in anlagen.Rows)
                    {
                        string? id = row["id"].ToString(); 
                        string? wertA = row["tr_soll"].ToString(); 
                        string? wertB = row["tr_ist"].ToString(); 

                        if (wertA != wertB)  // Prüfung ob gesteuert wird 
                        {
                            string steuerbefehl = $"10 {id} {wertA}";
                            //MessageBox.Show($"{steuerbefehl}");
                            TcpClientSingleton.Instance.SendMessage(steuerbefehl);

                            // Warte auf Antwort der SPS mit Timeout
                            antwortSPSerhalten = false;
                            letzteNachrichtSPS = "";
                            int toSteuern = 5000; // 5 Sekunden Timeout
                            int zeitToSteuern = 0;
                            while (!antwortSPSerhalten && zeitToSteuern < toSteuern)
                            {
                                Thread.Sleep(100); // 100ms warten
                                zeitToSteuern += 100;
                            }

                            if (antwortSPSerhalten)
                            {
                                MessageBox.Show($"{letzteNachrichtSPS}");
                                if (letzteNachrichtSPS == "01")
                                {
                                    // Datenbank updaten oder weiteren Schritt ausführen
                                }
                            }
                            else
                            {
                                MessageBox.Show("Fehler: Keine Antwort innerhalb der Zeit!");
                            }



                        }
                    }
                    // 2️⃣ Datenaustausch starten
                    TcpClientSingleton.Instance.SendMessage("02");


                    
                    letzteNachrichtSPS = "";
                    int toEingang = 15000; // 5 Sekunden Timeout
                    int zeitToEingang = 0;
                    while (!datenSPSerhalten && zeitToEingang < toEingang)
                    {
                        Thread.Sleep(100); // 100ms warten
                        zeitToEingang += 100;
                    }

                    if (datenSPSerhalten)
                    {
                        MessageBox.Show($"{letzteNachrichtSPS}");
                        if (letzteNachrichtSPS == "ENDE")
                        {
                            MessageBox.Show("Ende");
                        }
                        else
                        {
                            //SpeichereInDB(nachricht);
                            MessageBox.Show("inDB Schreiben");
                            datenSPSerhalten = false;
                            TcpClientSingleton.Instance.SendMessage("01");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fehler: Keine Antwort innerhalb der Zeit!");
                    }


                    // 3️⃣ Pause vor Neustart
                    await Task.Delay(TimeSpan.FromSeconds(10), token);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler im Automatikprozess: {ex.Message}");
                }
            }
        }

     


      


        private void FrmHauptseite_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }





    }









}
