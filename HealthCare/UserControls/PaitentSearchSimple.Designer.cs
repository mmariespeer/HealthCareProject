namespace HealthCare.UserControls
{
    partial class PaitentSearchSimple
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dobMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.patientListView = new System.Windows.Forms.ListView();
            this.patientIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientLastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 36);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(80, 33);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(261, 33);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(194, 36);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // dobMaskedTextBox
            // 
            this.dobMaskedTextBox.Location = new System.Drawing.Point(420, 33);
            this.dobMaskedTextBox.Mask = "00/00/0000";
            this.dobMaskedTextBox.Name = "dobMaskedTextBox";
            this.dobMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dobMaskedTextBox.TabIndex = 4;
            this.dobMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(381, 36);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(33, 13);
            this.dobLabel.TabIndex = 5;
            this.dobLabel.Text = "DOB:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(539, 31);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(13, 65);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(76, 13);
            this.searchResultLabel.TabIndex = 8;
            this.searchResultLabel.Text = "Select Patient:";
            // 
            // patientListView
            // 
            this.patientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientIDHeader,
            this.patientLastNameHeader,
            this.firstNameHeader,
            this.dobHeader});
            this.patientListView.FullRowSelect = true;
            this.patientListView.HideSelection = false;
            this.patientListView.Location = new System.Drawing.Point(16, 82);
            this.patientListView.MultiSelect = false;
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(688, 69);
            this.patientListView.TabIndex = 9;
            this.patientListView.UseCompatibleStateImageBehavior = false;
            this.patientListView.View = System.Windows.Forms.View.Details;
            this.patientListView.SelectedIndexChanged += new System.EventHandler(this.PatientListView_SelectedIndexChanged);
            // 
            // patientIDHeader
            // 
            this.patientIDHeader.Text = "Patient ID";
            this.patientIDHeader.Width = 93;
            // 
            // patientLastNameHeader
            // 
            this.patientLastNameHeader.Text = "Last Name";
            this.patientLastNameHeader.Width = 98;
            // 
            // firstNameHeader
            // 
            this.firstNameHeader.Text = "First Name";
            this.firstNameHeader.Width = 97;
            // 
            // dobHeader
            // 
            this.dobHeader.Text = "DOB";
            this.dobHeader.Width = 91;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(629, 31);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(13, 11);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(417, 13);
            this.instructionLabel.TabIndex = 11;
            this.instructionLabel.Text = "To begin, please search for and select a patient. To start over, click the \"Clear" +
    "\" button.";
            // 
            // PaitentSearchSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.patientListView);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.dobMaskedTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "PaitentSearchSimple";
            this.Size = new System.Drawing.Size(726, 161);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.MaskedTextBox dobMaskedTextBox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.ListView patientListView;
        private System.Windows.Forms.ColumnHeader patientIDHeader;
        private System.Windows.Forms.ColumnHeader patientLastNameHeader;
        private System.Windows.Forms.ColumnHeader firstNameHeader;
        private System.Windows.Forms.ColumnHeader dobHeader;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label instructionLabel;
    }
}