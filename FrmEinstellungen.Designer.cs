namespace Übertragung_BDE
{
    partial class FrmEinstellungen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSqlIP = new Label();
            lblSqlPort = new Label();
            lblSqlBenutzer = new Label();
            lblSqlPw = new Label();
            lblSqlDb = new Label();
            lblIpSPS = new Label();
            txtSqlIp = new TextBox();
            txtSqlPort = new TextBox();
            txtSqlBenutzer = new TextBox();
            txtSqlPw = new TextBox();
            txtSqlDb = new TextBox();
            txtSPSIp = new TextBox();
            btnSpeichern = new Button();
            btnAbbrechen = new Button();
            label1 = new Label();
            txtSPSPort = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DB_SPS = new TabPage();
            Mail = new TabPage();
            txtSmtpAdresse = new TextBox();
            label8 = new Label();
            txtSmtpPort = new TextBox();
            label3 = new Label();
            txtMailAdresse = new TextBox();
            label5 = new Label();
            txtMailPasswort = new TextBox();
            label4 = new Label();
            txtMailAbsender = new TextBox();
            lbl_Absender = new Label();
            lblMailEmpfaenger = new Label();
            txtMailEmpfaenger = new TextBox();
            btnTestMail = new Button();
            tabControl1.SuspendLayout();
            DB_SPS.SuspendLayout();
            Mail.SuspendLayout();
            SuspendLayout();
            // 
            // lblSqlIP
            // 
            lblSqlIP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlIP.Location = new Point(15, 15);
            lblSqlIP.Name = "lblSqlIP";
            lblSqlIP.Size = new Size(155, 25);
            lblSqlIP.TabIndex = 0;
            lblSqlIP.Text = "SQL IP Addresse";
            // 
            // lblSqlPort
            // 
            lblSqlPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlPort.Location = new Point(15, 50);
            lblSqlPort.Name = "lblSqlPort";
            lblSqlPort.Size = new Size(155, 25);
            lblSqlPort.TabIndex = 1;
            lblSqlPort.Text = "SQL Port";
            // 
            // lblSqlBenutzer
            // 
            lblSqlBenutzer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlBenutzer.Location = new Point(15, 85);
            lblSqlBenutzer.Name = "lblSqlBenutzer";
            lblSqlBenutzer.Size = new Size(155, 25);
            lblSqlBenutzer.TabIndex = 2;
            lblSqlBenutzer.Text = "SQL Benutzer";
            // 
            // lblSqlPw
            // 
            lblSqlPw.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlPw.Location = new Point(15, 120);
            lblSqlPw.Name = "lblSqlPw";
            lblSqlPw.Size = new Size(155, 25);
            lblSqlPw.TabIndex = 3;
            lblSqlPw.Text = "SQL Passwort";
            // 
            // lblSqlDb
            // 
            lblSqlDb.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlDb.Location = new Point(15, 155);
            lblSqlDb.Name = "lblSqlDb";
            lblSqlDb.Size = new Size(155, 25);
            lblSqlDb.TabIndex = 4;
            lblSqlDb.Text = "SQL Datenbank";
            // 
            // lblIpSPS
            // 
            lblIpSPS.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblIpSPS.Location = new Point(15, 190);
            lblIpSPS.Name = "lblIpSPS";
            lblIpSPS.Size = new Size(155, 25);
            lblIpSPS.TabIndex = 5;
            lblIpSPS.Text = "SPS IP Addresse";
            // 
            // txtSqlIp
            // 
            txtSqlIp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlIp.Location = new Point(190, 15);
            txtSqlIp.Margin = new Padding(3, 2, 3, 2);
            txtSqlIp.Name = "txtSqlIp";
            txtSqlIp.Size = new Size(155, 26);
            txtSqlIp.TabIndex = 6;
            txtSqlIp.TextChanged += TxtSqlSrv_TextChanged;
            // 
            // txtSqlPort
            // 
            txtSqlPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlPort.Location = new Point(190, 50);
            txtSqlPort.Margin = new Padding(3, 2, 3, 2);
            txtSqlPort.Name = "txtSqlPort";
            txtSqlPort.Size = new Size(155, 26);
            txtSqlPort.TabIndex = 7;
            txtSqlPort.TextChanged += TxtSqlPort_TextChanged;
            // 
            // txtSqlBenutzer
            // 
            txtSqlBenutzer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlBenutzer.Location = new Point(190, 85);
            txtSqlBenutzer.Margin = new Padding(3, 2, 3, 2);
            txtSqlBenutzer.Name = "txtSqlBenutzer";
            txtSqlBenutzer.Size = new Size(155, 26);
            txtSqlBenutzer.TabIndex = 8;
            txtSqlBenutzer.TextChanged += TxtSqlBenutzer_TextChanged;
            // 
            // txtSqlPw
            // 
            txtSqlPw.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlPw.Location = new Point(190, 120);
            txtSqlPw.Margin = new Padding(3, 2, 3, 2);
            txtSqlPw.Name = "txtSqlPw";
            txtSqlPw.Size = new Size(155, 26);
            txtSqlPw.TabIndex = 9;
            txtSqlPw.Click += TxtSqlPw_Click;
            // 
            // txtSqlDb
            // 
            txtSqlDb.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlDb.Location = new Point(190, 155);
            txtSqlDb.Margin = new Padding(3, 2, 3, 2);
            txtSqlDb.Name = "txtSqlDb";
            txtSqlDb.Size = new Size(155, 26);
            txtSqlDb.TabIndex = 10;
            txtSqlDb.TextChanged += TxtSqlDb_TextChanged;
            // 
            // txtSPSIp
            // 
            txtSPSIp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSPSIp.Location = new Point(190, 190);
            txtSPSIp.Margin = new Padding(3, 2, 3, 2);
            txtSPSIp.Name = "txtSPSIp";
            txtSPSIp.Size = new Size(155, 26);
            txtSPSIp.TabIndex = 11;
            txtSPSIp.TextChanged += TxtSPSIp_TextChanged;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSpeichern.Location = new Point(21, 364);
            btnSpeichern.Margin = new Padding(3, 2, 3, 2);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(140, 30);
            btnSpeichern.TabIndex = 14;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += BtnSpeichern_Click;
            // 
            // btnAbbrechen
            // 
            btnAbbrechen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAbbrechen.Location = new Point(251, 364);
            btnAbbrechen.Margin = new Padding(3, 2, 3, 2);
            btnAbbrechen.Name = "btnAbbrechen";
            btnAbbrechen.Size = new Size(140, 30);
            btnAbbrechen.TabIndex = 15;
            btnAbbrechen.Text = "Abbrechen";
            btnAbbrechen.UseVisualStyleBackColor = true;
            btnAbbrechen.Click += BtnAbbrechen_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(15, 225);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 16;
            label1.Text = "SPS Port";
            // 
            // txtSPSPort
            // 
            txtSPSPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSPSPort.Location = new Point(190, 225);
            txtSPSPort.Margin = new Padding(3, 2, 3, 2);
            txtSPSPort.Name = "txtSPSPort";
            txtSPSPort.Size = new Size(155, 26);
            txtSPSPort.TabIndex = 17;
            txtSPSPort.TextChanged += TxtSPSPort_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(DB_SPS);
            tabControl1.Controls.Add(Mail);
            tabControl1.Location = new Point(7, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(408, 336);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(400, 308);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "System";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DB_SPS
            // 
            DB_SPS.Controls.Add(txtSPSPort);
            DB_SPS.Controls.Add(label1);
            DB_SPS.Controls.Add(txtSPSIp);
            DB_SPS.Controls.Add(lblSqlDb);
            DB_SPS.Controls.Add(txtSqlIp);
            DB_SPS.Controls.Add(lblSqlPw);
            DB_SPS.Controls.Add(txtSqlDb);
            DB_SPS.Controls.Add(lblSqlIP);
            DB_SPS.Controls.Add(lblSqlBenutzer);
            DB_SPS.Controls.Add(txtSqlBenutzer);
            DB_SPS.Controls.Add(lblIpSPS);
            DB_SPS.Controls.Add(txtSqlPw);
            DB_SPS.Controls.Add(txtSqlPort);
            DB_SPS.Controls.Add(lblSqlPort);
            DB_SPS.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DB_SPS.Location = new Point(4, 24);
            DB_SPS.Name = "DB_SPS";
            DB_SPS.Padding = new Padding(3);
            DB_SPS.Size = new Size(400, 308);
            DB_SPS.TabIndex = 0;
            DB_SPS.Text = "DB + SPS";
            DB_SPS.UseVisualStyleBackColor = true;
            // 
            // Mail
            // 
            Mail.Controls.Add(txtSmtpAdresse);
            Mail.Controls.Add(label8);
            Mail.Controls.Add(txtSmtpPort);
            Mail.Controls.Add(label3);
            Mail.Controls.Add(txtMailAdresse);
            Mail.Controls.Add(label5);
            Mail.Controls.Add(txtMailPasswort);
            Mail.Controls.Add(label4);
            Mail.Controls.Add(txtMailAbsender);
            Mail.Controls.Add(lbl_Absender);
            Mail.Controls.Add(lblMailEmpfaenger);
            Mail.Controls.Add(txtMailEmpfaenger);
            Mail.Controls.Add(btnTestMail);
            Mail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mail.Location = new Point(4, 24);
            Mail.Name = "Mail";
            Mail.Padding = new Padding(3);
            Mail.Size = new Size(400, 308);
            Mail.TabIndex = 1;
            Mail.Text = "Mail";
            Mail.UseVisualStyleBackColor = true;
            // 
            // txtSmtpAdresse
            // 
            txtSmtpAdresse.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSmtpAdresse.Location = new Point(190, 120);
            txtSmtpAdresse.Margin = new Padding(3, 2, 3, 2);
            txtSmtpAdresse.Name = "txtSmtpAdresse";
            txtSmtpAdresse.Size = new Size(155, 26);
            txtSmtpAdresse.TabIndex = 20;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(15, 120);
            label8.Name = "label8";
            label8.Size = new Size(155, 25);
            label8.TabIndex = 19;
            label8.Text = "SMTP Adresse";
            // 
            // txtSmtpPort
            // 
            txtSmtpPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSmtpPort.Location = new Point(190, 155);
            txtSmtpPort.Margin = new Padding(3, 2, 3, 2);
            txtSmtpPort.Name = "txtSmtpPort";
            txtSmtpPort.Size = new Size(155, 26);
            txtSmtpPort.TabIndex = 14;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(15, 155);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 13;
            label3.Text = "SMTP Port";
            // 
            // txtMailAdresse
            // 
            txtMailAdresse.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtMailAdresse.Location = new Point(190, 50);
            txtMailAdresse.Margin = new Padding(3, 2, 3, 2);
            txtMailAdresse.Name = "txtMailAdresse";
            txtMailAdresse.Size = new Size(155, 26);
            txtMailAdresse.TabIndex = 12;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(15, 50);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 11;
            label5.Text = "Mail Adresse Absender";
            // 
            // txtMailPasswort
            // 
            txtMailPasswort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtMailPasswort.Location = new Point(190, 85);
            txtMailPasswort.Margin = new Padding(3, 2, 3, 2);
            txtMailPasswort.Name = "txtMailPasswort";
            txtMailPasswort.Size = new Size(155, 26);
            txtMailPasswort.TabIndex = 10;
            txtMailPasswort.Click += TxtMailPasswort_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(15, 85);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 9;
            label4.Text = "Absender Passwort";
            // 
            // txtMailAbsender
            // 
            txtMailAbsender.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtMailAbsender.Location = new Point(190, 15);
            txtMailAbsender.Margin = new Padding(3, 2, 3, 2);
            txtMailAbsender.Name = "txtMailAbsender";
            txtMailAbsender.Size = new Size(155, 26);
            txtMailAbsender.TabIndex = 8;
            // 
            // lbl_Absender
            // 
            lbl_Absender.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbl_Absender.Location = new Point(15, 15);
            lbl_Absender.Name = "lbl_Absender";
            lbl_Absender.Size = new Size(155, 25);
            lbl_Absender.TabIndex = 7;
            lbl_Absender.Text = "Name Absender";
            // 
            // lblMailEmpfaenger
            // 
            lblMailEmpfaenger.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMailEmpfaenger.Location = new Point(19, 201);
            lblMailEmpfaenger.Name = "lblMailEmpfaenger";
            lblMailEmpfaenger.Size = new Size(226, 15);
            lblMailEmpfaenger.TabIndex = 2;
            lblMailEmpfaenger.Text = "Liste Mailempfänger \" ; \" getrennt";
            lblMailEmpfaenger.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMailEmpfaenger
            // 
            txtMailEmpfaenger.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMailEmpfaenger.Location = new Point(15, 224);
            txtMailEmpfaenger.Multiline = true;
            txtMailEmpfaenger.Name = "txtMailEmpfaenger";
            txtMailEmpfaenger.Size = new Size(230, 63);
            txtMailEmpfaenger.TabIndex = 1;
            // 
            // btnTestMail
            // 
            btnTestMail.Location = new Point(255, 243);
            btnTestMail.Name = "btnTestMail";
            btnTestMail.Size = new Size(125, 23);
            btnTestMail.TabIndex = 0;
            btnTestMail.Text = "Testmail senden";
            btnTestMail.UseVisualStyleBackColor = true;
            btnTestMail.Click += BtnTestMail_Click;
            // 
            // FrmEinstellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 414);
            Controls.Add(tabControl1);
            Controls.Add(btnAbbrechen);
            Controls.Add(btnSpeichern);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmEinstellungen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Einstellungen";
            tabControl1.ResumeLayout(false);
            DB_SPS.ResumeLayout(false);
            DB_SPS.PerformLayout();
            Mail.ResumeLayout(false);
            Mail.PerformLayout();
            ResumeLayout(false);
        }

       

        #endregion

        private Label lblSqlIP;
        private Label lblSqlPort;
        private Label lblSqlBenutzer;
        private Label lblSqlPw;
        private Label lblSqlDb;
        private Label lblIpSPS;
        private TextBox txtSqlIp;
        private TextBox txtSqlPort;
        private TextBox txtSqlBenutzer;
        private TextBox txtSqlPw;
        private TextBox txtSqlDb;
        private TextBox txtSPSIp;
        private Button btnSpeichern;
        private Button btnAbbrechen;
        private Label label1;
        private TextBox txtSPSPort;
        private TabControl tabControl1;
        private TabPage DB_SPS;
        private TabPage Mail;
        private TabPage tabPage1;
        private Button btnTestMail;
        private TextBox txtMailEmpfaenger;
        private TextBox txtMailAbsender;
        private Label lbl_Absender;
        private Label lblMailEmpfaenger;
        private TextBox txtMailAdresse;
        private Label label5;
        private TextBox txtMailPasswort;
        private Label label4;
        private TextBox txtSmtpAdresse;
        private Label label8;
        private TextBox txtSmtpPort;
        private Label label3;
    }
}