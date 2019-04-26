namespace HealthCare.UserControls
{
    partial class ViewNurseUserControl
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
            this.inactiveRadioButton = new System.Windows.Forms.RadioButton();
            this.activeRadioButton = new System.Windows.Forms.RadioButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.zipTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ssnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateCodeLabel = new System.Windows.Forms.Label();
            this.stateCodeComboBox = new System.Windows.Forms.ComboBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nurseListView = new System.Windows.Forms.ListView();
            this.nurseIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientLastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.clear_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inactiveRadioButton
            // 
            this.inactiveRadioButton.AutoSize = true;
            this.inactiveRadioButton.Location = new System.Drawing.Point(1163, 732);
            this.inactiveRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inactiveRadioButton.Name = "inactiveRadioButton";
            this.inactiveRadioButton.Size = new System.Drawing.Size(150, 36);
            this.inactiveRadioButton.TabIndex = 11;
            this.inactiveRadioButton.TabStop = true;
            this.inactiveRadioButton.Text = "Inactive";
            this.inactiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // activeRadioButton
            // 
            this.activeRadioButton.AutoSize = true;
            this.activeRadioButton.Location = new System.Drawing.Point(925, 732);
            this.activeRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.activeRadioButton.Name = "activeRadioButton";
            this.activeRadioButton.Size = new System.Drawing.Size(130, 36);
            this.activeRadioButton.TabIndex = 10;
            this.activeRadioButton.TabStop = true;
            this.activeRadioButton.Text = "Active";
            this.activeRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(688, 737);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(189, 32);
            this.statusLabel.TabIndex = 22;
            this.statusLabel.Text = "Active Status:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(614, 812);
            this.addButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(227, 79);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(896, 812);
            this.updateButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 79);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(1483, 632);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.zipTextBox.Mask = "00000";
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(153, 38);
            this.zipTextBox.TabIndex = 9;
            this.zipTextBox.ValidatingType = typeof(int);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(691, 539);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.phoneTextBox.Mask = "000-000-0000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(260, 38);
            this.phoneTextBox.TabIndex = 5;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(1163, 539);
            this.ssnTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ssnTextBox.Mask = "000-00-0000";
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(260, 38);
            this.ssnTextBox.TabIndex = 6;
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.Location = new System.Drawing.Point(523, 441);
            this.DOBDateTimePicker.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(580, 38);
            this.DOBDateTimePicker.TabIndex = 3;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(411, 446);
            this.DOBLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(91, 32);
            this.DOBLabel.TabIndex = 88;
            this.DOBLabel.Text = "DOB: ";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(1005, 632);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(260, 38);
            this.cityTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(419, 639);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(127, 32);
            this.addressLabel.TabIndex = 86;
            this.addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(568, 632);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(260, 38);
            this.addressTextBox.TabIndex = 7;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(917, 639);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(72, 32);
            this.cityLabel.TabIndex = 84;
            this.cityLabel.Text = "City:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(1336, 639);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(125, 32);
            this.zipLabel.TabIndex = 83;
            this.zipLabel.Text = "Zipcode:";
            // 
            // stateCodeLabel
            // 
            this.stateCodeLabel.AutoSize = true;
            this.stateCodeLabel.Location = new System.Drawing.Point(1173, 448);
            this.stateCodeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.stateCodeLabel.Name = "stateCodeLabel";
            this.stateCodeLabel.Size = new System.Drawing.Size(90, 32);
            this.stateCodeLabel.TabIndex = 81;
            this.stateCodeLabel.Text = "State:";
            // 
            // stateCodeComboBox
            // 
            this.stateCodeComboBox.FormattingEnabled = true;
            this.stateCodeComboBox.Location = new System.Drawing.Point(1283, 439);
            this.stateCodeComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.stateCodeComboBox.Name = "stateCodeComboBox";
            this.stateCodeComboBox.Size = new System.Drawing.Size(319, 39);
            this.stateCodeComboBox.TabIndex = 4;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(1069, 546);
            this.ssnLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(81, 32);
            this.ssnLabel.TabIndex = 80;
            this.ssnLabel.Text = "SSN:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(565, 546);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(106, 32);
            this.phoneLabel.TabIndex = 79;
            this.phoneLabel.Text = "Phone:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(1283, 351);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(260, 38);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(544, 358);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(160, 32);
            this.firstNameLabel.TabIndex = 77;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(720, 351);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(260, 38);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(1104, 358);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(159, 32);
            this.lastNameLabel.TabIndex = 75;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // nurseListView
            // 
            this.nurseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nurseIDHeader,
            this.patientLastNameHeader,
            this.firstNameHeader,
            this.dobHeader});
            this.nurseListView.FullRowSelect = true;
            this.nurseListView.Location = new System.Drawing.Point(43, 43);
            this.nurseListView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nurseListView.MultiSelect = false;
            this.nurseListView.Name = "nurseListView";
            this.nurseListView.Size = new System.Drawing.Size(1828, 288);
            this.nurseListView.TabIndex = 101;
            this.nurseListView.UseCompatibleStateImageBehavior = false;
            this.nurseListView.View = System.Windows.Forms.View.Details;
            this.nurseListView.SelectedIndexChanged += new System.EventHandler(this.NurseListView_SelectedIndexChanged);
            // 
            // nurseIDHeader
            // 
            this.nurseIDHeader.Text = "Nurse ID";
            this.nurseIDHeader.Width = 93;
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
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(35, 2);
            this.searchResultLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(185, 32);
            this.searchResultLabel.TabIndex = 100;
            this.searchResultLabel.Text = "Select Nurse:";
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(1150, 812);
            this.clear_Button.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(200, 79);
            this.clear_Button.TabIndex = 14;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // ViewNurseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.nurseListView);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.DOBDateTimePicker);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateCodeLabel);
            this.Controls.Add(this.stateCodeComboBox);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.inactiveRadioButton);
            this.Controls.Add(this.activeRadioButton);
            this.Controls.Add(this.statusLabel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ViewNurseUserControl";
            this.Size = new System.Drawing.Size(1947, 954);
            this.Load += new System.EventHandler(this.ViewNurseUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inactiveRadioButton;
        private System.Windows.Forms.RadioButton activeRadioButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.MaskedTextBox zipTextBox;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.MaskedTextBox ssnTextBox;
        private System.Windows.Forms.DateTimePicker DOBDateTimePicker;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateCodeLabel;
        private System.Windows.Forms.ComboBox stateCodeComboBox;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.ListView nurseListView;
        private System.Windows.Forms.ColumnHeader nurseIDHeader;
        private System.Windows.Forms.ColumnHeader patientLastNameHeader;
        private System.Windows.Forms.ColumnHeader firstNameHeader;
        private System.Windows.Forms.ColumnHeader dobHeader;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.Button clear_Button;
    }
}
