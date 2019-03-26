namespace HealthCare.View
{
    partial class NurseDashboard
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
            this.nurseTabControl = new System.Windows.Forms.TabControl();
            this.patientTabPage = new System.Windows.Forms.TabPage();
            this.appointmentTabPage = new System.Windows.Forms.TabPage();
            this.visitTabPage = new System.Windows.Forms.TabPage();
            this.logoutLinkDashboard = new System.Windows.Forms.LinkLabel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patientSearchUserControl1 = new HealthCare.UserControls.PatientSearchUserControl();
            this.nurseTabControl.SuspendLayout();
            this.patientTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseTabControl
            // 
            this.nurseTabControl.Controls.Add(this.patientTabPage);
            this.nurseTabControl.Controls.Add(this.appointmentTabPage);
            this.nurseTabControl.Controls.Add(this.visitTabPage);
            this.nurseTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseTabControl.Location = new System.Drawing.Point(-3, 0);
            this.nurseTabControl.Name = "nurseTabControl";
            this.nurseTabControl.SelectedIndex = 0;
            this.nurseTabControl.Size = new System.Drawing.Size(849, 475);
            this.nurseTabControl.TabIndex = 0;
            // 
            // patientTabPage
            // 
            this.patientTabPage.Controls.Add(this.patientSearchUserControl1);
            this.patientTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientTabPage.Location = new System.Drawing.Point(4, 29);
            this.patientTabPage.Name = "patientTabPage";
            this.patientTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.patientTabPage.Size = new System.Drawing.Size(841, 442);
            this.patientTabPage.TabIndex = 0;
            this.patientTabPage.Text = "Register/Delete Patient";
            this.patientTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentTabPage
            // 
            this.appointmentTabPage.Location = new System.Drawing.Point(4, 29);
            this.appointmentTabPage.Name = "appointmentTabPage";
            this.appointmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentTabPage.Size = new System.Drawing.Size(841, 442);
            this.appointmentTabPage.TabIndex = 1;
            this.appointmentTabPage.Text = "Appointment Information";
            this.appointmentTabPage.UseVisualStyleBackColor = true;
            // 
            // visitTabPage
            // 
            this.visitTabPage.Location = new System.Drawing.Point(4, 29);
            this.visitTabPage.Name = "visitTabPage";
            this.visitTabPage.Size = new System.Drawing.Size(841, 442);
            this.visitTabPage.TabIndex = 2;
            this.visitTabPage.Text = "Visit Information";
            this.visitTabPage.UseVisualStyleBackColor = true;
            // 
            // logoutLinkDashboard
            // 
            this.logoutLinkDashboard.AutoSize = true;
            this.logoutLinkDashboard.Location = new System.Drawing.Point(775, 491);
            this.logoutLinkDashboard.Name = "logoutLinkDashboard";
            this.logoutLinkDashboard.Size = new System.Drawing.Size(36, 13);
            this.logoutLinkDashboard.TabIndex = 3;
            this.logoutLinkDashboard.TabStop = true;
            this.logoutLinkDashboard.Text = "logout";
            this.logoutLinkDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkDashboard_LinkClicked);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(678, 491);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "label1";
            // 
            // patientSearchUserControl1
            // 
            this.patientSearchUserControl1.Location = new System.Drawing.Point(145, 52);
            this.patientSearchUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientSearchUserControl1.Name = "patientSearchUserControl1";
            this.patientSearchUserControl1.Size = new System.Drawing.Size(525, 299);
            this.patientSearchUserControl1.TabIndex = 0;
            // 
            // NurseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 513);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoutLinkDashboard);
            this.Controls.Add(this.nurseTabControl);
            this.Name = "NurseDashboard";
            this.Text = "Nurse Dashboard";
            this.nurseTabControl.ResumeLayout(false);
            this.patientTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl nurseTabControl;
        private System.Windows.Forms.TabPage patientTabPage;
        private System.Windows.Forms.TabPage appointmentTabPage;
        private System.Windows.Forms.TabPage visitTabPage;
        private System.Windows.Forms.LinkLabel logoutLinkDashboard;
        private System.Windows.Forms.Label nameLabel;
        private UserControls.PatientSearchUserControl patientSearchUserControl1;
    }
}