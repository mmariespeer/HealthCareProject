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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoutLinkDashboard = new System.Windows.Forms.LinkLabel();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.viewNurseTabPage = new System.Windows.Forms.TabPage();
            this.viewNurseUserControl2 = new HealthCare.UserControls.ViewNurseUserControl();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.mostperformed = new HealthCare.mostperformed();
            this.spMostPerformedTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spMostPerformedTestsTableAdapter = new HealthCare.mostperformedTableAdapters.spMostPerformedTestsTableAdapter();
            this.adminTabControl.SuspendLayout();
            this.viewNurseTabPage.SuspendLayout();
            this.reportTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostperformed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostPerformedTestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(961, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "label1";
            // 
            // logoutLinkDashboard
            // 
            this.logoutLinkDashboard.AutoSize = true;
            this.logoutLinkDashboard.Location = new System.Drawing.Point(1061, 24);
            this.logoutLinkDashboard.Name = "logoutLinkDashboard";
            this.logoutLinkDashboard.Size = new System.Drawing.Size(36, 13);
            this.logoutLinkDashboard.TabIndex = 5;
            this.logoutLinkDashboard.TabStop = true;
            this.logoutLinkDashboard.Text = "logout";
            this.logoutLinkDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkDashboard_LinkClicked);
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.viewNurseTabPage);
            this.adminTabControl.Controls.Add(this.reportTabPage);
            this.adminTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.Location = new System.Drawing.Point(12, 50);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(1092, 722);
            this.adminTabControl.TabIndex = 7;
            // 
            // viewNurseTabPage
            // 
            this.viewNurseTabPage.Controls.Add(this.viewNurseUserControl2);
            this.viewNurseTabPage.Location = new System.Drawing.Point(4, 29);
            this.viewNurseTabPage.Name = "viewNurseTabPage";
            this.viewNurseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewNurseTabPage.Size = new System.Drawing.Size(1084, 689);
            this.viewNurseTabPage.TabIndex = 1;
            this.viewNurseTabPage.Text = "Add/View Nurse";
            this.viewNurseTabPage.UseVisualStyleBackColor = true;
            // 
            // viewNurseUserControl2
            // 
            this.viewNurseUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewNurseUserControl2.Location = new System.Drawing.Point(3, 3);
            this.viewNurseUserControl2.Margin = new System.Windows.Forms.Padding(4);
            this.viewNurseUserControl2.Name = "viewNurseUserControl2";
            this.viewNurseUserControl2.Size = new System.Drawing.Size(1078, 683);
            this.viewNurseUserControl2.TabIndex = 0;
            // 
            // reportTabPage
            // 
            this.reportTabPage.Controls.Add(this.instructionsLabel);
            this.reportTabPage.Controls.Add(this.reportViewer1);
            this.reportTabPage.Controls.Add(this.endDate);
            this.reportTabPage.Controls.Add(this.startDate);
            this.reportTabPage.Controls.Add(this.generateReportButton);
            this.reportTabPage.Controls.Add(this.toLabel);
            this.reportTabPage.Controls.Add(this.fromLabel);
            this.reportTabPage.Location = new System.Drawing.Point(4, 29);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportTabPage.Size = new System.Drawing.Size(1084, 689);
            this.reportTabPage.TabIndex = 0;
            this.reportTabPage.Text = "Generate Test Report";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(301, 16);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(401, 20);
            this.instructionsLabel.TabIndex = 9;
            this.instructionsLabel.Text = "Enter dates in which you would like to search results for.";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MostPerformed";
            reportDataSource1.Value = this.spMostPerformedTestsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthCare.MostPerformedTests.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1072, 552);
            this.reportViewer1.TabIndex = 8;
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(491, 58);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(112, 26);
            this.endDate.TabIndex = 7;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(305, 58);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(115, 26);
            this.startDate.TabIndex = 6;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(619, 54);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(167, 38);
            this.generateReportButton.TabIndex = 5;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(446, 63);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(39, 20);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To : ";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(241, 63);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(58, 20);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From : ";
            // 
            // mostperformed
            // 
            this.mostperformed.DataSetName = "mostperformed";
            this.mostperformed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spMostPerformedTestsBindingSource
            // 
            this.spMostPerformedTestsBindingSource.DataMember = "spMostPerformedTests";
            this.spMostPerformedTestsBindingSource.DataSource = this.mostperformed;
            // 
            // spMostPerformedTestsTableAdapter
            // 
            this.spMostPerformedTestsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 731);
            this.Controls.Add(this.adminTabControl);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoutLinkDashboard);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.adminTabControl.ResumeLayout(false);
            this.viewNurseTabPage.ResumeLayout(false);
            this.reportTabPage.ResumeLayout(false);
            this.reportTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostperformed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostPerformedTestsBindingSource)).EndInit();
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
        private UserControls.ViewNurseUserControl viewNurseUserControl2;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.BindingSource spMostPerformedTestsBindingSource;
        private mostperformed mostperformed;
        private mostperformedTableAdapters.spMostPerformedTestsTableAdapter spMostPerformedTestsTableAdapter;
    }
}