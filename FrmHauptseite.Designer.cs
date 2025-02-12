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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEinstellungen
            // 
            btnEinstellungen.Location = new Point(744, 247);
            btnEinstellungen.Name = "btnEinstellungen";
            btnEinstellungen.Size = new Size(94, 23);
            btnEinstellungen.TabIndex = 0;
            btnEinstellungen.Text = "Einstellungen";
            btnEinstellungen.UseVisualStyleBackColor = true;
            btnEinstellungen.Click += Btn_Einstellungen_Click;
            // 
            // btnSenden
            // 
            btnSenden.Location = new Point(19, 88);
            btnSenden.Name = "btnSenden";
            btnSenden.Size = new Size(94, 23);
            btnSenden.TabIndex = 1;
            btnSenden.Text = "Senden";
            btnSenden.UseVisualStyleBackColor = true;
            btnSenden.Click += Button1_Click;
            // 
            // txtSenden
            // 
            txtSenden.Location = new Point(19, 37);
            txtSenden.Name = "txtSenden";
            txtSenden.Size = new Size(94, 23);
            txtSenden.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSenden);
            groupBox1.Controls.Add(btnSenden);
            groupBox1.Location = new Point(725, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 134);
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
            datum.Width = 110;
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
            listGesendet.SelectedIndexChanged += listGesendet_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Datum / Uhrzeit";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Sendedaten zur SPS";
            columnHeader2.Width = 150;
            // 
            // FrmHauptseite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 321);
            Controls.Add(listGesendet);
            Controls.Add(listEmpfang);
            Controls.Add(groupBox1);
            Controls.Add(btnEinstellungen);
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
    }
}
