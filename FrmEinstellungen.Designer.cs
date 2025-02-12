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
            SuspendLayout();
            // 
            // lblSqlIP
            // 
            lblSqlIP.AutoSize = true;
            lblSqlIP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlIP.Location = new Point(21, 27);
            lblSqlIP.Name = "lblSqlIP";
            lblSqlIP.Size = new Size(111, 19);
            lblSqlIP.TabIndex = 0;
            lblSqlIP.Text = "SQL IP Addresse";
            // 
            // lblSqlPort
            // 
            lblSqlPort.AutoSize = true;
            lblSqlPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlPort.Location = new Point(21, 57);
            lblSqlPort.Name = "lblSqlPort";
            lblSqlPort.Size = new Size(65, 19);
            lblSqlPort.TabIndex = 1;
            lblSqlPort.Text = "SQL Port";
            // 
            // lblSqlBenutzer
            // 
            lblSqlBenutzer.AutoSize = true;
            lblSqlBenutzer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlBenutzer.Location = new Point(21, 87);
            lblSqlBenutzer.Name = "lblSqlBenutzer";
            lblSqlBenutzer.Size = new Size(94, 19);
            lblSqlBenutzer.TabIndex = 2;
            lblSqlBenutzer.Text = "SQL Benutzer";
            // 
            // lblSqlPw
            // 
            lblSqlPw.AutoSize = true;
            lblSqlPw.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlPw.Location = new Point(21, 117);
            lblSqlPw.Name = "lblSqlPw";
            lblSqlPw.Size = new Size(95, 19);
            lblSqlPw.TabIndex = 3;
            lblSqlPw.Text = "SQL Passwort";
            // 
            // lblSqlDb
            // 
            lblSqlDb.AutoSize = true;
            lblSqlDb.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlDb.Location = new Point(21, 147);
            lblSqlDb.Name = "lblSqlDb";
            lblSqlDb.Size = new Size(106, 19);
            lblSqlDb.TabIndex = 4;
            lblSqlDb.Text = "SQL Datenbank";
            // 
            // lblIpSPS
            // 
            lblIpSPS.AutoSize = true;
            lblIpSPS.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblIpSPS.Location = new Point(21, 177);
            lblIpSPS.Name = "lblIpSPS";
            lblIpSPS.Size = new Size(109, 19);
            lblIpSPS.TabIndex = 5;
            lblIpSPS.Text = "SPS IP Addresse";
            // 
            // txtSqlIp
            // 
            txtSqlIp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlIp.Location = new Point(152, 27);
            txtSqlIp.Margin = new Padding(3, 2, 3, 2);
            txtSqlIp.Name = "txtSqlIp";
            txtSqlIp.Size = new Size(168, 26);
            txtSqlIp.TabIndex = 6;
            txtSqlIp.TextChanged += TxtSqlSrv_TextChanged;
            // 
            // txtSqlPort
            // 
            txtSqlPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlPort.Location = new Point(152, 57);
            txtSqlPort.Margin = new Padding(3, 2, 3, 2);
            txtSqlPort.Name = "txtSqlPort";
            txtSqlPort.Size = new Size(168, 26);
            txtSqlPort.TabIndex = 7;
            txtSqlPort.TextChanged += TxtSqlPort_TextChanged;
            // 
            // txtSqlBenutzer
            // 
            txtSqlBenutzer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlBenutzer.Location = new Point(152, 87);
            txtSqlBenutzer.Margin = new Padding(3, 2, 3, 2);
            txtSqlBenutzer.Name = "txtSqlBenutzer";
            txtSqlBenutzer.Size = new Size(168, 26);
            txtSqlBenutzer.TabIndex = 8;
            txtSqlBenutzer.TextChanged += TxtSqlBenutzer_TextChanged;
            // 
            // txtSqlPw
            // 
            txtSqlPw.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlPw.Location = new Point(152, 117);
            txtSqlPw.Margin = new Padding(3, 2, 3, 2);
            txtSqlPw.Name = "txtSqlPw";
            txtSqlPw.Size = new Size(168, 26);
            txtSqlPw.TabIndex = 9;
            // 
            // txtSqlDb
            // 
            txtSqlDb.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlDb.Location = new Point(152, 147);
            txtSqlDb.Margin = new Padding(3, 2, 3, 2);
            txtSqlDb.Name = "txtSqlDb";
            txtSqlDb.Size = new Size(168, 26);
            txtSqlDb.TabIndex = 10;
            txtSqlDb.TextChanged += TxtSqlDb_TextChanged;
            // 
            // txtSPSIp
            // 
            txtSPSIp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSPSIp.Location = new Point(152, 177);
            txtSPSIp.Margin = new Padding(3, 2, 3, 2);
            txtSPSIp.Name = "txtSPSIp";
            txtSPSIp.Size = new Size(168, 26);
            txtSPSIp.TabIndex = 11;
            txtSPSIp.TextChanged += TxtSPSIp_TextChanged;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSpeichern.Location = new Point(21, 255);
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
            btnAbbrechen.Location = new Point(180, 255);
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
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(21, 207);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 16;
            label1.Text = "SPS Port";
            // 
            // txtSPSPort
            // 
            txtSPSPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSPSPort.Location = new Point(152, 207);
            txtSPSPort.Margin = new Padding(3, 2, 3, 2);
            txtSPSPort.Name = "txtSPSPort";
            txtSPSPort.Size = new Size(168, 26);
            txtSPSPort.TabIndex = 17;
            txtSPSPort.TextChanged += TxtSPSPort_TextChanged;
            // 
            // FrmEinstellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 301);
            Controls.Add(label1);
            Controls.Add(txtSPSPort);
            Controls.Add(txtSqlIp);
            Controls.Add(btnAbbrechen);
            Controls.Add(lblSqlIP);
            Controls.Add(txtSqlBenutzer);
            Controls.Add(btnSpeichern);
            Controls.Add(txtSqlPort);
            Controls.Add(lblSqlPort);
            Controls.Add(txtSqlPw);
            Controls.Add(lblIpSPS);
            Controls.Add(lblSqlBenutzer);
            Controls.Add(txtSqlDb);
            Controls.Add(lblSqlPw);
            Controls.Add(lblSqlDb);
            Controls.Add(txtSPSIp);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(370, 340);
            MinimumSize = new Size(370, 340);
            Name = "FrmEinstellungen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Einstellungen";
            ResumeLayout(false);
            PerformLayout();
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
    }
}