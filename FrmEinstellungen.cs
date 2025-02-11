
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

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
            txtSPSIp.Text = Properties.Settings.Default.IpAddresseDB;
            txtSqlPort.Text = Properties.Settings.Default.PortDB;
            txtSqlBenutzer.Text = Properties.Settings.Default.BenutzerDB;
            txtSqlPw.Text = Properties.Settings.Default.PasswortDB;
            txtSqlDb.Text = Properties.Settings.Default.Datenbankname;

            txtSqlIP.Text = Properties.Settings.Default.IpAddresseSPS;
            txtSPSIp.Text = $"{Properties.Settings.Default.portSPS}";

            isInitializing = false;
        }


     
   
        private void TxtSqlSrv_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSqlIP.Text != $"{Properties.Settings.Default.IpAddresseDB}" || txtSqlIP.Text.Count(c => c == '.') != 3)
            {
                bool success = IPAddress.TryParse(txtSqlIP.Text, out _);
                if (!success || txtSqlIP.Text.Count(c => c == '.') != 3)
                {
                    txtSqlIP.BackColor = Color.PaleVioletRed;
                    änderung = true;
                    fehler = true;
                }
                else
                {
                    txtSqlIP.BackColor = Color.Khaki;
                    änderung = true;
                    fehler = false;
                }
            }
            else
            {
                änderung = false;
                fehler = false;
                txtSqlIP.BackColor = Color.White;
            }
        }
        private void TxtSqlSrv2_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSPSIp.Text != $"{Settings.Default.SQL_Server2}")
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
        private void TxtSqlDb_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSqlDb.Text != $"{Settings.Default.SQL_Datenbank}")
            {
                txtSqlDb.BackColor = Color.PaleVioletRed;
                änderung = true;
                fehler = true;
            }
            else
            {
                txtSqlDb.BackColor = Color.Khaki;
                änderung = true;
                fehler = false;
            }
        }
        private void TxtSqlUser_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSqlBenutzer.Text != $"{Settings.Default.SQL_User}")
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
        private void TxtSqlPort_TextChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (txtSqlPort.Text != $"{Settings.Default.SQL_Port}")
            {
                if (int.TryParse(txtSqlPort.Text, out _))
                {
                    txtSqlPort.BackColor = Color.Khaki;
                    änderung = true;
                    fehler = false;
                }
                else
                {
                    txtSqlPort.BackColor = Color.Khaki;
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
        }
        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            if (änderung && !fehler)
            {
                if (txtSqlIP.Text != $"{Settings.Default.SQL_Server}") Settings.Default.SQL_Server= txtSqlIP.Text;
                if (txtSPSIp.Text != $"{Settings.Default.SQL_Server2}") Settings.Default.SQL_Server2 = txtSPSIp.Text;
                if (txtSqlPort.Text != $"{Settings.Default.SQL_Port}") Settings.Default.SQL_Port = txtSqlPort.Text;
                if (txtSqlBenutzer.Text != $"{Settings.Default.SQL_User}") Settings.Default.SQL_User = txtSqlBenutzer.Text;
                if (txtSqlDb.Text != $"{Settings.Default.SQL_Datenbank}") Settings.Default.SQL_Datenbank = txtSqlDb.Text;
                Settings.Default.IsTest = cbxTest.Checked;
                Settings.Default.Save();

                MessageBox.Show("Änderungen wurden gespeichert, Neustart erforderlich");
                Close();
            }
            else if (änderung && fehler)
            {
                MessageBox.Show("Bitte erst die Fehler beseitigen!");
            }
            else Close();
        }
    
    }


}


