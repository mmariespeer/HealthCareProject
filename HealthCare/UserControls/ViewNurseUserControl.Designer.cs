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
            this.clearButton = new System.Windows.Forms.Button();
            this.patientListView = new System.Windows.Forms.ListView();
            this.nurseIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientLastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dobMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clear_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inactiveRadioButton
            // 
            this.inactiveRadioButton.AutoSize = true;
            this.inactiveRadioButton.Location = new System.Drawing.Point(400, 402);
            this.inactiveRadioButton.Name = "inactiveRadioButton";
            this.inactiveRadioButton.Size = new System.Drawing.Size(63, 17);
            this.inactiveRadioButton.TabIndex = 24;
            this.inactiveRadioButton.TabStop = true;
            this.inactiveRadioButton.Text = "Inactive";
            this.inactiveRadioButton.UseVisualStyleBackColor = true;
            this.inactiveRadioButton.Visible = false;
            // 
            // activeRadioButton
            // 
            this.activeRadioButton.AutoSize = true;
            this.activeRadioButton.Location = new System.Drawing.Point(311, 402);
            this.activeRadioButton.Name = "activeRadioButton";
            this.activeRadioButton.Size = new System.Drawing.Size(55, 17);
            this.activeRadioButton.TabIndex = 23;
            this.activeRadioButton.TabStop = true;
            this.activeRadioButton.Text = "Active";
            this.activeRadioButton.UseVisualStyleBackColor = true;
            this.activeRadioButton.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(222, 404);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(73, 13);
            this.statusLabel.TabIndex = 22;
            this.statusLabel.Text = "Active Status:";
            this.statusLabel.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(210, 343);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 33);
            this.addButton.TabIndex = 53;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(316, 343);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 33);
            this.updateButton.TabIndex = 52;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(531, 278);
            this.zipTextBox.Mask = "00000";
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(60, 20);
            this.zipTextBox.TabIndex = 92;
            this.zipTextBox.ValidatingType = typeof(int);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(234, 239);
            this.phoneTextBox.Mask = "000-000-0000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 91;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(411, 239);
            this.ssnTextBox.Mask = "000-00-0000";
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(100, 20);
            this.ssnTextBox.TabIndex = 90;
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.Location = new System.Drawing.Point(171, 198);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(220, 20);
            this.DOBDateTimePicker.TabIndex = 89;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(129, 200);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(36, 13);
            this.DOBLabel.TabIndex = 88;
            this.DOBLabel.Text = "DOB: ";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(352, 278);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 87;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(132, 281);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 86;
            this.addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(188, 278);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 85;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(319, 281);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 84;
            this.cityLabel.Text = "City:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(476, 281);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(49, 13);
            this.zipLabel.TabIndex = 83;
            this.zipLabel.Text = "Zipcode:";
            // 
            // stateCodeLabel
            // 
            this.stateCodeLabel.AutoSize = true;
            this.stateCodeLabel.Location = new System.Drawing.Point(415, 201);
            this.stateCodeLabel.Name = "stateCodeLabel";
            this.stateCodeLabel.Size = new System.Drawing.Size(35, 13);
            this.stateCodeLabel.TabIndex = 81;
            this.stateCodeLabel.Text = "State:";
            // 
            // stateCodeComboBox
            // 
            this.stateCodeComboBox.FormattingEnabled = true;
            this.stateCodeComboBox.Location = new System.Drawing.Point(456, 197);
            this.stateCodeComboBox.Name = "stateCodeComboBox";
            this.stateCodeComboBox.Size = new System.Drawing.Size(122, 21);
            this.stateCodeComboBox.TabIndex = 82;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(376, 242);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(32, 13);
            this.ssnLabel.TabIndex = 80;
            this.ssnLabel.Text = "SSN:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(187, 242);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 79;
            this.phoneLabel.Text = "Phone:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(456, 160);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 78;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(179, 163);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 77;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(245, 160);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 76;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(389, 163);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 75;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(627, 22);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 102;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // patientListView
            // 
            this.patientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nurseIDHeader,
            this.patientLastNameHeader,
            this.firstNameHeader,
            this.dobHeader});
            this.patientListView.FullRowSelect = true;
            this.patientListView.Location = new System.Drawing.Point(14, 73);
            this.patientListView.MultiSelect = false;
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(688, 69);
            this.patientListView.TabIndex = 101;
            this.patientListView.UseCompatibleStateImageBehavior = false;
            this.patientListView.View = System.Windows.Forms.View.Details;
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
            this.searchResultLabel.Location = new System.Drawing.Point(11, 56);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(71, 13);
            this.searchResultLabel.TabIndex = 100;
            this.searchResultLabel.Text = "Select Nurse:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(537, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 99;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "DOB:";
            // 
            // dobMaskedTextBox
            // 
            this.dobMaskedTextBox.Location = new System.Drawing.Point(418, 24);
            this.dobMaskedTextBox.Mask = "00/00/0000";
            this.dobMaskedTextBox.Name = "dobMaskedTextBox";
            this.dobMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dobMaskedTextBox.TabIndex = 97;
            this.dobMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "First Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Last Name:";
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(411, 343);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(75, 33);
            this.clear_Button.TabIndex = 103;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // ViewNurseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.patientListView);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dobMaskedTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
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
            this.Name = "ViewNurseUserControl";
            this.Size = new System.Drawing.Size(730, 468);
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
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListView patientListView;
        private System.Windows.Forms.ColumnHeader nurseIDHeader;
        private System.Windows.Forms.ColumnHeader patientLastNameHeader;
        private System.Windows.Forms.ColumnHeader firstNameHeader;
        private System.Windows.Forms.ColumnHeader dobHeader;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox dobMaskedTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear_Button;
    }
}
