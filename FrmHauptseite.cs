using System.Data;
using System.Threading;

namespace Übertragung_BDE
{
    public partial class FrmHauptseite : Form
    {
        private CancellationTokenSource? _cancellationTokenSource;
        private bool antwortSPSerhalten = false;
        private string letzteNachrichtSPS = "";
        private bool erfolgreichGespeichert = false;
        public FrmHauptseite()
        {
            InitializeComponent();
        }
        private void Btn_Einstellungen_Click(object sender, EventArgs e)
        {
            FrmEinstellungen einstellungen = new();
            einstellungen.Show();
        }
        private async void Hauptseite_Load(object sender, EventArgs e)
        {
           
            Logging.AppLog("APP gestartet");
            TcpClientSingleton.Instance.DataReceived += NeueDatenEingegangen;
            TcpClientSingleton.Instance.MessageSent += NeuDatenGesendet;
            TcpClientSingleton.Instance.StartServer();
            await Task.Delay(3000);// Wartezeit nach Start zum verbindungsaufbau
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
        private void BtnTestMail_Click(object sender, EventArgs e)
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
                        if (peri1_soll != peri1_ist)
                        {
                            string steuerbefehl = $"10 {id} {peri1_soll}";
                            antwortSPSerhalten = false;
                            letzteNachrichtSPS = "";
                            TcpClientSingleton.Instance.SendMessage(steuerbefehl);
                            int toSteuern = 5000; // 5 Sekunden Timeout
                            int zeitToSteuern = 0;
                            while (!antwortSPSerhalten && zeitToSteuern < toSteuern)
                            {
                                await Task.Delay(10, token);
                                zeitToSteuern += 100;
                            }
                            if (antwortSPSerhalten)
                            {
                                if (letzteNachrichtSPS == "01")
                                {
                                }
                                if (letzteNachrichtSPS == "02")
                                {
                                    Logging.InfoLog($"Deaktivierten Baustein gesteuert {id}");
                                }
                            }
                            else
                            {
                                Logging.ErrorLog("Fehler beim Steuern: Keine Antwort innerhalb der Zeit!");
                            }
                        }
                        if (peri2_soll != peri2_ist)  
                        {
                            string steuerbefehl = $"11 {id} {peri2_soll}";
                            antwortSPSerhalten = false;
                            letzteNachrichtSPS = "";
                            TcpClientSingleton.Instance.SendMessage(steuerbefehl);
                            int toSteuern = 5000; // 5 Sekunden Timeout
                            int zeitToSteuern = 0;
                            while (!antwortSPSerhalten && zeitToSteuern < toSteuern)
                            {
                                await Task.Delay(10, token);
                                zeitToSteuern += 100;
                            }
                            if (antwortSPSerhalten)
                            {
                                if (letzteNachrichtSPS == "01")
                                {
                                }
                                if (letzteNachrichtSPS == "02")
                                {
                                    Logging.InfoLog($"Deaktivierten Baustein gesteuert {id}");
                                }
                            }
                            else
                            {
                                Logging.ErrorLog("Fehler beim Steuern: Keine Antwort innerhalb der Zeit!");
                            }
                        }
                    }
                    // Step 2 Datenaustausch 
                    TcpClientSingleton.Instance.SendMessage("02");
                    // Prüfung ob gesteuert wird 
                    while (true)
                    {
                        antwortSPSerhalten = false;
                        letzteNachrichtSPS = "";
                        int toEingang = 5000;
                        int zeitToEingang = 0;
                        while (!antwortSPSerhalten && zeitToEingang < toEingang)
                        {
                            await Task.Delay(10, token);
                            zeitToEingang += 10;
                        }
                        if (antwortSPSerhalten)
                        {
                            if (letzteNachrichtSPS == "99")
                            {
                                break; // Beende die Empfangsschleife
                            }
                            else
                            {
                                // Speichere empfangene Daten in der DB
                                SpeichereInDB(letzteNachrichtSPS);
                                // Bestätigung senden
                                if (erfolgreichGespeichert)
                                {
                                    TcpClientSingleton.Instance.SendMessage("01");
                                }                               
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
        private void SpeichereInDB(string message)
        {
            string UpdateQuery; string? id=""; string? ba; string? ioSchuss; string? nioSchuss;
            string? peri1; string? peri2;

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

                } // Standartdaten 24 Zeichen
                if (message.Length >= 28)
                {
                    peri1 = datenTeile[4];   // Zweite Zahl → Status                     
                    peri2 = datenTeile[5];   // Zweite Zahl → Status
                    updateList.Add($"peri1_ist = {peri1}");
                    updateList.Add($"peri2_ist = {peri2}");
                } // Zusatzdaten 1  Peripherieausgänge
                if (message.Length >= 60)
                {
                   
                } // Zusatzdaten 2  Energieverbrauch



                string updateString = string.Join(", ", updateList);
                UpdateQuery = $"UPDATE test SET {updateString} WHERE id = {id}";
                DbHelper.Instance.ExecuteNonQuery(UpdateQuery);
                if ((DbHelper.Instance.ExecuteNonQuery(UpdateQuery)))
                {
                    erfolgreichGespeichert = true;
                }



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
            Logging.AppLog("Automatik über Taste beendet");
            _cancellationTokenSource?.Cancel();
        }
        private void BtnAutoStart_Click(object sender, EventArgs e)
        {
            Logging.AppLog("Automatik über Taste gestartet");
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => AutomatischerProzess(_cancellationTokenSource.Token));
        }
        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            Logging.AppLog("App über Taste Geschlossen");
            _cancellationTokenSource?.Cancel();
            Close();
        }
    }









}
