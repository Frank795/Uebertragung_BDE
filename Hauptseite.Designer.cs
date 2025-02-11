namespace Übertragung_BDE
{
    partial class Hauptseite
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
            SuspendLayout();
            // 
            // btnEinstellungen
            // 
            btnEinstellungen.Location = new Point(833, 293);
            btnEinstellungen.Name = "btnEinstellungen";
            btnEinstellungen.Size = new Size(101, 34);
            btnEinstellungen.TabIndex = 0;
            btnEinstellungen.Text = "Einstellungen";
            btnEinstellungen.UseVisualStyleBackColor = true;
            btnEinstellungen.Click += Btn_Einstellungen_Click;
            // 
            // Hauptseite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 351);
            Controls.Add(btnEinstellungen);
            Name = "Hauptseite";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEinstellungen;
    }
}
