﻿namespace HealthCare.UserControls
{
    partial class PatientSearchUserControl
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
            System.Windows.Forms.Label dateOfBirthLabel1;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label lastNameLabel1;
            this.searchPatientDataGridView = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DOBButton = new System.Windows.Forms.Button();
            this.fullNameComboBox = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.DOBTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            dateOfBirthLabel1 = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfBirthLabel1
            // 
            dateOfBirthLabel1.AutoSize = true;
            dateOfBirthLabel1.Location = new System.Drawing.Point(53, 223);
            dateOfBirthLabel1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dateOfBirthLabel1.Name = "dateOfBirthLabel1";
            dateOfBirthLabel1.Size = new System.Drawing.Size(346, 32);
            dateOfBirthLabel1.TabIndex = 7;
            dateOfBirthLabel1.Text = "Date Of Birth (M/D/YYYY):";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(60, 70);
            fullNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(152, 32);
            fullNameLabel.TabIndex = 9;
            fullNameLabel.Text = "Full Name:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Location = new System.Drawing.Point(53, 147);
            lastNameLabel1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(159, 32);
            lastNameLabel1.TabIndex = 10;
            lastNameLabel1.Text = "Last Name:";
            // 
            // searchPatientDataGridView
            // 
            this.searchPatientDataGridView.AllowUserToOrderColumns = true;
            this.searchPatientDataGridView.AutoGenerateColumns = false;
            this.searchPatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchPatientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.searchPatientDataGridView.DataSource = this.searchPatientBindingSource;
            this.searchPatientDataGridView.Location = new System.Drawing.Point(8, 398);
            this.searchPatientDataGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchPatientDataGridView.Name = "searchPatientDataGridView";
            this.searchPatientDataGridView.Size = new System.Drawing.Size(1224, 227);
            this.searchPatientDataGridView.TabIndex = 7;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // searchPatientBindingSource
            // 
            this.searchPatientBindingSource.DataSource = typeof(HealthCare.Model.SearchPatient);
            // 
            // DOBButton
            // 
            this.DOBButton.Location = new System.Drawing.Point(704, 203);
            this.DOBButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DOBButton.Name = "DOBButton";
            this.DOBButton.Size = new System.Drawing.Size(243, 55);
            this.DOBButton.TabIndex = 9;
            this.DOBButton.Text = "Search D.O.B";
            this.DOBButton.UseVisualStyleBackColor = true;
            this.DOBButton.Click += new System.EventHandler(this.DOBButton_Click);
            // 
            // fullNameComboBox
            // 
            this.fullNameComboBox.DataSource = this.patientBindingSource;
            this.fullNameComboBox.DisplayMember = "FullName";
            this.fullNameComboBox.FormattingEnabled = true;
            this.fullNameComboBox.Location = new System.Drawing.Point(221, 67);
            this.fullNameComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fullNameComboBox.Name = "fullNameComboBox";
            this.fullNameComboBox.Size = new System.Drawing.Size(454, 39);
            this.fullNameComboBox.TabIndex = 10;
            this.fullNameComboBox.SelectedIndexChanged += new System.EventHandler(this.fullNameComboBox_SelectedIndexChanged);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(HealthCare.Model.Patient);
            // 
            // lastNameButton
            // 
            this.lastNameButton.Location = new System.Drawing.Point(704, 124);
            this.lastNameButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lastNameButton.Name = "lastNameButton";
            this.lastNameButton.Size = new System.Drawing.Size(296, 55);
            this.lastNameButton.TabIndex = 12;
            this.lastNameButton.Text = "Search Last Name";
            this.lastNameButton.UseVisualStyleBackColor = true;
            this.lastNameButton.Click += new System.EventHandler(this.lastNameButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(228, 141);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(447, 38);
            this.lastNameTextBox.TabIndex = 13;
            // 
            // DOBTextBox
            // 
            this.DOBTextBox.Location = new System.Drawing.Point(415, 220);
            this.DOBTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DOBTextBox.Name = "DOBTextBox";
            this.DOBTextBox.Size = new System.Drawing.Size(260, 38);
            this.DOBTextBox.TabIndex = 14;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(704, 297);
            this.clearButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(296, 55);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PatientSearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.DOBTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameButton);
            this.Controls.Add(lastNameLabel1);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameComboBox);
            this.Controls.Add(this.DOBButton);
            this.Controls.Add(dateOfBirthLabel1);
            this.Controls.Add(this.searchPatientDataGridView);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PatientSearchUserControl";
            this.Size = new System.Drawing.Size(1256, 653);
            this.Load += new System.EventHandler(this.PatientSearchUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView searchPatientDataGridView;
        private System.Windows.Forms.Button DOBButton;
        private System.Windows.Forms.ComboBox fullNameComboBox;
        private System.Windows.Forms.Button lastNameButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox DOBTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource searchPatientBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Button clearButton;
    }
}
