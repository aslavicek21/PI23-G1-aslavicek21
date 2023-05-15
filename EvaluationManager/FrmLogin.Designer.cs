namespace EvaluationManager {
    partial class FrmLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.KorisnickoIme = new System.Windows.Forms.Label();
            this.Lozinka = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.AutoSize = true;
            this.KorisnickoIme.Location = new System.Drawing.Point(28, 55);
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Size = new System.Drawing.Size(79, 13);
            this.KorisnickoIme.TabIndex = 0;
            this.KorisnickoIme.Text = "Korisničko Ime:";
            // 
            // Lozinka
            // 
            this.Lozinka.AutoSize = true;
            this.Lozinka.Location = new System.Drawing.Point(63, 90);
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.Size = new System.Drawing.Size(47, 13);
            this.Lozinka.TabIndex = 1;
            this.Lozinka.Text = "Lozinka:";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(206, 134);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 2;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(113, 52);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 170);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.Lozinka);
            this.Controls.Add(this.KorisnickoIme);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KorisnickoIme;
        private System.Windows.Forms.Label Lozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

