namespace Übertragung_BDE

{
    partial class FrmPasswortvergabe
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
            
            btnSpeichern = new Button();
            txtPW1 = new TextBox();
            txtPW2 = new TextBox();
            btnAbbruch = new Button();
            lblName = new Label();
            lblLänge = new Label();
            SuspendLayout();
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(25, 269);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(95, 30);
            btnSpeichern.TabIndex = 3;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += BtnSpeichern_Click;
            // 
            // txtPW1
            // 
            txtPW1.Font = new Font("Segoe UI", 12F);
            txtPW1.Location = new Point(12, 91);
            txtPW1.Name = "txtPW1";
            txtPW1.PasswordChar = '*';
            txtPW1.Size = new Size(400, 34);
            txtPW1.TabIndex = 1;
            // 
            // txtPW2
            // 
            txtPW2.Font = new Font("Segoe UI", 12F);
            txtPW2.Location = new Point(12, 157);
            txtPW2.Name = "txtPW2";
            txtPW2.PasswordChar = '*';
            txtPW2.Size = new Size(400, 34);
            txtPW2.TabIndex = 2;
            // 
            // btnAbbruch
            // 
            btnAbbruch.Location = new Point(303, 269);
            btnAbbruch.Name = "btnAbbruch";
            btnAbbruch.Size = new Size(95, 30);
            btnAbbruch.TabIndex = 4;
            btnAbbruch.Text = "Abbruch";
            btnAbbruch.UseVisualStyleBackColor = true;
            btnAbbruch.Click += BtnAbbruch_Click;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.IndianRed;
            lblName.Location = new Point(12, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(400, 45);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLänge
            // 
            lblLänge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLänge.ForeColor = Color.IndianRed;
            lblLänge.Location = new Point(12, 211);
            lblLänge.Name = "lblLänge";
            lblLänge.Size = new Size(400, 40);
            lblLänge.TabIndex = 5;
            lblLänge.Text = "PW Länge";
            lblLänge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPasswortvergabe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 313);
            ControlBox = false;
            Controls.Add(lblName);
            Controls.Add(lblLänge);
            Controls.Add(btnAbbruch);
            Controls.Add(txtPW2);
            Controls.Add(txtPW1);
            Controls.Add(btnSpeichern);
            MaximumSize = new Size(450, 360);
            MinimumSize = new Size(450, 360);
            Name = "FrmPasswortvergabe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passwort vergeben";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSpeichern;
        private TextBox txtPW1;
        private TextBox txtPW2;
        private Button btnAbbruch;
        private Label lblLänge;
        private Label lblName;
    }
}