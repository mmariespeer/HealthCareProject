namespace HealthCare.UserControls
{
    partial class VisitUserControl
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tempLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addTestsButton = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.pendingRadioButton = new System.Windows.Forms.RadioButton();
            this.completeRadioButton = new System.Windows.Forms.RadioButton();
            this.updateButton = new System.Windows.Forms.Button();
            this.completedLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.visitListView = new System.Windows.Forms.ListView();
            this.selectApttLabel = new System.Windows.Forms.Label();
            this.visitDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.visitDoctorHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(22, 138);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(42, 13);
            this.doctorLabel.TabIndex = 0;
            this.doctorLabel.Text = "Doctor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(22, 166);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(66, 13);
            this.weightLabel.TabIndex = 2;
            this.weightLabel.Text = "Weight (lbs):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(290, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 5;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(232, 166);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(52, 13);
            this.tempLabel.TabIndex = 4;
            this.tempLabel.Text = "Temp (F):";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(519, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "BP Systolic/Diastolic:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(589, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(45, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Symptoms:";
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Location = new System.Drawing.Point(111, 190);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(523, 75);
            this.symptomsTextBox.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 272);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 20);
            this.textBox5.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Initial Diagnosis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ordered Tests:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 108);
            this.dataGridView1.TabIndex = 15;
            // 
            // addTestsButton
            // 
            this.addTestsButton.Location = new System.Drawing.Point(111, 414);
            this.addTestsButton.Name = "addTestsButton";
            this.addTestsButton.Size = new System.Drawing.Size(117, 23);
            this.addTestsButton.TabIndex = 16;
            this.addTestsButton.Text = "Add Tests";
            this.addTestsButton.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(111, 443);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(117, 20);
            this.textBox6.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Final Diagnosis:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(22, 480);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(62, 13);
            this.statusLabel.TabIndex = 19;
            this.statusLabel.Text = "Visit Status:";
            // 
            // pendingRadioButton
            // 
            this.pendingRadioButton.AutoSize = true;
            this.pendingRadioButton.Location = new System.Drawing.Point(111, 478);
            this.pendingRadioButton.Name = "pendingRadioButton";
            this.pendingRadioButton.Size = new System.Drawing.Size(64, 17);
            this.pendingRadioButton.TabIndex = 20;
            this.pendingRadioButton.TabStop = true;
            this.pendingRadioButton.Text = "Pending";
            this.pendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // completeRadioButton
            // 
            this.completeRadioButton.AutoSize = true;
            this.completeRadioButton.Location = new System.Drawing.Point(200, 478);
            this.completeRadioButton.Name = "completeRadioButton";
            this.completeRadioButton.Size = new System.Drawing.Size(69, 17);
            this.completeRadioButton.TabIndex = 21;
            this.completeRadioButton.TabStop = true;
            this.completeRadioButton.Text = "Complete";
            this.completeRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(558, 515);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update Visit";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // completedLabel
            // 
            this.completedLabel.AutoSize = true;
            this.completedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedLabel.ForeColor = System.Drawing.Color.Red;
            this.completedLabel.Location = new System.Drawing.Point(176, 515);
            this.completedLabel.Name = "completedLabel";
            this.completedLabel.Size = new System.Drawing.Size(341, 17);
            this.completedLabel.TabIndex = 23;
            this.completedLabel.Text = "Visit has been marked complete - cannot edit.";
            this.completedLabel.Visible = false;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.Location = new System.Drawing.Point(480, 446);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(84, 24);
            this.testLabel.TabIndex = 24;
            this.testLabel.Text = "testLabel";
            // 
            // visitListView
            // 
            this.visitListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientNameHeader,
            this.visitDateHeader,
            this.visitDoctorHeader});
            this.visitListView.FullRowSelect = true;
            this.visitListView.Location = new System.Drawing.Point(111, 18);
            this.visitListView.MultiSelect = false;
            this.visitListView.Name = "visitListView";
            this.visitListView.Size = new System.Drawing.Size(522, 102);
            this.visitListView.TabIndex = 25;
            this.visitListView.UseCompatibleStateImageBehavior = false;
            this.visitListView.View = System.Windows.Forms.View.Details;
            // 
            // selectApttLabel
            // 
            this.selectApttLabel.AutoSize = true;
            this.selectApttLabel.Location = new System.Drawing.Point(22, 18);
            this.selectApttLabel.Name = "selectApttLabel";
            this.selectApttLabel.Size = new System.Drawing.Size(65, 13);
            this.selectApttLabel.TabIndex = 26;
            this.selectApttLabel.Text = "Select Appt:";
            // 
            // visitDateHeader
            // 
            this.visitDateHeader.DisplayIndex = 0;
            this.visitDateHeader.Text = "Date of Visit";
            this.visitDateHeader.Width = 92;
            // 
            // visitDoctorHeader
            // 
            this.visitDoctorHeader.DisplayIndex = 1;
            this.visitDoctorHeader.Text = "Doctor";
            this.visitDoctorHeader.Width = 80;
            // 
            // patientNameHeader
            // 
            this.patientNameHeader.DisplayIndex = 2;
            this.patientNameHeader.Text = "Patient Name";
            this.patientNameHeader.Width = 98;
            // 
            // VisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectApttLabel);
            this.Controls.Add(this.visitListView);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.completedLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.completeRadioButton);
            this.Controls.Add(this.pendingRadioButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addTestsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.symptomsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.doctorLabel);
            this.Name = "VisitUserControl";
            this.Size = new System.Drawing.Size(665, 555);
            this.Load += new System.EventHandler(this.VisitUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addTestsButton;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.RadioButton pendingRadioButton;
        private System.Windows.Forms.RadioButton completeRadioButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label completedLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.ListView visitListView;
        private System.Windows.Forms.Label selectApttLabel;
        private System.Windows.Forms.ColumnHeader patientNameHeader;
        private System.Windows.Forms.ColumnHeader visitDateHeader;
        private System.Windows.Forms.ColumnHeader visitDoctorHeader;
    }
}
