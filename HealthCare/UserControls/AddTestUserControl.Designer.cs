namespace HealthCare.UserControls
{
    partial class AddTestUserControl
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.removeTestButton = new System.Windows.Forms.Button();
            this.availableTestsLabel = new System.Windows.Forms.Label();
            this.orderedTestsLabel = new System.Windows.Forms.Label();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(52, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(196, 266);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(315, 57);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(196, 266);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(52, 330);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(196, 23);
            this.addToOrderButton.TabIndex = 2;
            this.addToOrderButton.Text = "Add Selected To Order >>";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            // 
            // removeTestButton
            // 
            this.removeTestButton.Location = new System.Drawing.Point(315, 330);
            this.removeTestButton.Name = "removeTestButton";
            this.removeTestButton.Size = new System.Drawing.Size(196, 23);
            this.removeTestButton.TabIndex = 3;
            this.removeTestButton.Text = "<< Remove Selected";
            this.removeTestButton.UseVisualStyleBackColor = true;
            // 
            // availableTestsLabel
            // 
            this.availableTestsLabel.AutoSize = true;
            this.availableTestsLabel.Location = new System.Drawing.Point(49, 41);
            this.availableTestsLabel.Name = "availableTestsLabel";
            this.availableTestsLabel.Size = new System.Drawing.Size(82, 13);
            this.availableTestsLabel.TabIndex = 4;
            this.availableTestsLabel.Text = "Available Tests:";
            // 
            // orderedTestsLabel
            // 
            this.orderedTestsLabel.AutoSize = true;
            this.orderedTestsLabel.Location = new System.Drawing.Point(312, 41);
            this.orderedTestsLabel.Name = "orderedTestsLabel";
            this.orderedTestsLabel.Size = new System.Drawing.Size(77, 13);
            this.orderedTestsLabel.TabIndex = 5;
            this.orderedTestsLabel.Text = "Ordered Tests:";
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.Location = new System.Drawing.Point(415, 379);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(96, 23);
            this.submitOrderButton.TabIndex = 6;
            this.submitOrderButton.Text = "Submit Order";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            // 
            // AddTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitOrderButton);
            this.Controls.Add(this.orderedTestsLabel);
            this.Controls.Add(this.availableTestsLabel);
            this.Controls.Add(this.removeTestButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "AddTestUserControl";
            this.Size = new System.Drawing.Size(580, 425);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button removeTestButton;
        private System.Windows.Forms.Label availableTestsLabel;
        private System.Windows.Forms.Label orderedTestsLabel;
        private System.Windows.Forms.Button submitOrderButton;
    }
}
