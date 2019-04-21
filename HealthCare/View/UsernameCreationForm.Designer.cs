namespace HealthCare.View
{
    partial class UsernameCreationForm
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
            this.newLoginUserControl = new HealthCare.UserControls.NewLoginUserControl();
            this.SuspendLayout();
            // 
            // newLoginUserControl
            // 
            this.newLoginUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newLoginUserControl.Location = new System.Drawing.Point(0, 0);
            this.newLoginUserControl.Name = "newLoginUserControl";
            this.newLoginUserControl.Size = new System.Drawing.Size(639, 418);
            this.newLoginUserControl.TabIndex = 0;
            // 
            // UsernameCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 418);
            this.Controls.Add(this.newLoginUserControl);
            this.Name = "UsernameCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Username and Password";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.NewLoginUserControl newLoginUserControl;
    }
}