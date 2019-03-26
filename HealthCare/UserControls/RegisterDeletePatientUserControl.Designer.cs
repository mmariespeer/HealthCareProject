namespace HealthCare.UserControls
{
    partial class RegisterDeletePatientUserControl
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
            this.searchPatientUserControl1 = new HealthCare.UserControls.SearchPatientUserControl();
            this.SuspendLayout();
            // 
            // searchPatientUserControl1
            // 
            this.searchPatientUserControl1.Location = new System.Drawing.Point(17, 23);
            this.searchPatientUserControl1.Name = "searchPatientUserControl1";
            this.searchPatientUserControl1.Size = new System.Drawing.Size(577, 239);
            this.searchPatientUserControl1.TabIndex = 0;
            // 
            // RegisterDeletePatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPatientUserControl1);
            this.Name = "RegisterDeletePatientUserControl";
            this.Size = new System.Drawing.Size(622, 372);
            this.ResumeLayout(false);

        }

        #endregion

        private SearchPatientUserControl searchPatientUserControl1;
    }
}
