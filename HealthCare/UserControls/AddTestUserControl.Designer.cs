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
            this.availableListView = new System.Windows.Forms.ListView();
            this.codeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderedListView = new System.Windows.Forms.ListView();
            this.codeColumnHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.availableTestsLabel = new System.Windows.Forms.Label();
            this.orderedTestsLabel = new System.Windows.Forms.Label();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // availableListView
            // 
            this.availableListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeColumnHeader,
            this.nameColumnHeader});
            this.availableListView.FullRowSelect = true;
            this.availableListView.HideSelection = false;
            this.availableListView.Location = new System.Drawing.Point(21, 33);
            this.availableListView.Name = "availableListView";
            this.availableListView.Size = new System.Drawing.Size(231, 266);
            this.availableListView.TabIndex = 0;
            this.availableListView.UseCompatibleStateImageBehavior = false;
            this.availableListView.View = System.Windows.Forms.View.Details;
            // 
            // codeColumnHeader
            // 
            this.codeColumnHeader.Text = "Code";
            this.codeColumnHeader.Width = 48;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 135;
            // 
            // orderedListView
            // 
            this.orderedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeColumnHead,
            this.nameColumnHead});
            this.orderedListView.Location = new System.Drawing.Point(284, 33);
            this.orderedListView.Name = "orderedListView";
            this.orderedListView.Size = new System.Drawing.Size(231, 266);
            this.orderedListView.TabIndex = 1;
            this.orderedListView.UseCompatibleStateImageBehavior = false;
            this.orderedListView.View = System.Windows.Forms.View.Details;
            // 
            // codeColumnHead
            // 
            this.codeColumnHead.Text = "Code";
            this.codeColumnHead.Width = 48;
            // 
            // nameColumnHead
            // 
            this.nameColumnHead.Text = "Name";
            this.nameColumnHead.Width = 137;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(21, 306);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(231, 23);
            this.addToOrderButton.TabIndex = 2;
            this.addToOrderButton.Text = "Add Selected To Order >>";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // availableTestsLabel
            // 
            this.availableTestsLabel.AutoSize = true;
            this.availableTestsLabel.Location = new System.Drawing.Point(18, 17);
            this.availableTestsLabel.Name = "availableTestsLabel";
            this.availableTestsLabel.Size = new System.Drawing.Size(82, 13);
            this.availableTestsLabel.TabIndex = 4;
            this.availableTestsLabel.Text = "Available Tests:";
            // 
            // orderedTestsLabel
            // 
            this.orderedTestsLabel.AutoSize = true;
            this.orderedTestsLabel.Location = new System.Drawing.Point(281, 17);
            this.orderedTestsLabel.Name = "orderedTestsLabel";
            this.orderedTestsLabel.Size = new System.Drawing.Size(77, 13);
            this.orderedTestsLabel.TabIndex = 5;
            this.orderedTestsLabel.Text = "Ordered Tests:";
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.Location = new System.Drawing.Point(419, 353);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(96, 23);
            this.submitOrderButton.TabIndex = 6;
            this.submitOrderButton.Text = "Submit Order";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(317, 353);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitOrderButton);
            this.Controls.Add(this.orderedTestsLabel);
            this.Controls.Add(this.availableTestsLabel);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.orderedListView);
            this.Controls.Add(this.availableListView);
            this.Name = "AddTestUserControl";
            this.Size = new System.Drawing.Size(543, 395);
            this.Load += new System.EventHandler(this.LoadTests);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView availableListView;
        private System.Windows.Forms.ListView orderedListView;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Label availableTestsLabel;
        private System.Windows.Forms.Label orderedTestsLabel;
        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.ColumnHeader codeColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader codeColumnHead;
        private System.Windows.Forms.ColumnHeader nameColumnHead;
        private System.Windows.Forms.Button cancelButton;
    }
}
