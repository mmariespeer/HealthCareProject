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
            this.SuspendLayout();
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(85, 93);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(113, 32);
            this.doctorLabel.TabIndex = 0;
            this.doctorLabel.Text = "Doctor: ";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(204, 90);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(324, 39);
            this.doctorComboBox.TabIndex = 1;
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(835, 93);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(449, 38);
            this.appointmentDateTimePicker.TabIndex = 2;
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Location = new System.Drawing.Point(578, 93);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(251, 32);
            this.appointmentDateLabel.TabIndex = 3;
            this.appointmentDateLabel.Text = "Appointment Date:";
            // 
            // reasonForVisitTextBox
            // 
            this.reasonForVisitTextBox.Location = new System.Drawing.Point(394, 184);
            this.reasonForVisitTextBox.Multiline = true;
            this.reasonForVisitTextBox.Name = "reasonForVisitTextBox";
            this.reasonForVisitTextBox.Size = new System.Drawing.Size(515, 216);
            this.reasonForVisitTextBox.TabIndex = 4;
            // 
            // reasonForVisitLabel
            // 
            this.reasonForVisitLabel.AutoSize = true;
            this.reasonForVisitLabel.Location = new System.Drawing.Point(158, 187);
            this.reasonForVisitLabel.Name = "reasonForVisitLabel";
            this.reasonForVisitLabel.Size = new System.Drawing.Size(230, 32);
            this.reasonForVisitLabel.TabIndex = 5;
            this.reasonForVisitLabel.Text = "Reason for Visit: ";
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Location = new System.Drawing.Point(474, 430);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(372, 63);
            this.createAppointmentButton.TabIndex = 6;
            this.createAppointmentButton.Text = "Create Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // appointmentCreatedLabel
            // 
            this.appointmentCreatedLabel.AutoSize = true;
            this.appointmentCreatedLabel.Location = new System.Drawing.Point(514, 554);
            this.appointmentCreatedLabel.Name = "appointmentCreatedLabel";
            this.appointmentCreatedLabel.Size = new System.Drawing.Size(0, 32);
            this.appointmentCreatedLabel.TabIndex = 7;
            // 
            // AddAppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appointmentCreatedLabel);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.reasonForVisitLabel);
            this.Controls.Add(this.reasonForVisitTextBox);
            this.Controls.Add(this.appointmentDateLabel);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.doctorLabel);
            this.Name = "AddAppointmentUserControl";
            this.Size = new System.Drawing.Size(1327, 714);
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
    }
}
