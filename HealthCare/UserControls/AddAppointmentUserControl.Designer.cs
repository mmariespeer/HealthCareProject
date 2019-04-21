﻿namespace HealthCare.UserControls
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
            this.scheduleNewAppointmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(78, 611);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(113, 32);
            this.doctorLabel.TabIndex = 0;
            this.doctorLabel.Text = "Doctor: ";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(318, 611);
            this.doctorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(471, 39);
            this.doctorComboBox.TabIndex = 1;
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(1006, 605);
            this.appointmentDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(505, 38);
            this.appointmentDateTimePicker.TabIndex = 2;
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Location = new System.Drawing.Point(865, 618);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(83, 32);
            this.appointmentDateLabel.TabIndex = 3;
            this.appointmentDateLabel.Text = "Date:";
            // 
            // reasonForVisitTextBox
            // 
            this.reasonForVisitTextBox.Location = new System.Drawing.Point(318, 748);
            this.reasonForVisitTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reasonForVisitTextBox.Multiline = true;
            this.reasonForVisitTextBox.Name = "reasonForVisitTextBox";
            this.reasonForVisitTextBox.Size = new System.Drawing.Size(1193, 107);
            this.reasonForVisitTextBox.TabIndex = 4;
            // 
            // reasonForVisitLabel
            // 
            this.reasonForVisitLabel.AutoSize = true;
            this.reasonForVisitLabel.Location = new System.Drawing.Point(65, 773);
            this.reasonForVisitLabel.Name = "reasonForVisitLabel";
            this.reasonForVisitLabel.Size = new System.Drawing.Size(230, 32);
            this.reasonForVisitLabel.TabIndex = 5;
            this.reasonForVisitLabel.Text = "Reason for Visit: ";
            this.reasonForVisitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Location = new System.Drawing.Point(684, 911);
            this.createAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(376, 79);
            this.createAppointmentButton.TabIndex = 6;
            this.createAppointmentButton.Text = "Create Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            this.createAppointmentButton.Click += new System.EventHandler(this.CreateAppointmentButton_Click);
            // 
            // appointmentCreatedLabel
            // 
            this.appointmentCreatedLabel.AutoSize = true;
            this.appointmentCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentCreatedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.appointmentCreatedLabel.Location = new System.Drawing.Point(732, 1040);
            this.appointmentCreatedLabel.Name = "appointmentCreatedLabel";
            this.appointmentCreatedLabel.Size = new System.Drawing.Size(0, 39);
            this.appointmentCreatedLabel.TabIndex = 7;
            // 
            // appointmentTimeLabel
            // 
            this.appointmentTimeLabel.AutoSize = true;
            this.appointmentTimeLabel.Location = new System.Drawing.Point(865, 678);
            this.appointmentTimeLabel.Name = "appointmentTimeLabel";
            this.appointmentTimeLabel.Size = new System.Drawing.Size(93, 32);
            this.appointmentTimeLabel.TabIndex = 8;
            this.appointmentTimeLabel.Text = "Time: ";
            // 
            // appointmentTimeComboBox
            // 
            this.appointmentTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appointmentTimeComboBox.FormattingEnabled = true;
            this.appointmentTimeComboBox.Location = new System.Drawing.Point(1004, 671);
            this.appointmentTimeComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.appointmentTimeComboBox.Name = "appointmentTimeComboBox";
            this.appointmentTimeComboBox.Size = new System.Drawing.Size(505, 39);
            this.appointmentTimeComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Scheduled Appointments";
            // 
            // appointmentGridView
            // 
            this.appointmentGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.appointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGridView.Location = new System.Drawing.Point(39, 62);
            this.appointmentGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentGridView.Name = "appointmentGridView";
            this.appointmentGridView.ReadOnly = true;
            this.appointmentGridView.RowTemplate.Height = 40;
            this.appointmentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentGridView.Size = new System.Drawing.Size(1589, 439);
            this.appointmentGridView.TabIndex = 42;
            // 
            // scheduleNewAppointmentLabel
            // 
            this.scheduleNewAppointmentLabel.AutoSize = true;
            this.scheduleNewAppointmentLabel.Location = new System.Drawing.Point(694, 522);
            this.scheduleNewAppointmentLabel.Name = "scheduleNewAppointmentLabel";
            this.scheduleNewAppointmentLabel.Size = new System.Drawing.Size(366, 32);
            this.scheduleNewAppointmentLabel.TabIndex = 44;
            this.scheduleNewAppointmentLabel.Text = "Schedule New Appointment";
            // 
            // AddAppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scheduleNewAppointmentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appointmentGridView);
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
            this.Size = new System.Drawing.Size(1671, 1064);
            this.Load += new System.EventHandler(this.AddAppointmentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).EndInit();
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
        private System.Windows.Forms.Label scheduleNewAppointmentLabel;
    }
}
