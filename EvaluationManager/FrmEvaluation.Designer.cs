namespace EvaluationManager {
    partial class FrmEvaluation {
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
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAktivnost = new System.Windows.Forms.Label();
            this.lblUvjetPotpis = new System.Windows.Forms.Label();
            this.lblUvjetOcjena = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblDatumEvaluacije = new System.Windows.Forms.Label();
            this.lblBodovi = new System.Windows.Forms.Label();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(12, 32);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(245, 21);
            this.cboActivities.TabIndex = 0;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(277, 33);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(100, 20);
            this.txtMinForSignature.TabIndex = 1;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(383, 33);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(100, 20);
            this.txtMinForGrade.TabIndex = 2;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(359, 325);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(120, 20);
            this.numPoints.TabIndex = 4;
            this.numPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(135, 325);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtTeacher.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAktivnost
            // 
            this.lblAktivnost.AutoSize = true;
            this.lblAktivnost.Location = new System.Drawing.Point(9, 17);
            this.lblAktivnost.Name = "lblAktivnost";
            this.lblAktivnost.Size = new System.Drawing.Size(51, 13);
            this.lblAktivnost.TabIndex = 9;
            this.lblAktivnost.Text = "Aktivnost";
            // 
            // lblUvjetPotpis
            // 
            this.lblUvjetPotpis.AutoSize = true;
            this.lblUvjetPotpis.Location = new System.Drawing.Point(274, 17);
            this.lblUvjetPotpis.Name = "lblUvjetPotpis";
            this.lblUvjetPotpis.Size = new System.Drawing.Size(79, 13);
            this.lblUvjetPotpis.TabIndex = 10;
            this.lblUvjetPotpis.Text = "Uvijet za potpis";
            // 
            // lblUvjetOcjena
            // 
            this.lblUvjetOcjena.AutoSize = true;
            this.lblUvjetOcjena.Location = new System.Drawing.Point(380, 17);
            this.lblUvjetOcjena.Name = "lblUvjetOcjena";
            this.lblUvjetOcjena.Size = new System.Drawing.Size(81, 13);
            this.lblUvjetOcjena.TabIndex = 11;
            this.lblUvjetOcjena.Text = "Uvjet za ocjenu";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(132, 307);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(60, 13);
            this.lblTeacher.TabIndex = 12;
            this.lblTeacher.Text = "Ocjenjivač:";
            // 
            // lblDatumEvaluacije
            // 
            this.lblDatumEvaluacije.AutoSize = true;
            this.lblDatumEvaluacije.Location = new System.Drawing.Point(238, 307);
            this.lblDatumEvaluacije.Name = "lblDatumEvaluacije";
            this.lblDatumEvaluacije.Size = new System.Drawing.Size(92, 13);
            this.lblDatumEvaluacije.TabIndex = 13;
            this.lblDatumEvaluacije.Text = "Datum evaluacije:";
            // 
            // lblBodovi
            // 
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Location = new System.Drawing.Point(359, 307);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(43, 13);
            this.lblBodovi.TabIndex = 14;
            this.lblBodovi.Text = "Bodovi:";
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(241, 325);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(112, 20);
            this.txtEvaluationDate.TabIndex = 15;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(12, 69);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(471, 234);
            this.txtActivityDescription.TabIndex = 16;
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 389);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.lblDatumEvaluacije);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblUvjetOcjena);
            this.Controls.Add(this.lblUvjetPotpis);
            this.Controls.Add(this.lblAktivnost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.cboActivities);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            this.Load += new System.EventHandler(this.FrmEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAktivnost;
        private System.Windows.Forms.Label lblUvjetPotpis;
        private System.Windows.Forms.Label lblUvjetOcjena;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblDatumEvaluacije;
        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.TextBox txtActivityDescription;
    }
}