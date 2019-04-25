namespace HealthCare.UserControls
{
    partial class MostPeformedTestsUserControl
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spMostPerformedTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostperformed = new HealthCare.mostperformed();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spMostPerformedTestsTableAdapter = new HealthCare.mostperformedTableAdapters.spMostPerformedTestsTableAdapter();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spMostPerformedTestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostperformed)).BeginInit();
            this.SuspendLayout();
            // 
            // spMostPerformedTestsBindingSource
            // 
            this.spMostPerformedTestsBindingSource.DataMember = "spMostPerformedTests";
            this.spMostPerformedTestsBindingSource.DataSource = this.mostperformed;
            // 
            // mostperformed
            // 
            this.mostperformed.DataSetName = "mostperformed";
            this.mostperformed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MostPerformed";
            reportDataSource1.Value = this.spMostPerformedTestsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthCare.MostPerformedTests.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, 108);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(738, 438);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spMostPerformedTestsTableAdapter
            // 
            this.spMostPerformedTestsTableAdapter.ClearBeforeFill = true;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(199, 16);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(271, 13);
            this.instructionsLabel.TabIndex = 15;
            this.instructionsLabel.Text = "Enter dates in which you would like to search results for.";
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(358, 56);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(112, 20);
            this.endDate.TabIndex = 14;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(172, 56);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(115, 20);
            this.startDate.TabIndex = 13;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(486, 48);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(167, 38);
            this.generateReportButton.TabIndex = 12;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click_1);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(313, 61);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(29, 13);
            this.toLabel.TabIndex = 11;
            this.toLabel.Text = "To : ";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(108, 61);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(39, 13);
            this.fromLabel.TabIndex = 10;
            this.fromLabel.Text = "From : ";
            // 
            // MostPeformedTestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostPeformedTestsUserControl";
            this.Size = new System.Drawing.Size(735, 558);
            ((System.ComponentModel.ISupportInitialize)(this.spMostPerformedTestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostperformed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spMostPerformedTestsBindingSource;
        private mostperformed mostperformed;
        private mostperformedTableAdapters.spMostPerformedTestsTableAdapter spMostPerformedTestsTableAdapter;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
    }
}
