namespace HealthCare.View
{
    partial class AddTestForm
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
            this.addTestUserControl1 = new HealthCare.UserControls.AddTestUserControl();
            this.SuspendLayout();
            // 
            // addTestUserControl1
            // 
            this.addTestUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTestUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addTestUserControl1.Name = "addTestUserControl1";
            this.addTestUserControl1.Size = new System.Drawing.Size(597, 450);
            this.addTestUserControl1.TabIndex = 0;
            // 
            // AddTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.addTestUserControl1);
            this.Name = "AddTestForm";
            this.Text = "AddTestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.AddTestUserControl addTestUserControl1;
    }
}