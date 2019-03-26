namespace HealthCare.UserControls
{
    partial class Register_DeletePatientUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientSearchUserControl1 = new HealthCare.UserControls.PatientSearchUserControl();
            this.SuspendLayout();
            // 
            // patientSearchUserControl1
            // 
            this.patientSearchUserControl1.Location = new System.Drawing.Point(163, 50);
            this.patientSearchUserControl1.Name = "patientSearchUserControl1";
            this.patientSearchUserControl1.Size = new System.Drawing.Size(349, 299);
            this.patientSearchUserControl1.TabIndex = 0;
            // 
            // Register_DeletePatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientSearchUserControl1);
            this.Name = "Register_DeletePatientUserControl";
            this.Size = new System.Drawing.Size(729, 441);
            this.ResumeLayout(false);

        }

        #endregion

        private PatientSearchUserControl patientSearchUserControl1;
    }
}
