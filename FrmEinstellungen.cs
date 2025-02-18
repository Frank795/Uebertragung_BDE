
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Übertragung_BDE
{
    public partial class FrmEinstellungen : Form
    {
        readonly bool isInitializing = false;
        bool änderung = false;
        bool fehler = false;
        public FrmEinstellungen()
        {
            isInitializing = true;
            InitializeComponent();
            // System / Standorteinstellungen 
            txtWartezeit.Text = $"{Properties.Settings.Default.Wartezeit}";
            txtListeneinträge.Text = $"{Properties.Settings.Default.Listenleinträge}";







            // SQL und DB Einstellungen
            txtSqlIp.Text = Properties.Settings.Default.IpAdresseDB;
            txtSqlPort.Text = Properties.Settings.Default.PortDB;
            txtSqlBenutzer.Text = Properties.Settings.Default.BenutzerDB;
            txtSqlPw.Text = "******"; //Properties.Settings.Default.PasswortDB;
            txtSqlDb.Text = Properties.Settings.Default.Datenbankname;
            txtSPSIp.Text = Properties.Settings.Default.IpAdresseSPS;
            txtSPSPort.Text = Properties.Settings.Default.PortSPS;
            // Mail Einstellungen
            txtMailAbsender.Text = Properties.Settings.Default.NameMailAbsender;
            txtMailAdresse.Text = Properties.Settings.Default.AdresseMailAbsender;
            txtMailPasswort.Text = "******"; // Properties.Settings.Default.MailPasswort;
            txtSmtpAdresse.Text = Properties.Settings.Default.SmtpAdresse;
            txtSmtpPort.Text = $"{Properties.Settings.Default.SmtpPort}";
            txtMailEmpfaenger.Text = Properties.Settings.Default.MailEmpfaenger;
            isInitializing = false;
        }
        private void TxtSqlSrv_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSqlIp.Text != $"{Properties.Settings.Default.IpAdresseDB}" || txtSqlIp.Text.Count(c => c == '.') != 3)
            {
                bool success = IPAddress.TryParse(txtSqlIp.Text, out _);
                if (!success || txtSqlIp.Text.Count(c => c == '.') != 3)
                {
                    txtSqlIp.BackColor = Color.PaleVioletRed;
                    änderung = true;
                    fehler = true;
                }
                else
                {
                    txtSqlIp.BackColor = Color.Khaki;
                    änderung = true;
                    fehler = false;
                }
            }
            else
            {
                änderung = false;
                fehler = false;
                txtSqlIp.BackColor = Color.White;
            }
        }
        private void TxtSqlPort_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSqlPort.Text != $"{Properties.Settings.Default.PortDB}")
            {
                if (int.TryParse(txtSqlPort.Text, out _))
                {
                    txtSqlPort.BackColor = Color.Khaki;

                    fehler = false;
                }
                else
                {
                    txtSqlPort.BackColor = Color.PaleVioletRed;

                    fehler = true;
                }
            }
            else
            {
                txtSqlPort.BackColor = Color.White;

                fehler = false;

            }
        }
        private void TxtSqlBenutzer_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSqlBenutzer.Text != $"{Properties.Settings.Default.BenutzerDB}")
            {
                txtSqlBenutzer.BackColor = Color.Khaki;
                änderung = true;
            }
            else
            {
                txtSqlBenutzer.BackColor = Color.White;
                änderung = false;
            }
        }

        private void TxtSqlPw_Click(object sender, EventArgs e)
        {
            int minLength = 5; // Mindestlänge festlegen
            FrmPasswortvergabe passwortForm = new(minLength,1, "Ändern");
            passwortForm.Show();
           
        }
        private void TxtMailPasswort_Click(object sender, EventArgs e)
        {
            int minLength = 5; // Mindestlänge festlegen
            FrmPasswortvergabe passwortForm = new(minLength,2, "Ändern");
            passwortForm.Show();
        }




        // Passwort verschlüsseln FEHLT NOCH
        private void TxtSqlDb_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSqlDb.Text != $"{Properties.Settings.Default.Datenbankname}")
            {
                txtSqlBenutzer.BackColor = Color.Khaki;
                änderung = true;
            }
            else
            {
                txtSqlBenutzer.BackColor = Color.White;
                änderung = false;
            }
        }
        private void TxtSPSIp_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSPSIp.Text != $"{Properties.Settings.Default.IpAdresseSPS}")
            {
                bool success = IPAddress.TryParse(txtSPSIp.Text, out _);
                if (!success || txtSPSIp.Text.Count(c => c == '.') != 3)
                {
                    txtSPSIp.BackColor = Color.PaleVioletRed;
                    änderung = true;
                    fehler = true;
                }
                else
                {
                    txtSPSIp.BackColor = Color.Khaki;
                    änderung = true;
                    fehler = false;
                }
            }
            else
            {
                änderung = false;
                fehler = false;
                txtSPSIp.BackColor = Color.White;
            }
        }
        private void TxtSPSPort_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSqlPort.Text != $"{Properties.Settings.Default.PortDB}")
            {
                if (int.TryParse(txtSqlPort.Text, out _))
                {
                    txtSqlPort.BackColor = Color.Khaki;
                    änderung = true;
                    fehler = false;
                }
                else
                {
                    txtSqlPort.BackColor = Color.PaleVioletRed;
                    änderung = true;
                    fehler = true;
                }
            }
            else
            {
                txtSqlPort.BackColor = Color.White;
                änderung = false;
                fehler = false;

            }
        }
        private void BtnAbbrechen_Click(object sender, EventArgs e)
        {
            if (änderung)
            {
                DialogResult dialogResult = MessageBox.Show(" Änderungen Verwerfen ??", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    Close();
                else return;
            }
            else Close();
            Close();
        }
        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            int aktiverTabIndex = tabControl1.SelectedIndex;
            if (aktiverTabIndex == 0)
            {
                if (txtWartezeit.Text != $"{Properties.Settings.Default.Wartezeit}") Properties.Settings.Default.Wartezeit = Convert.ToInt32(txtWartezeit.Text);
                if (txtListeneinträge.Text != $"{Properties.Settings.Default.Listenleinträge}") Properties.Settings.Default.Listenleinträge = Convert.ToInt32(txtListeneinträge.Text);
                Properties.Settings.Default.Save();
                Close();

            }// Systemeinstellung
            else if (aktiverTabIndex == 1)
            {
                if (!fehler)
                {
                    if (txtSqlIp.Text != $"{Properties.Settings.Default.IpAdresseDB}") Properties.Settings.Default.IpAdresseDB = txtSqlIp.Text;
                    if (txtSqlPort.Text != $"{Properties.Settings.Default.PortDB}") Properties.Settings.Default.PortDB = txtSqlPort.Text;
                    if (txtSqlBenutzer.Text != $"{Properties.Settings.Default.BenutzerDB}") Properties.Settings.Default.BenutzerDB = txtSqlBenutzer.Text;
                    if (txtSqlDb.Text != $"{Properties.Settings.Default.Datenbankname}") Properties.Settings.Default.Datenbankname = txtSqlDb.Text;
                    if (txtSPSIp.Text != $"{Properties.Settings.Default.IpAdresseSPS}") Properties.Settings.Default.IpAdresseSPS = txtSPSIp.Text;
                    if (txtSPSPort.Text != $"{Properties.Settings.Default.PortSPS}") Properties.Settings.Default.PortSPS = txtSPSPort.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Änderungen wurden gespeichert, Neustart erforderlich");
                    Close();
                }
                else if (fehler)
                {
                    MessageBox.Show("Bitte erst die Fehler beseitigen!");
                }
                else Close();
            }// Einstellung DB und SPS
            else if (aktiverTabIndex == 2)
            {
                if (txtMailAbsender.Text != $"{Properties.Settings.Default.NameMailAbsender}") Properties.Settings.Default.NameMailAbsender = txtMailAbsender.Text;
                if (txtMailAdresse.Text != $"{Properties.Settings.Default.AdresseMailAbsender}") Properties.Settings.Default.AdresseMailAbsender = txtMailAdresse.Text;
                if (txtSmtpAdresse.Text != $"{Properties.Settings.Default.SmtpAdresse}") Properties.Settings.Default.SmtpAdresse = txtSmtpAdresse.Text;
                if (txtSmtpPort.Text != $"{Properties.Settings.Default.SmtpPort}") Properties.Settings.Default.SmtpPort = Convert.ToInt32(txtSmtpPort.Text);
                if (txtMailEmpfaenger.Text != $"{Properties.Settings.Default.MailEmpfaenger}") Properties.Settings.Default.MailEmpfaenger = txtMailEmpfaenger.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Änderungen wurden gespeichert, Neustart erforderlich");
                Close();

            }// Einstellung Mail
        }
        private void BtnTestMail_Click(object sender, EventArgs e)
        {
            E_Mail_versand.SendEmail("Testmail", "Das ist ein Test der Mailfunktion");
        }

      
    }


}


