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
            this.logoutLinkDashboard = new System.Windows.Forms.LinkLabel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.appointmentTabPage = new System.Windows.Forms.TabPage();
            this.addAppointmentUserControl1 = new HealthCare.UserControls.AddAppointmentUserControl();
            this.patientTabPage = new System.Windows.Forms.TabPage();
            this.registerPatientUserControl2 = new HealthCare.UserControls.RegisterPatientUserControl();
            this.nurseTabControl = new System.Windows.Forms.TabControl();
            this.visitTabPage = new System.Windows.Forms.TabPage();
            this.visitUserControl1 = new HealthCare.UserControls.VisitUserControl();
            this.paitentSearchSimple2 = new HealthCare.UserControls.PaitentSearchSimple();
            this.appointmentTabPage.SuspendLayout();
            this.patientTabPage.SuspendLayout();
            this.nurseTabControl.SuspendLayout();
            this.visitTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutLinkDashboard
            // 
            this.logoutLinkDashboard.AutoSize = true;
            this.logoutLinkDashboard.Location = new System.Drawing.Point(681, 9);
            this.logoutLinkDashboard.Name = "logoutLinkDashboard";
            this.logoutLinkDashboard.Size = new System.Drawing.Size(36, 13);
            this.logoutLinkDashboard.TabIndex = 3;
            this.logoutLinkDashboard.TabStop = true;
            this.logoutLinkDashboard.Text = "logout";
            this.logoutLinkDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkDashboard_LinkClicked);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(581, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "label1";
            // 
            // appointmentTabPage
            // 
            this.appointmentTabPage.Controls.Add(this.addAppointmentUserControl1);
            this.appointmentTabPage.Location = new System.Drawing.Point(4, 29);
            this.appointmentTabPage.Name = "appointmentTabPage";
            this.appointmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentTabPage.Size = new System.Drawing.Size(688, 552);
            this.appointmentTabPage.TabIndex = 1;
            this.appointmentTabPage.Text = "Appointment Information";
            this.appointmentTabPage.UseVisualStyleBackColor = true;
            // 
            // addAppointmentUserControl1
            // 
            this.addAppointmentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAppointmentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentUserControl1.Location = new System.Drawing.Point(3, 3);
            this.addAppointmentUserControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addAppointmentUserControl1.Name = "addAppointmentUserControl1";
            this.addAppointmentUserControl1.Size = new System.Drawing.Size(682, 546);
            this.addAppointmentUserControl1.TabIndex = 0;
            // 
            // patientTabPage
            // 
            this.patientTabPage.Controls.Add(this.registerPatientUserControl2);
            this.patientTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientTabPage.Location = new System.Drawing.Point(4, 29);
            this.patientTabPage.Name = "patientTabPage";
            this.patientTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.patientTabPage.Size = new System.Drawing.Size(688, 552);
            this.patientTabPage.TabIndex = 0;
            this.patientTabPage.Text = "Register/Delete Patient";
            this.patientTabPage.UseVisualStyleBackColor = true;
            // 
            // registerPatientUserControl2
            // 
            this.registerPatientUserControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPatientUserControl2.Location = new System.Drawing.Point(52, 46);
            this.registerPatientUserControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerPatientUserControl2.Name = "registerPatientUserControl2";
            this.registerPatientUserControl2.Size = new System.Drawing.Size(588, 379);
            this.registerPatientUserControl2.TabIndex = 1;
            // 
            // nurseTabControl
            // 
            this.nurseTabControl.Controls.Add(this.patientTabPage);
            this.nurseTabControl.Controls.Add(this.appointmentTabPage);
            this.nurseTabControl.Controls.Add(this.visitTabPage);
            this.nurseTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseTabControl.Location = new System.Drawing.Point(28, 165);
            this.nurseTabControl.Name = "nurseTabControl";
            this.nurseTabControl.SelectedIndex = 0;
            this.nurseTabControl.Size = new System.Drawing.Size(696, 585);
            this.nurseTabControl.TabIndex = 0;
            // 
            // visitTabPage
            // 
            this.visitTabPage.Controls.Add(this.visitUserControl1);
            this.visitTabPage.Location = new System.Drawing.Point(4, 29);
            this.visitTabPage.Name = "visitTabPage";
            this.visitTabPage.Size = new System.Drawing.Size(688, 552);
            this.visitTabPage.TabIndex = 2;
            this.visitTabPage.Text = "Visit Information";
            this.visitTabPage.UseVisualStyleBackColor = true;
            // 
            // visitUserControl1
            // 
            this.visitUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitUserControl1.Location = new System.Drawing.Point(8, 4);
            this.visitUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.visitUserControl1.Name = "visitUserControl1";
            this.visitUserControl1.Size = new System.Drawing.Size(705, 682);
            this.visitUserControl1.TabIndex = 0;
            // 
            // paitentSearchSimple2
            // 
            this.paitentSearchSimple2.Location = new System.Drawing.Point(12, 25);
            this.paitentSearchSimple2.Name = "paitentSearchSimple2";
            this.paitentSearchSimple2.Size = new System.Drawing.Size(726, 146);
            this.paitentSearchSimple2.TabIndex = 5;
            // 
            // NurseDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(775, 749);
            this.Controls.Add(this.paitentSearchSimple2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoutLinkDashboard);
            this.Controls.Add(this.nurseTabControl);
            this.Name = "NurseDashboard";
            this.Text = "Nurse Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NurseDashboard_FormClosing);
            this.appointmentTabPage.ResumeLayout(false);
            this.patientTabPage.ResumeLayout(false);
            this.nurseTabControl.ResumeLayout(false);
            this.visitTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel logoutLinkDashboard;
        private System.Windows.Forms.Label nameLabel;
        private UserControls.PaitentSearchSimple paitentSearchSimple2;
       // private UserControls.RegisterPatientUserControl registerPatientUserControl1;
        private System.Windows.Forms.TabPage appointmentTabPage;
        private UserControls.AddAppointmentUserControl addAppointmentUserControl1;
        private System.Windows.Forms.TabPage patientTabPage;
        private System.Windows.Forms.TabControl nurseTabControl;
        private System.Windows.Forms.TabPage visitTabPage;
        private UserControls.VisitUserControl visitUserControl1;
        private UserControls.RegisterPatientUserControl registerPatientUserControl2;
    }
}