namespace Übertragung_BDE
{
    public partial class FrmHauptseite : Form
    {
        public FrmHauptseite()
        {
            InitializeComponent();
            TcpClientSingleton.Instance.StartServer();
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
            TcpClientSingleton.Instance.StartServer();


            TcpClientSingleton.Instance.MessageSent += AddSentMessageToListBox;
            TcpClientSingleton.Instance.StartServer();
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
                    MessageBox.Show("Quittung");
                }
                else
                {
                    MessageBox.Show($"{message.Length}");
                }
                    

                //VerarbeiteEingangsdaten(message);
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



        private void VerarbeiteEingangsdaten(string message)
        {
            try
            {
                // Daten anhand von ';' splitten
                var datenTeile = message.Split(' ');
                var id = datenTeile[0].Split(' ')[1];
                var ba = datenTeile[1].Split(' ')[1];
                var ioSchuss = datenTeile[2].Split(' ')[1];
                var nioSchuss = datenTeile[3].Split(' ')[1];

               // Console.WriteLine($"Empfangen -> ID: {id}, Wert: {wert}, Status: {status}");

                // Daten in die DB schreiben
               // SpeichereInDatenbank(id, wert, status);

                // Antwort an SPS senden
               // AntwortAnSPS($"Bestätigung: ID {id} empfangen");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Verarbeiten der Nachricht: {ex.Message}");
            }
        }

        private void DatenAbrufen()
        {



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TcpClientSingleton.Instance.SendMessage(txtSenden.Text);
        }

        private void listGesendet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
