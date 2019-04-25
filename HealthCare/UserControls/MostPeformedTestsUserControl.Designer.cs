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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mostperformed = new HealthCare.mostperformed();
            this.spMostPerformedTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spMostPerformedTestsTableAdapter = new HealthCare.mostperformedTableAdapters.spMostPerformedTestsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostperformed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostPerformedTestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(531, 38);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(718, 32);
            this.instructionsLabel.TabIndex = 15;
            this.instructionsLabel.Text = "Enter dates in which you would like to search results for.";
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(955, 134);
            this.endDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(292, 38);
            this.endDate.TabIndex = 14;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(459, 134);
            this.startDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(300, 38);
            this.startDate.TabIndex = 13;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(1296, 114);
            this.generateReportButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(445, 91);
            this.generateReportButton.TabIndex = 12;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click_1);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(835, 145);
            this.toLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(70, 32);
            this.toLabel.TabIndex = 11;
            this.toLabel.Text = "To : ";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(288, 145);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(102, 32);
            this.fromLabel.TabIndex = 10;
            this.fromLabel.Text = "From : ";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MostPerformed";
            reportDataSource1.Value = this.spMostPerformedTestsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthCare.MostPerformedTests.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 229);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1957, 1099);
            this.reportViewer1.TabIndex = 16;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
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
            // MostPeformedTestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MostPeformedTestsUserControl";
            this.Size = new System.Drawing.Size(1960, 1331);
            ((System.ComponentModel.ISupportInitialize)(this.mostperformed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostPerformedTestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spMostPerformedTestsBindingSource;
        private mostperformed mostperformed;
        private mostperformedTableAdapters.spMostPerformedTestsTableAdapter spMostPerformedTestsTableAdapter;
    }
}
