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
            this.cs6232g2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._cs6232_g2DataSet = new HealthCare._cs6232_g2DataSet();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoutLinkDashboard = new System.Windows.Forms.LinkLabel();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.viewNurseTabPage = new System.Windows.Forms.TabPage();
            this.viewNurseUserControl2 = new HealthCare.UserControls.ViewNurseUserControl();
            this.MostPerformedTestDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cs6232g2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostPerformedTestDuringDatesTableAdapter1 = new HealthCare._cs6232_g2DataSetTableAdapters.MostPerformedTestDuringDatesTableAdapter();
            this.mostPerformedTestDuringDatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cs6232g2DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g2DataSet)).BeginInit();
            this.adminTabControl.SuspendLayout();
            this.reportTabPage.SuspendLayout();
            this.viewNurseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostPerformedTestDuringDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs6232g2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostPerformedTestDuringDatesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cs6232g2DataSetBindingSource1
            // 
            this.cs6232g2DataSetBindingSource1.DataSource = this._cs6232_g2DataSet;
            this.cs6232g2DataSetBindingSource1.Position = 0;
            // 
            // _cs6232_g2DataSet
            // 
            this._cs6232_g2DataSet.DataSetName = "_cs6232_g2DataSet";
            this._cs6232_g2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.adminTabControl.Controls.Add(this.viewNurseTabPage);
            this.adminTabControl.Controls.Add(this.reportTabPage);
            this.adminTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.Location = new System.Drawing.Point(12, 50);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(1092, 722);
            this.adminTabControl.TabIndex = 7;
            // 
            // reportTabPage
            // 
            this.reportTabPage.Controls.Add(this.label1);
            this.reportTabPage.Controls.Add(this.reportViewer1);
            this.reportTabPage.Controls.Add(this.generateReportButton);
            this.reportTabPage.Controls.Add(this.toLabel);
            this.reportTabPage.Controls.Add(this.fromLabel);
            this.reportTabPage.Controls.Add(this.toTextBox);
            this.reportTabPage.Controls.Add(this.fromTextBox);
            this.reportTabPage.Location = new System.Drawing.Point(4, 29);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportTabPage.Size = new System.Drawing.Size(1084, 689);
            this.reportTabPage.TabIndex = 0;
            this.reportTabPage.Text = "Generate Test Report";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MostPerformedTests";
            reportDataSource1.Value = this.cs6232g2DataSetBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthCare.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 104);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1043, 566);
            this.reportViewer1.TabIndex = 6;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(534, 15);
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
            this.toLabel.Location = new System.Drawing.Point(355, 21);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(39, 20);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To : ";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(125, 27);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(58, 20);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From : ";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(400, 21);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 26);
            this.toTextBox.TabIndex = 2;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(189, 21);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 26);
            this.fromTextBox.TabIndex = 1;
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
            // MostPerformedTestDuringDatesBindingSource
            // 
            this.MostPerformedTestDuringDatesBindingSource.DataMember = "MostPerformedTestDuringDates";
            this.MostPerformedTestDuringDatesBindingSource.DataSource = this._cs6232_g2DataSet;
            // 
            // cs6232g2DataSetBindingSource
            // 
            this.cs6232g2DataSetBindingSource.DataSource = this._cs6232_g2DataSet;
            this.cs6232g2DataSetBindingSource.Position = 0;
            // 
            // mostPerformedTestDuringDatesTableAdapter1
            // 
            this.mostPerformedTestDuringDatesTableAdapter1.ClearBeforeFill = true;
            // 
            // mostPerformedTestDuringDatesBindingSource1
            // 
            this.mostPerformedTestDuringDatesBindingSource1.DataMember = "MostPerformedTestDuringDates";
            this.mostPerformedTestDuringDatesBindingSource1.DataSource = this.cs6232g2DataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Coming soon (final iteration) ...";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 761);
            this.Controls.Add(this.adminTabControl);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoutLinkDashboard);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cs6232g2DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g2DataSet)).EndInit();
            this.adminTabControl.ResumeLayout(false);
            this.reportTabPage.ResumeLayout(false);
            this.reportTabPage.PerformLayout();
            this.viewNurseTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MostPerformedTestDuringDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs6232g2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostPerformedTestDuringDatesBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource cs6232g2DataSetBindingSource;
        private _cs6232_g2DataSet _cs6232_g2DataSet;
        private System.Windows.Forms.BindingSource MostPerformedTestDuringDatesBindingSource;
        private UserControls.ViewNurseUserControl viewNurseUserControl2;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private _cs6232_g2DataSetTableAdapters.MostPerformedTestDuringDatesTableAdapter mostPerformedTestDuringDatesTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mostPerformedTestDuringDatesBindingSource1;
        private System.Windows.Forms.BindingSource cs6232g2DataSetBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}