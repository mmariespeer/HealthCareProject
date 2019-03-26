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
            this.patientSearchUserControl2 = new HealthCare.UserControls.PatientSearchUserControl();
            this.SuspendLayout();
            // 
            // patientSearchUserControl2
            // 
            this.patientSearchUserControl2.Location = new System.Drawing.Point(13, 19);
            this.patientSearchUserControl2.Name = "patientSearchUserControl2";
            this.patientSearchUserControl2.Size = new System.Drawing.Size(338, 145);
            this.patientSearchUserControl2.TabIndex = 0;
            // 
            // Register_DeletePatientUserControl
            // 
            this.Controls.Add(this.patientSearchUserControl2);
            this.Name = "Register_DeletePatientUserControl";
            this.Size = new System.Drawing.Size(446, 259);
            this.ResumeLayout(false);

        }

        #endregion

        private PatientSearchUserControl patientSearchUserControl1;
        private PatientSearchUserControl patientSearchUserControl2;
    }
}
