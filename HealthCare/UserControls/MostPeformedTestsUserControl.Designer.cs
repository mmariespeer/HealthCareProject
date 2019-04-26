using HealthCare.Report;

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
            this.mostperformed = new HealthCare.Report.mostperformed();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spMostPerformedTestsTableAdapter = new HealthCare.Report.mostperformedTableAdapters.spMostPerformedTestsTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.spMostPerformedTestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostperformed)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            // instructionsLabel
            // 
            this.instructionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(8, 43);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(1944, 32);
            this.instructionsLabel.TabIndex = 15;
            this.instructionsLabel.Text = "Enter dates in which you would like to search results for.";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // endDate
            // 
            this.endDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(1025, 33);
            this.endDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(292, 38);
            this.endDate.TabIndex = 14;
            // 
            // startDate
            // 
            this.startDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(448, 33);
            this.startDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(300, 38);
            this.startDate.TabIndex = 13;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateReportButton.Location = new System.Drawing.Point(1466, 7);
            this.generateReportButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(384, 91);
            this.generateReportButton.TabIndex = 12;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click_1);
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(924, 36);
            this.toLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(70, 32);
            this.toLabel.TabIndex = 11;
            this.toLabel.Text = "To : ";
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(330, 36);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(102, 32);
            this.fromLabel.TabIndex = 10;
            this.fromLabel.Text = "From : ";
            this.fromLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "MostPerformed";
            reportDataSource1.Value = this.spMostPerformedTestsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthCare.Report.MostPerformedTests.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 541);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1960, 790);
            this.reportViewer1.TabIndex = 16;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spMostPerformedTestsTableAdapter
            // 
            this.spMostPerformedTestsTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 355F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 571F));
            this.tableLayoutPanel1.Controls.Add(this.fromLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.generateReportButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.endDate, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 126);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1944, 105);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.instructionsLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1960, 238);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // MostPeformedTestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MostPeformedTestsUserControl";
            this.Size = new System.Drawing.Size(1960, 1331);
            ((System.ComponentModel.ISupportInitialize)(this.spMostPerformedTestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostperformed)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

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
        private Report.mostperformedTableAdapters.spMostPerformedTestsTableAdapter spMostPerformedTestsTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
