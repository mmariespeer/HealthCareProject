namespace HealthCare.View
{
    partial class AdminDashboard
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoutLinkDashboard = new System.Windows.Forms.LinkLabel();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.viewNurseTabPage = new System.Windows.Forms.TabPage();
            this.viewNurseUserControl1 = new HealthCare.UserControls.ViewNurseUserControl();
            this.adminTabControl.SuspendLayout();
            this.viewNurseTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(648, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "label1";
            // 
            // logoutLinkDashboard
            // 
            this.logoutLinkDashboard.AutoSize = true;
            this.logoutLinkDashboard.Location = new System.Drawing.Point(748, 24);
            this.logoutLinkDashboard.Name = "logoutLinkDashboard";
            this.logoutLinkDashboard.Size = new System.Drawing.Size(36, 13);
            this.logoutLinkDashboard.TabIndex = 5;
            this.logoutLinkDashboard.TabStop = true;
            this.logoutLinkDashboard.Text = "logout";
            this.logoutLinkDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkDashboard_LinkClicked);
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.reportTabPage);
            this.adminTabControl.Controls.Add(this.viewNurseTabPage);
            this.adminTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.Location = new System.Drawing.Point(12, 50);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(742, 468);
            this.adminTabControl.TabIndex = 7;
            // 
            // reportTabPage
            // 
            this.reportTabPage.Location = new System.Drawing.Point(4, 29);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportTabPage.Size = new System.Drawing.Size(734, 435);
            this.reportTabPage.TabIndex = 0;
            this.reportTabPage.Text = "Generate Test Report";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // viewNurseTabPage
            // 
            this.viewNurseTabPage.Controls.Add(this.viewNurseUserControl1);
            this.viewNurseTabPage.Location = new System.Drawing.Point(4, 29);
            this.viewNurseTabPage.Name = "viewNurseTabPage";
            this.viewNurseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewNurseTabPage.Size = new System.Drawing.Size(734, 435);
            this.viewNurseTabPage.TabIndex = 1;
            this.viewNurseTabPage.Text = "Add/View Nurse";
            this.viewNurseTabPage.UseVisualStyleBackColor = true;
            // 
            // viewNurseUserControl1
            // 
            this.viewNurseUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewNurseUserControl1.Location = new System.Drawing.Point(8, 0);
            this.viewNurseUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewNurseUserControl1.Name = "viewNurseUserControl1";
            this.viewNurseUserControl1.Size = new System.Drawing.Size(719, 411);
            this.viewNurseUserControl1.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.adminTabControl);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoutLinkDashboard);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.adminTabControl.ResumeLayout(false);
            this.viewNurseTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkDashboard;
        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage reportTabPage;
        private System.Windows.Forms.TabPage viewNurseTabPage;
        private UserControls.ViewNurseUserControl viewNurseUserControl1;
    }
}