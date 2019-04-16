namespace HealthCare.View
{
    partial class LogTestResultForm
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
            this.logTestResultsUserControl1 = new HealthCare.UserControls.LogTestResultsUserControl();
            this.SuspendLayout();
            // 
            // logTestResultsUserControl1
            // 
            this.logTestResultsUserControl1.Location = new System.Drawing.Point(12, 12);
            this.logTestResultsUserControl1.Name = "logTestResultsUserControl1";
            this.logTestResultsUserControl1.Size = new System.Drawing.Size(228, 192);
            this.logTestResultsUserControl1.TabIndex = 0;
            // 
            // LogTestResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 212);
            this.Controls.Add(this.logTestResultsUserControl1);
            this.Name = "LogTestResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogTestResultForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.LogTestResultsUserControl logTestResultsUserControl1;
    }
}