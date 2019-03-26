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
            this.addAppointmentUserControl1 = new HealthCare.UserControls.AddAppointmentUserControl();
            this.visitTabPage = new System.Windows.Forms.TabPage();
            this.visitUserControl1 = new HealthCare.UserControls.VisitUserControl();
            this.logoutLinkDashboard = new System.Windows.Forms.LinkLabel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.register_DeletePatientUserControl1 = new HealthCare.UserControls.Register_DeletePatientUserControl();
            this.nurseTabControl.SuspendLayout();
            this.patientTabPage.SuspendLayout();
            this.appointmentTabPage.SuspendLayout();
            this.visitTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseTabControl
            // 
            this.nurseTabControl.Controls.Add(this.patientTabPage);
            this.nurseTabControl.Controls.Add(this.appointmentTabPage);
            this.nurseTabControl.Controls.Add(this.visitTabPage);
            this.nurseTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nurseTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseTabControl.Location = new System.Drawing.Point(0, 0);
            this.nurseTabControl.Name = "nurseTabControl";
            this.nurseTabControl.SelectedIndex = 0;
            this.nurseTabControl.Size = new System.Drawing.Size(1015, 728);
            this.nurseTabControl.TabIndex = 0;
            // 
            // patientTabPage
            // 
            this.patientTabPage.Controls.Add(this.register_DeletePatientUserControl1);
            this.patientTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientTabPage.Location = new System.Drawing.Point(4, 29);
            this.patientTabPage.Name = "patientTabPage";
            this.patientTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.patientTabPage.Size = new System.Drawing.Size(1007, 695);
            this.patientTabPage.TabIndex = 0;
            this.patientTabPage.Text = "Register/Delete Patient";
            this.patientTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentTabPage
            // 
            this.appointmentTabPage.Controls.Add(this.addAppointmentUserControl1);
            this.appointmentTabPage.Location = new System.Drawing.Point(4, 29);
            this.appointmentTabPage.Name = "appointmentTabPage";
            this.appointmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentTabPage.Size = new System.Drawing.Size(1007, 695);
            this.appointmentTabPage.TabIndex = 1;
            this.appointmentTabPage.Text = "Appointment Information";
            this.appointmentTabPage.UseVisualStyleBackColor = true;
            // 
            // addAppointmentUserControl1
            // 
            this.addAppointmentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAppointmentUserControl1.Location = new System.Drawing.Point(3, 3);
            this.addAppointmentUserControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addAppointmentUserControl1.Name = "addAppointmentUserControl1";
            this.addAppointmentUserControl1.Size = new System.Drawing.Size(1001, 689);
            this.addAppointmentUserControl1.TabIndex = 0;
            // 
            // visitTabPage
            // 
            this.visitTabPage.Controls.Add(this.visitUserControl1);
            this.visitTabPage.Location = new System.Drawing.Point(4, 29);
            this.visitTabPage.Name = "visitTabPage";
            this.visitTabPage.Size = new System.Drawing.Size(1007, 695);
            this.visitTabPage.TabIndex = 2;
            this.visitTabPage.Text = "Visit Information";
            this.visitTabPage.UseVisualStyleBackColor = true;
            // 
            // visitUserControl1
            // 
            this.visitUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitUserControl1.Location = new System.Drawing.Point(0, 0);
            this.visitUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.visitUserControl1.Name = "visitUserControl1";
            this.visitUserControl1.Size = new System.Drawing.Size(1007, 695);
            this.visitUserControl1.TabIndex = 0;
            // 
            // logoutLinkDashboard
            // 
            this.logoutLinkDashboard.AutoSize = true;
            this.logoutLinkDashboard.Location = new System.Drawing.Point(933, 749);
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
            this.nameLabel.Location = new System.Drawing.Point(933, 731);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "label1";
            // 
            // register_DeletePatientUserControl1
            // 
            this.register_DeletePatientUserControl1.Location = new System.Drawing.Point(114, 58);
            this.register_DeletePatientUserControl1.Name = "register_DeletePatientUserControl1";
            this.register_DeletePatientUserControl1.Size = new System.Drawing.Size(443, 213);
            this.register_DeletePatientUserControl1.TabIndex = 0;
            // 
            // NurseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 845);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoutLinkDashboard);
            this.Controls.Add(this.nurseTabControl);
            this.Name = "NurseDashboard";
            this.Text = "Nurse Dashboard";
            this.nurseTabControl.ResumeLayout(false);
            this.patientTabPage.ResumeLayout(false);
            this.appointmentTabPage.ResumeLayout(false);
            this.visitTabPage.ResumeLayout(false);
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
        private UserControls.VisitUserControl visitUserControl1;
        private UserControls.AddAppointmentUserControl addAppointmentUserControl1;
        private UserControls.Register_DeletePatientUserControl register_DeletePatientUserControl1;
    }
}