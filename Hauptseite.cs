namespace Übertragung_BDE
{
    public partial class Hauptseite : Form
    {
        public Hauptseite()
        {
            InitializeComponent();
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
    }
    
}
