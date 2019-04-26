namespace HealthCare.UserControls
{
    partial class LogTestResultsUserControl
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.abnormalRadioButton = new System.Windows.Forms.RadioButton();
            this.logResultText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.testNameLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.performMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.performDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(15, 66);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Result:";
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Location = new System.Drawing.Point(77, 96);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(58, 17);
            this.normalRadioButton.TabIndex = 1;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // abnormalRadioButton
            // 
            this.abnormalRadioButton.AutoSize = true;
            this.abnormalRadioButton.Location = new System.Drawing.Point(77, 119);
            this.abnormalRadioButton.Name = "abnormalRadioButton";
            this.abnormalRadioButton.Size = new System.Drawing.Size(69, 17);
            this.abnormalRadioButton.TabIndex = 2;
            this.abnormalRadioButton.TabStop = true;
            this.abnormalRadioButton.Text = "Abnormal";
            this.abnormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // logResultText
            // 
            this.logResultText.Location = new System.Drawing.Point(77, 63);
            this.logResultText.Name = "logResultText";
            this.logResultText.Size = new System.Drawing.Size(100, 20);
            this.logResultText.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(18, 151);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(133, 151);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Location = new System.Drawing.Point(74, 14);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(77, 13);
            this.testNameLabel.TabIndex = 6;
            this.testNameLabel.Text = "TestNameFillIn";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(15, 14);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(31, 13);
            this.testLabel.TabIndex = 7;
            this.testLabel.Text = "Test:";
            // 
            // performMaskedTextBox
            // 
            this.performMaskedTextBox.Location = new System.Drawing.Point(108, 37);
            this.performMaskedTextBox.Mask = "00/00/0000";
            this.performMaskedTextBox.Name = "performMaskedTextBox";
            this.performMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.performMaskedTextBox.TabIndex = 8;
            this.performMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // performDateLabel
            // 
            this.performDateLabel.AutoSize = true;
            this.performDateLabel.Location = new System.Drawing.Point(15, 40);
            this.performDateLabel.Name = "performDateLabel";
            this.performDateLabel.Size = new System.Drawing.Size(72, 13);
            this.performDateLabel.TabIndex = 9;
            this.performDateLabel.Text = "Perform Date:";
            // 
            // LogTestResultsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.performDateLabel);
            this.Controls.Add(this.performMaskedTextBox);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.testNameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.logResultText);
            this.Controls.Add(this.abnormalRadioButton);
            this.Controls.Add(this.normalRadioButton);
            this.Controls.Add(this.resultLabel);
            this.Name = "LogTestResultsUserControl";
            this.Size = new System.Drawing.Size(228, 192);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton abnormalRadioButton;
        private System.Windows.Forms.TextBox logResultText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label testNameLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.MaskedTextBox performMaskedTextBox;
        private System.Windows.Forms.Label performDateLabel;
    }
}
