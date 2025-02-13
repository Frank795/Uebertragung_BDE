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
            btnEinstellungen.Location = new Point(850, 329);
            btnEinstellungen.Margin = new Padding(3, 4, 3, 4);
            btnEinstellungen.Name = "btnEinstellungen";
            btnEinstellungen.Size = new Size(107, 31);
            btnEinstellungen.TabIndex = 0;
            btnEinstellungen.Text = "Einstellungen";
            btnEinstellungen.UseVisualStyleBackColor = true;
            btnEinstellungen.Click += Btn_Einstellungen_Click;
            // 
            // btnSenden
            // 
            btnSenden.Location = new Point(22, 117);
            btnSenden.Margin = new Padding(3, 4, 3, 4);
            btnSenden.Name = "btnSenden";
            btnSenden.Size = new Size(107, 31);
            btnSenden.TabIndex = 1;
            btnSenden.Text = "Senden";
            btnSenden.UseVisualStyleBackColor = true;
            btnSenden.Click += Button1_Click;
            // 
            // txtSenden
            // 
            txtSenden.Location = new Point(22, 49);
            txtSenden.Margin = new Padding(3, 4, 3, 4);
            txtSenden.Name = "txtSenden";
            txtSenden.Size = new Size(107, 27);
            txtSenden.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSenden);
            groupBox1.Controls.Add(btnSenden);
            groupBox1.Location = new Point(829, 41);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(153, 179);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Testdaten senden";
            // 
            // listEmpfang
            // 
            listEmpfang.Columns.AddRange(new ColumnHeader[] { datum, daten });
            listEmpfang.GridLines = true;
            listEmpfang.Location = new Point(24, 41);
            listEmpfang.Margin = new Padding(3, 4, 3, 4);
            listEmpfang.Name = "listEmpfang";
            listEmpfang.Size = new Size(412, 348);
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
            listGesendet.Location = new Point(471, 41);
            listGesendet.Margin = new Padding(3, 4, 3, 4);
            listGesendet.Name = "listGesendet";
            listGesendet.Size = new Size(309, 348);
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
            // FrmHauptseite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 428);
            Controls.Add(listGesendet);
            Controls.Add(listEmpfang);
            Controls.Add(groupBox1);
            Controls.Add(btnEinstellungen);
            Margin = new Padding(3, 4, 3, 4);
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
