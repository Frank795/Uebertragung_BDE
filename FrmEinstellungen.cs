
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
            txtSqlIp.Text = Properties.Settings.Default.IpAdresseDB;
            txtSqlPort.Text = Properties.Settings.Default.PortDB;
            txtSqlBenutzer.Text = Properties.Settings.Default.BenutzerDB;
            txtSqlPw.Text = Properties.Settings.Default.PasswortDB;
            txtSqlDb.Text = Properties.Settings.Default.Datenbankname;
            txtSPSIp.Text = Properties.Settings.Default.IpAdresseSPS;
            txtSPSPort.Text = $"{Properties.Settings.Default.PortSPS}";
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

        // Passwort FEHLT NOCH


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
            if (änderung && !fehler)
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
            else if (änderung && fehler)
            {
                MessageBox.Show("Bitte erst die Fehler beseitigen!");
            }
            else Close();
        }

        private void FrmEinstellungen_Load(object sender, EventArgs e)
        {

        }
    }


}


