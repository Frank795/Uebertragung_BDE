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
            DB_SPS = new TabPage();
            Mail = new TabPage();
            tabPage1 = new TabPage();
            tabControl1.SuspendLayout();
            DB_SPS.SuspendLayout();
            SuspendLayout();
            // 
            // lblSqlIP
            // 
            lblSqlIP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlIP.Location = new Point(29, 22);
            lblSqlIP.Name = "lblSqlIP";
            lblSqlIP.Size = new Size(115, 25);
            lblSqlIP.TabIndex = 0;
            lblSqlIP.Text = "SQL IP Addresse";
            // 
            // lblSqlPort
            // 
            lblSqlPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlPort.Location = new Point(29, 68);
            lblSqlPort.Name = "lblSqlPort";
            lblSqlPort.Size = new Size(115, 25);
            lblSqlPort.TabIndex = 1;
            lblSqlPort.Text = "SQL Port";
            // 
            // lblSqlBenutzer
            // 
            lblSqlBenutzer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlBenutzer.Location = new Point(29, 114);
            lblSqlBenutzer.Name = "lblSqlBenutzer";
            lblSqlBenutzer.Size = new Size(115, 25);
            lblSqlBenutzer.TabIndex = 2;
            lblSqlBenutzer.Text = "SQL Benutzer";
            // 
            // lblSqlPw
            // 
            lblSqlPw.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlPw.Location = new Point(29, 160);
            lblSqlPw.Name = "lblSqlPw";
            lblSqlPw.Size = new Size(115, 25);
            lblSqlPw.TabIndex = 3;
            lblSqlPw.Text = "SQL Passwort";
            // 
            // lblSqlDb
            // 
            lblSqlDb.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSqlDb.Location = new Point(29, 206);
            lblSqlDb.Name = "lblSqlDb";
            lblSqlDb.Size = new Size(115, 25);
            lblSqlDb.TabIndex = 4;
            lblSqlDb.Text = "SQL Datenbank";
            // 
            // lblIpSPS
            // 
            lblIpSPS.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblIpSPS.Location = new Point(29, 252);
            lblIpSPS.Name = "lblIpSPS";
            lblIpSPS.Size = new Size(115, 25);
            lblIpSPS.TabIndex = 5;
            lblIpSPS.Text = "SPS IP Addresse";
            // 
            // txtSqlIp
            // 
            txtSqlIp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlIp.Location = new Point(170, 22);
            txtSqlIp.Margin = new Padding(3, 2, 3, 2);
            txtSqlIp.Name = "txtSqlIp";
            txtSqlIp.Size = new Size(170, 26);
            txtSqlIp.TabIndex = 6;
            txtSqlIp.TextChanged += TxtSqlSrv_TextChanged;
            // 
            // txtSqlPort
            // 
            txtSqlPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlPort.Location = new Point(170, 68);
            txtSqlPort.Margin = new Padding(3, 2, 3, 2);
            txtSqlPort.Name = "txtSqlPort";
            txtSqlPort.Size = new Size(170, 26);
            txtSqlPort.TabIndex = 7;
            txtSqlPort.TextChanged += TxtSqlPort_TextChanged;
            // 
            // txtSqlBenutzer
            // 
            txtSqlBenutzer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlBenutzer.Location = new Point(170, 114);
            txtSqlBenutzer.Margin = new Padding(3, 2, 3, 2);
            txtSqlBenutzer.Name = "txtSqlBenutzer";
            txtSqlBenutzer.Size = new Size(170, 26);
            txtSqlBenutzer.TabIndex = 8;
            txtSqlBenutzer.TextChanged += TxtSqlBenutzer_TextChanged;
            // 
            // txtSqlPw
            // 
            txtSqlPw.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlPw.Location = new Point(170, 160);
            txtSqlPw.Margin = new Padding(3, 2, 3, 2);
            txtSqlPw.Name = "txtSqlPw";
            txtSqlPw.Size = new Size(170, 26);
            txtSqlPw.TabIndex = 9;
            // 
            // txtSqlDb
            // 
            txtSqlDb.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSqlDb.Location = new Point(170, 206);
            txtSqlDb.Margin = new Padding(3, 2, 3, 2);
            txtSqlDb.Name = "txtSqlDb";
            txtSqlDb.Size = new Size(170, 26);
            txtSqlDb.TabIndex = 10;
            txtSqlDb.TextChanged += TxtSqlDb_TextChanged;
            // 
            // txtSPSIp
            // 
            txtSPSIp.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSPSIp.Location = new Point(170, 252);
            txtSPSIp.Margin = new Padding(3, 2, 3, 2);
            txtSPSIp.Name = "txtSPSIp";
            txtSPSIp.Size = new Size(170, 26);
            txtSPSIp.TabIndex = 11;
            txtSPSIp.TextChanged += TxtSPSIp_TextChanged;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSpeichern.Location = new Point(21, 412);
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
            btnAbbrechen.Location = new Point(251, 412);
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
            label1.Location = new Point(31, 298);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 16;
            label1.Text = "SPS Port";
            // 
            // txtSPSPort
            // 
            txtSPSPort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtSPSPort.Location = new Point(170, 298);
            txtSPSPort.Margin = new Padding(3, 2, 3, 2);
            txtSPSPort.Name = "txtSPSPort";
            txtSPSPort.Size = new Size(170, 26);
            txtSPSPort.TabIndex = 17;
            txtSPSPort.TextChanged += TxtSPSPort_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(DB_SPS);
            tabControl1.Controls.Add(Mail);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(387, 381);
            tabControl1.TabIndex = 18;
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
            DB_SPS.Size = new Size(379, 353);
            DB_SPS.TabIndex = 0;
            DB_SPS.Text = "DB + SPS";
            DB_SPS.UseVisualStyleBackColor = true;
            // 
            // Mail
            // 
            Mail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mail.Location = new Point(4, 24);
            Mail.Name = "Mail";
            Mail.Padding = new Padding(3);
            Mail.Size = new Size(379, 353);
            Mail.TabIndex = 1;
            Mail.Text = "Mail";
            Mail.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(379, 353);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "System";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // FrmEinstellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 467);
            Controls.Add(tabControl1);
            Controls.Add(btnAbbrechen);
            Controls.Add(btnSpeichern);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmEinstellungen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Einstellungen";
            Load += FrmEinstellungen_Load;
            tabControl1.ResumeLayout(false);
            DB_SPS.ResumeLayout(false);
            DB_SPS.PerformLayout();
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
    }
}