namespace Übertragung_BDE
{
    partial class FrmHauptseite
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEinstellungen = new Button();
            btnSenden = new Button();
            txtSenden = new TextBox();
            groupBox1 = new GroupBox();
            listEmpfang = new ListView();
            datum = new ColumnHeader();
            daten = new ColumnHeader();
            listGesendet = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnAutoStop = new Button();
            btnAutoStart = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEinstellungen
            // 
            btnEinstellungen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEinstellungen.Location = new Point(715, 242);
            btnEinstellungen.Name = "btnEinstellungen";
            btnEinstellungen.Size = new Size(94, 47);
            btnEinstellungen.TabIndex = 0;
            btnEinstellungen.Text = "Einstellungen";
            btnEinstellungen.UseVisualStyleBackColor = true;
            btnEinstellungen.Click += Btn_Einstellungen_Click;
            // 
            // btnSenden
            // 
            btnSenden.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSenden.Location = new Point(48, 88);
            btnSenden.Name = "btnSenden";
            btnSenden.Size = new Size(94, 23);
            btnSenden.TabIndex = 1;
            btnSenden.Text = "Senden";
            btnSenden.UseVisualStyleBackColor = true;
            btnSenden.Click += Button1_Click;
            // 
            // txtSenden
            // 
            txtSenden.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenden.Location = new Point(48, 37);
            txtSenden.Name = "txtSenden";
            txtSenden.Size = new Size(94, 23);
            txtSenden.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSenden);
            groupBox1.Controls.Add(btnSenden);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(715, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 134);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Testdaten senden";
            // 
            // listEmpfang
            // 
            listEmpfang.Columns.AddRange(new ColumnHeader[] { datum, daten });
            listEmpfang.GridLines = true;
            listEmpfang.Location = new Point(21, 31);
            listEmpfang.Name = "listEmpfang";
            listEmpfang.Size = new Size(361, 262);
            listEmpfang.TabIndex = 4;
            listEmpfang.UseCompatibleStateImageBehavior = false;
            listEmpfang.View = View.Details;
            // 
            // datum
            // 
            datum.Text = "Datum / Uhrzeit";
            datum.Width = 120;
            // 
            // daten
            // 
            daten.Text = "Eingangsdaten von SPS";
            daten.Width = 240;
            // 
            // listGesendet
            // 
            listGesendet.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listGesendet.GridLines = true;
            listGesendet.Location = new Point(412, 31);
            listGesendet.Name = "listGesendet";
            listGesendet.Size = new Size(271, 262);
            listGesendet.TabIndex = 5;
            listGesendet.UseCompatibleStateImageBehavior = false;
            listGesendet.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Datum / Uhrzeit";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Sendedaten zur SPS";
            columnHeader2.Width = 150;
            // 
            // btnAutoStop
            // 
            btnAutoStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAutoStop.ForeColor = Color.Red;
            btnAutoStop.Location = new Point(715, 184);
            btnAutoStop.Name = "btnAutoStop";
            btnAutoStop.Size = new Size(94, 47);
            btnAutoStop.TabIndex = 6;
            btnAutoStop.Text = "Automatik\r\nSTOP";
            btnAutoStop.UseVisualStyleBackColor = true;
            btnAutoStop.Click += BtnAutoStop_Click;
            // 
            // btnAutoStart
            // 
            btnAutoStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAutoStart.ForeColor = Color.Green;
            btnAutoStart.Location = new Point(811, 184);
            btnAutoStart.Name = "btnAutoStart";
            btnAutoStart.Size = new Size(94, 47);
            btnAutoStart.TabIndex = 7;
            btnAutoStart.Text = "Automatik\r\nSTART";
            btnAutoStart.UseVisualStyleBackColor = true;
            btnAutoStart.Click += BtnAutoStart_Click;
            // 
            // FrmHauptseite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 311);
            Controls.Add(btnAutoStart);
            Controls.Add(btnAutoStop);
            Controls.Add(listGesendet);
            Controls.Add(listEmpfang);
            Controls.Add(groupBox1);
            Controls.Add(btnEinstellungen);
            MaximumSize = new Size(950, 350);
            MinimumSize = new Size(950, 350);
            Name = "FrmHauptseite";
            Text = "Form1";
            Load += Hauptseite_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEinstellungen;
        private Button btnSenden;
        private TextBox txtSenden;
        private GroupBox groupBox1;
        private ListView listEmpfang;
        private ColumnHeader datum;
        private ColumnHeader daten;
        public ListView listGesendet;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnAutoStop;
        private Button btnAutoStart;
    }
}
