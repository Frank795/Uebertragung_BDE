using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using Microsoft.VisualBasic.ApplicationServices;

namespace Übertragung_BDE

{
    public partial class FrmPasswortvergabe : Form
    {
        readonly int minPasswordLength = 1;
        readonly int verschTyp;
        readonly string userForm = "";
        public string? Passwort { get; private set; }

        public FrmPasswortvergabe(int minLength, int vTyp, string mode, string? user = null)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(user)) userForm = user;
            minPasswordLength = minLength;
            /* Vreschlüsselungs Typen
             * 1 - AES Verschlüsselung nur DB Passwort,kann und muss entschlüsselt werden
             *     wird im DB connectionStrin als Klartext benötigt
             * 2-  Hash für Benutzerpasswörter hann nicht entschlüsselt werden 
             *     Hash wird mit neuem Hash verglichen              * 
             */
            verschTyp = vTyp;
            mode = mode.ToLower();
            if (mode == "neu") mode = "neu vergeben";
            else if (mode == "ändern") mode = "ändern";
            if (verschTyp == 1) lblName.Text = $"Datenbankpasswort {mode}";
            else if (verschTyp == 2) lblName.Text = $"Mail Passwort {mode}";
            lblLänge.Text = $"Passwort muss mindestens \r\n {minPasswordLength} Zeichen haben.";
        }
        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            string password1 = txtPW1.Text;
            string password2 = txtPW2.Text;

            // Prüfung auf Mindestlänge und Gleichheit
            if (password1 == "" || password2 == "")
            {
                MessageBox.Show("Bitte Passwort wiederholen!.");
                return;
            }
            if (password1.Length < minPasswordLength)
            {
                MessageBox.Show($"Passwort muss mindestens {minPasswordLength} Zeichen lang sein.");
                return;
            }
            if (password1 != password2)
            {
                MessageBox.Show("Passwörter stimmen nicht überein.");
                return;
            }
            if (verschTyp == 1)
            {
                // Passwort setzen und Form schließen
                string encryptedPassword = PasswortEncrypt.Encrypt(password1);
                Properties.Settings.Default.PasswortDB = encryptedPassword;
                Properties.Settings.Default.Save();
                //  Logging.Instance.Log("0", "AP", "Datenbankpasswort geändert");
                DialogResult = DialogResult.OK; // Signalisiert Erfolg
                Close();
            }
            else if (verschTyp == 2)
            {
                // Passwort setzen und Form schließen
                string encryptedPassword = PasswortEncrypt.Encrypt(password1);
                Properties.Settings.Default.MailPasswort = encryptedPassword;
                Properties.Settings.Default.Save();
                //  Logging.Instance.Log("0", "AP", "Datenbankpasswort geändert");
                DialogResult = DialogResult.OK; // Signalisiert Erfolg
                Close();
            }

            else
            {
                MessageBox.Show("Verschlüsselungstyp Passt nicht");
                return;
            }
        }
        private void BtnAbbruch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Passwortbearbeitung abgebrochen");
            Close();
        }
    }
}
