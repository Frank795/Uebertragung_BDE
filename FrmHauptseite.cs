using System.Data;
using System.Threading;

namespace Übertragung_BDE
{
    public partial class FrmHauptseite : Form
    {
        private CancellationTokenSource? _cancellationTokenSource;
        private bool antwortSPSerhalten = false;
        private string letzteNachrichtSPS = "";
        public FrmHauptseite()
        {
            InitializeComponent();
        }


        private void Btn_Einstellungen_Click(object sender, EventArgs e)
        {
            FrmEinstellungen einstellungen = new();
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

        private async  void Hauptseite_Load(object sender, EventArgs e)
        {
            TcpClientSingleton.Instance.DataReceived += NeueDatenEingegangen;
            TcpClientSingleton.Instance.MessageSent += NeuDatenGesendet;
            TcpClientSingleton.Instance.StartServer();
            await Task.Delay(5000);
            _cancellationTokenSource = new CancellationTokenSource();
            _ = Task.Run(() => AutomatischerProzess(_cancellationTokenSource.Token));



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
                ListViewItem item = new(currentTime);
                item.SubItems.Add(message);
                listEmpfang.Items.Insert(0, item); // Neueste Meldung oben einfügen
                antwortSPSerhalten = true;
                letzteNachrichtSPS = message;
            }
        }
        private void NeuDatenGesendet(string message)
        {
            if (listGesendet.InvokeRequired)
            {
                listGesendet.Invoke(new Action(() => NeuDatenGesendet(message)));
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
                    
                    string query1 = " SELECT * from test ";
                    DataTable anlagen = DbHelper.Instance.ExecuteSelectQuery(query1);
                    // Step1 Datendurchlauf und Steuern wenn nötig
                    foreach (DataRow row in anlagen.Rows)
                    {
                        string? id = row["id"].ToString();
                        string? peri1_soll = row["peri1_soll"].ToString();
                        string? peri1_ist = row["peri1_ist"].ToString();
                        string? peri2_soll = row["peri2_soll"].ToString();
                        string? peri2_ist = row["peri2_ist"].ToString();

                        if (peri1_soll != peri1_ist)  // Prüfung ob gesteuert wird 
                        {
                            string steuerbefehl = $"10 {id} {peri1_soll}";
                            //MessageBox.Show($"{steuerbefehl}");
                            antwortSPSerhalten = false;
                            letzteNachrichtSPS = "";
                            TcpClientSingleton.Instance.SendMessage(steuerbefehl);
                            int toSteuern = 5000; // 5 Sekunden Timeout
                            int zeitToSteuern = 0;
                            while (!antwortSPSerhalten && zeitToSteuern < toSteuern)
                            {
                                Thread.Sleep(100); // 100ms warten
                                zeitToSteuern += 100;
                            }
                            if (antwortSPSerhalten)
                            {
                                //MessageBox.Show($"{letzteNachrichtSPS}");
                                if (letzteNachrichtSPS == "01")
                                {
                                    // Datenbank updaten oder weiteren Schritt ausführen
                                }
                                if (letzteNachrichtSPS == "02")
                                {
                                    //MessageBox.Show("Baustein Deakiviert");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Fehler beim Steuern: Keine Antwort innerhalb der Zeit!");
                            }
                        }
                        if (peri2_soll != peri2_ist)  // Prüfung ob gesteuert wird 
                        {
                            string steuerbefehl = $"11 {id} {peri2_soll}";
                            //MessageBox.Show($"{steuerbefehl}");
                            antwortSPSerhalten = false;
                            letzteNachrichtSPS = "";
                            TcpClientSingleton.Instance.SendMessage(steuerbefehl);
                            int toSteuern = 5000; // 5 Sekunden Timeout
                            int zeitToSteuern = 0;
                            while (!antwortSPSerhalten && zeitToSteuern < toSteuern)
                            {
                                Thread.Sleep(100); // 100ms warten
                                zeitToSteuern += 100;
                            }
                            if (antwortSPSerhalten)
                            {
                                //MessageBox.Show($"{letzteNachrichtSPS}");
                                if (letzteNachrichtSPS == "01")
                                {
                                    // Datenbank updaten oder weiteren Schritt ausführen
                                }
                                if (letzteNachrichtSPS == "02")
                                {
                                    //MessageBox.Show("Baustein Deakiviert");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Fehler beim Steuern : Keine Antwort innerhalb der Zeit!");
                            }
                        }

                    }
                    //MessageBox.Show("Steuern Fertig, Start Datenverarbeitung");
                    // 2️⃣ Datenaustausch starten
                    TcpClientSingleton.Instance.SendMessage("02");
                    // Jetzt so lange auf Datensätze warten, bis "99" kommt
                    while (true)
                    {
                        antwortSPSerhalten = false;
                        letzteNachrichtSPS = "";
                        int toEingang = 5000;
                        int zeitToEingang = 0;
                        while (!antwortSPSerhalten && zeitToEingang < toEingang)
                        {
                            //Thread.Sleep(10);
                            //zeitToEingang += 10;
                            await Task.Delay(10, token);
                            zeitToEingang += 10;
                        }
                        if (antwortSPSerhalten)
                        {
                            //MessageBox.Show($"Empfangen: {letzteNachrichtSPS}");
                            if (letzteNachrichtSPS == "99")
                            {
                                //MessageBox.Show("Ende");
                                break; // Beende die Empfangsschleife
                            }
                            else
                            {
                                // Speichere empfangene Daten in der DB
                                SpeichereInDB(letzteNachrichtSPS);

                                

                                // Bestätigung senden
                                TcpClientSingleton.Instance.SendMessage("01");
                                //MessageBox.Show("Erledigt");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fehler: Keine Antwort innerhalb der Zeit!");
                            break; // Falls kein neuer Datensatz kommt, abbrechen
                        }
                    }



                    // 3️⃣ Pause vor Neustart
                    await Task.Delay(TimeSpan.FromSeconds(20), token);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler im Automatikprozess: {ex.Message}");
                }
            }
        }

        private static void SpeichereInDB(string message)
        {
            string UpdateQuery ;
            string? id = "";
            string? ba ;
            string? ioSchuss ;
            string? nioSchuss ;
            string? peri1;
            string? peri2;



            try             
            {
                List<string> updateList = [];
                string[] datenTeile = message.Split(' ');
                if (message.Length >= 24)                   
                {                                                                             
                    id = datenTeile[0];       // Erste Zahl → ID                       
                    ba = datenTeile[1];   // Zweite Zahl → Status                       
                    ioSchuss = datenTeile[2];    // Dritte Zahl → Wert 1                        
                    nioSchuss = datenTeile[3];    // Vierte Zahl → Wert 2                                                                              
                    updateList.Add($"ba = {ba}");
                    updateList.Add($"io_schuss = io_schuss + {ioSchuss}");
                    updateList.Add($"nio_schuss = nio_schuss + {nioSchuss}");

                }
                if (message.Length >= 28)
                {                    
                    peri1 = datenTeile[4];   // Zweite Zahl → Status                     
                    peri2 = datenTeile[5];   // Zweite Zahl → Status
                    updateList.Add($"peri1_ist = {peri1}");
                    updateList.Add($"peri2_ist = {peri2}");            
                }
                



                string updateString = string.Join(", ", updateList);
                UpdateQuery = $"UPDATE test SET {updateString} WHERE id = {id}";              
                DbHelper.Instance.ExecuteNonQuery(UpdateQuery);
                

            }                
            catch (Exception ex)               
            {                 
               Logging.ErrorLog($"Fehler beim Verarbeiten der Nachricht: {ex.Message}");
            }



            

        }




 
        private void FrmHauptseite_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }
        private void BtnAutoStop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }
        private void BtnAutoStart_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => AutomatischerProzess(_cancellationTokenSource.Token));
        }
    }









}
