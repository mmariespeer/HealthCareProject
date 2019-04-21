namespace HealthCare.UserControls
{
    partial class RegisterPatientUserControl
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
            this.registerButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.zipTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(363, 219);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.phoneTextBox.Mask = "000-000-0000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(260, 38);
            this.phoneTextBox.TabIndex = 5;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(835, 219);
            this.ssnTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ssnTextBox.Mask = "000-00-0000";
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(260, 38);
            this.ssnTextBox.TabIndex = 6;
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.Location = new System.Drawing.Point(195, 122);
            this.DOBDateTimePicker.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(580, 38);
            this.DOBDateTimePicker.TabIndex = 3;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(83, 126);
            this.DOBLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(91, 32);
            this.DOBLabel.TabIndex = 68;
            this.DOBLabel.Text = "DOB: ";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(677, 312);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(260, 38);
            this.cityTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(91, 320);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(127, 32);
            this.addressLabel.TabIndex = 66;
            this.addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(240, 312);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(260, 38);
            this.addressTextBox.TabIndex = 7;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(589, 320);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(72, 32);
            this.cityLabel.TabIndex = 64;
            this.cityLabel.Text = "City:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(1008, 320);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(125, 32);
            this.zipLabel.TabIndex = 62;
            this.zipLabel.Text = "Zipcode:";
            // 
            // stateCodeLabel
            // 
            this.stateCodeLabel.AutoSize = true;
            this.stateCodeLabel.Location = new System.Drawing.Point(845, 129);
            this.stateCodeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.stateCodeLabel.Name = "stateCodeLabel";
            this.stateCodeLabel.Size = new System.Drawing.Size(90, 32);
            this.stateCodeLabel.TabIndex = 58;
            this.stateCodeLabel.Text = "State:";
            // 
            // stateCodeComboBox
            // 
            this.stateCodeComboBox.FormattingEnabled = true;
            this.stateCodeComboBox.Location = new System.Drawing.Point(955, 119);
            this.stateCodeComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.stateCodeComboBox.Name = "stateCodeComboBox";
            this.stateCodeComboBox.Size = new System.Drawing.Size(319, 39);
            this.stateCodeComboBox.TabIndex = 4;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(741, 227);
            this.ssnLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(81, 32);
            this.ssnLabel.TabIndex = 57;
            this.ssnLabel.Text = "SSN:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(237, 227);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(106, 32);
            this.phoneLabel.TabIndex = 56;
            this.phoneLabel.Text = "Phone:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(955, 31);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(260, 38);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(216, 38);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(160, 32);
            this.firstNameLabel.TabIndex = 54;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(392, 31);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(260, 38);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(776, 38);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(159, 32);
            this.lastNameLabel.TabIndex = 52;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(187, 458);
            this.registerButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(227, 79);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(955, 458);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 79);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(475, 458);
            this.updateButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 79);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(731, 458);
            this.clearButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(200, 79);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(1155, 312);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.zipTextBox.Mask = "00000";
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(153, 38);
            this.zipTextBox.TabIndex = 9;
            this.zipTextBox.ValidatingType = typeof(int);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(HealthCare.Model.State);
            // 
            // RegisterPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.clearButton);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "RegisterPatientUserControl";
            this.Size = new System.Drawing.Size(1371, 596);
            this.Load += new System.EventHandler(this.RegisterPatientUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.MaskedTextBox zipTextBox;
    }
}
