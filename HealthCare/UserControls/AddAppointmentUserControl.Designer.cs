namespace HealthCare.UserControls
{
    partial class AddAppointmentUserControl
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
            this.doctorLabel = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.reasonForVisitTextBox = new System.Windows.Forms.TextBox();
            this.reasonForVisitLabel = new System.Windows.Forms.Label();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentCreatedLabel = new System.Windows.Forms.Label();
            this.appointmentTimeLabel = new System.Windows.Forms.Label();
            this.appointmentTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.searchByLastNameButton = new System.Windows.Forms.Button();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.searchDOBButton = new System.Windows.Forms.Button();
            this.selectpatientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(53, 644);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(113, 32);
            this.doctorLabel.TabIndex = 0;
            this.doctorLabel.Text = "Doctor: ";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(293, 644);
            this.doctorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(471, 39);
            this.doctorComboBox.TabIndex = 1;
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(1011, 639);
            this.appointmentDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(529, 38);
            this.appointmentDateTimePicker.TabIndex = 2;
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Location = new System.Drawing.Point(845, 658);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(83, 32);
            this.appointmentDateLabel.TabIndex = 3;
            this.appointmentDateLabel.Text = "Date:";
            // 
            // reasonForVisitTextBox
            // 
            this.reasonForVisitTextBox.Location = new System.Drawing.Point(293, 806);
            this.reasonForVisitTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reasonForVisitTextBox.Multiline = true;
            this.reasonForVisitTextBox.Name = "reasonForVisitTextBox";
            this.reasonForVisitTextBox.Size = new System.Drawing.Size(1247, 107);
            this.reasonForVisitTextBox.TabIndex = 4;
            // 
            // reasonForVisitLabel
            // 
            this.reasonForVisitLabel.AutoSize = true;
            this.reasonForVisitLabel.Location = new System.Drawing.Point(40, 806);
            this.reasonForVisitLabel.Name = "reasonForVisitLabel";
            this.reasonForVisitLabel.Size = new System.Drawing.Size(230, 32);
            this.reasonForVisitLabel.TabIndex = 5;
            this.reasonForVisitLabel.Text = "Reason for Visit: ";
            this.reasonForVisitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Location = new System.Drawing.Point(664, 949);
            this.createAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(376, 79);
            this.createAppointmentButton.TabIndex = 6;
            this.createAppointmentButton.Text = "Create Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            this.createAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
            // 
            // appointmentCreatedLabel
            // 
            this.appointmentCreatedLabel.AutoSize = true;
            this.appointmentCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentCreatedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.appointmentCreatedLabel.Location = new System.Drawing.Point(643, 1042);
            this.appointmentCreatedLabel.Name = "appointmentCreatedLabel";
            this.appointmentCreatedLabel.Size = new System.Drawing.Size(0, 39);
            this.appointmentCreatedLabel.TabIndex = 7;
            // 
            // appointmentTimeLabel
            // 
            this.appointmentTimeLabel.AutoSize = true;
            this.appointmentTimeLabel.Location = new System.Drawing.Point(845, 718);
            this.appointmentTimeLabel.Name = "appointmentTimeLabel";
            this.appointmentTimeLabel.Size = new System.Drawing.Size(93, 32);
            this.appointmentTimeLabel.TabIndex = 8;
            this.appointmentTimeLabel.Text = "Time: ";
            // 
            // appointmentTimeComboBox
            // 
            this.appointmentTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appointmentTimeComboBox.FormattingEnabled = true;
            this.appointmentTimeComboBox.Location = new System.Drawing.Point(1011, 699);
            this.appointmentTimeComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.appointmentTimeComboBox.Name = "appointmentTimeComboBox";
            this.appointmentTimeComboBox.Size = new System.Drawing.Size(529, 39);
            this.appointmentTimeComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Scheduled Appointments";
            // 
            // appointmentGridView
            // 
            this.appointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGridView.Location = new System.Drawing.Point(165, 434);
            this.appointmentGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentGridView.Name = "appointmentGridView";
            this.appointmentGridView.RowTemplate.Height = 40;
            this.appointmentGridView.Size = new System.Drawing.Size(1320, 165);
            this.appointmentGridView.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date of Birth : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(867, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Last Name : ";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(1046, 26);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(439, 38);
            this.lastNameTextBox.TabIndex = 38;
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(240, 26);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(575, 38);
            this.dobPicker.TabIndex = 39;
            // 
            // searchByLastNameButton
            // 
            this.searchByLastNameButton.Location = new System.Drawing.Point(1046, 105);
            this.searchByLastNameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchByLastNameButton.Name = "searchByLastNameButton";
            this.searchByLastNameButton.Size = new System.Drawing.Size(376, 62);
            this.searchByLastNameButton.TabIndex = 40;
            this.searchByLastNameButton.Text = "Search Last Name";
            this.searchByLastNameButton.UseVisualStyleBackColor = true;
            this.searchByLastNameButton.Click += new System.EventHandler(this.searchByLastNameButton_Click);
            // 
            // patientGridView
            // 
            this.patientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGridView.Location = new System.Drawing.Point(165, 196);
            this.patientGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.RowTemplate.Height = 40;
            this.patientGridView.Size = new System.Drawing.Size(1320, 165);
            this.patientGridView.TabIndex = 41;
            // 
            // searchDOBButton
            // 
            this.searchDOBButton.Location = new System.Drawing.Point(240, 105);
            this.searchDOBButton.Name = "searchDOBButton";
            this.searchDOBButton.Size = new System.Drawing.Size(376, 62);
            this.searchDOBButton.TabIndex = 44;
            this.searchDOBButton.Text = "Search DOB";
            this.searchDOBButton.UseVisualStyleBackColor = true;
            this.searchDOBButton.Click += new System.EventHandler(this.searchDOBButton_Click);
            // 
            // selectpatientLabel
            // 
            this.selectpatientLabel.AutoSize = true;
            this.selectpatientLabel.Location = new System.Drawing.Point(691, 162);
            this.selectpatientLabel.Name = "selectpatientLabel";
            this.selectpatientLabel.Size = new System.Drawing.Size(277, 32);
            this.selectpatientLabel.TabIndex = 45;
            this.selectpatientLabel.Text = "Select Patient Below";
            // 
            // AddAppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectpatientLabel);
            this.Controls.Add(this.searchDOBButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appointmentGridView);
            this.Controls.Add(this.patientGridView);
            this.Controls.Add(this.searchByLastNameButton);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appointmentTimeComboBox);
            this.Controls.Add(this.appointmentTimeLabel);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.reasonForVisitLabel);
            this.Controls.Add(this.appointmentDateLabel);
            this.Controls.Add(this.reasonForVisitTextBox);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.appointmentCreatedLabel);
            this.Controls.Add(this.createAppointmentButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAppointmentUserControl";
            this.Size = new System.Drawing.Size(1594, 1062);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.TextBox reasonForVisitTextBox;
        private System.Windows.Forms.Label reasonForVisitLabel;
        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.Label appointmentCreatedLabel;
        private System.Windows.Forms.Label appointmentTimeLabel;
        private System.Windows.Forms.ComboBox appointmentTimeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView appointmentGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Button searchByLastNameButton;
        private System.Windows.Forms.DataGridView patientGridView;
        private System.Windows.Forms.Button searchDOBButton;
        private System.Windows.Forms.Label selectpatientLabel;
    }
}
