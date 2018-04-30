namespace MealCostCalculator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mealCostLabel = new System.Windows.Forms.Label();
            this.mealCostTextBox = new System.Windows.Forms.TextBox();
            this.partySizeGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalDiscountGroupBox = new System.Windows.Forms.GroupBox();
            this.veteranCheckBox = new System.Windows.Forms.CheckBox();
            this.studentCheckBox = new System.Windows.Forms.CheckBox();
            this.seniorCheckBox = new System.Windows.Forms.CheckBox();
            this.lesserRadioButton = new System.Windows.Forms.RadioButton();
            this.greaterRadioButton = new System.Windows.Forms.RadioButton();
            this.tipItemsListBox = new System.Windows.Forms.ListBox();
            this.caclulateButton = new System.Windows.Forms.Button();
            this.partySizeGroupBox.SuspendLayout();
            this.additionalDiscountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mealCostLabel
            // 
            this.mealCostLabel.Location = new System.Drawing.Point(134, 75);
            this.mealCostLabel.Name = "mealCostLabel";
            this.mealCostLabel.Size = new System.Drawing.Size(100, 24);
            this.mealCostLabel.TabIndex = 0;
            this.mealCostLabel.Text = "Meal Cost:";
            this.mealCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mealCostTextBox
            // 
            this.mealCostTextBox.Location = new System.Drawing.Point(267, 78);
            this.mealCostTextBox.Name = "mealCostTextBox";
            this.mealCostTextBox.Size = new System.Drawing.Size(116, 20);
            this.mealCostTextBox.TabIndex = 1;
            // 
            // partySizeGroupBox
            // 
            this.partySizeGroupBox.Controls.Add(this.greaterRadioButton);
            this.partySizeGroupBox.Controls.Add(this.lesserRadioButton);
            this.partySizeGroupBox.Location = new System.Drawing.Point(47, 130);
            this.partySizeGroupBox.Name = "partySizeGroupBox";
            this.partySizeGroupBox.Size = new System.Drawing.Size(186, 176);
            this.partySizeGroupBox.TabIndex = 2;
            this.partySizeGroupBox.TabStop = false;
            this.partySizeGroupBox.Text = "Party Size";
            // 
            // additionalDiscountGroupBox
            // 
            this.additionalDiscountGroupBox.Controls.Add(this.seniorCheckBox);
            this.additionalDiscountGroupBox.Controls.Add(this.studentCheckBox);
            this.additionalDiscountGroupBox.Controls.Add(this.veteranCheckBox);
            this.additionalDiscountGroupBox.Location = new System.Drawing.Point(267, 130);
            this.additionalDiscountGroupBox.Name = "additionalDiscountGroupBox";
            this.additionalDiscountGroupBox.Size = new System.Drawing.Size(188, 176);
            this.additionalDiscountGroupBox.TabIndex = 3;
            this.additionalDiscountGroupBox.TabStop = false;
            this.additionalDiscountGroupBox.Text = "Additional Discount (10%)";
            // 
            // veteranCheckBox
            // 
            this.veteranCheckBox.AutoSize = true;
            this.veteranCheckBox.Location = new System.Drawing.Point(36, 28);
            this.veteranCheckBox.Name = "veteranCheckBox";
            this.veteranCheckBox.Size = new System.Drawing.Size(100, 17);
            this.veteranCheckBox.TabIndex = 0;
            this.veteranCheckBox.Text = "Military/Veteran";
            this.veteranCheckBox.UseVisualStyleBackColor = true;
            // 
            // studentCheckBox
            // 
            this.studentCheckBox.AutoSize = true;
            this.studentCheckBox.Location = new System.Drawing.Point(36, 80);
            this.studentCheckBox.Name = "studentCheckBox";
            this.studentCheckBox.Size = new System.Drawing.Size(63, 17);
            this.studentCheckBox.TabIndex = 1;
            this.studentCheckBox.Text = "Student";
            this.studentCheckBox.UseVisualStyleBackColor = true;
            // 
            // seniorCheckBox
            // 
            this.seniorCheckBox.AutoSize = true;
            this.seniorCheckBox.Location = new System.Drawing.Point(36, 128);
            this.seniorCheckBox.Name = "seniorCheckBox";
            this.seniorCheckBox.Size = new System.Drawing.Size(90, 17);
            this.seniorCheckBox.TabIndex = 2;
            this.seniorCheckBox.Text = "Senior Citizen";
            this.seniorCheckBox.UseVisualStyleBackColor = true;
            // 
            // lesserRadioButton
            // 
            this.lesserRadioButton.AutoSize = true;
            this.lesserRadioButton.Location = new System.Drawing.Point(16, 51);
            this.lesserRadioButton.Name = "lesserRadioButton";
            this.lesserRadioButton.Size = new System.Drawing.Size(80, 17);
            this.lesserRadioButton.TabIndex = 0;
            this.lesserRadioButton.TabStop = true;
            this.lesserRadioButton.Text = "Less than 6";
            this.lesserRadioButton.UseVisualStyleBackColor = true;
            this.lesserRadioButton.CheckedChanged += new System.EventHandler(this.lesserRadioButton_CheckedChanged);
            // 
            // greaterRadioButton
            // 
            this.greaterRadioButton.AutoSize = true;
            this.greaterRadioButton.Location = new System.Drawing.Point(16, 104);
            this.greaterRadioButton.Name = "greaterRadioButton";
            this.greaterRadioButton.Size = new System.Drawing.Size(70, 17);
            this.greaterRadioButton.TabIndex = 1;
            this.greaterRadioButton.TabStop = true;
            this.greaterRadioButton.Text = "6 or More";
            this.greaterRadioButton.UseVisualStyleBackColor = true;
            this.greaterRadioButton.CheckedChanged += new System.EventHandler(this.greaterRadioButton_CheckedChanged);
            // 
            // tipItemsListBox
            // 
            this.tipItemsListBox.FormattingEnabled = true;
            this.tipItemsListBox.Items.AddRange(new object[] {
            "Tip Rates"});
            this.tipItemsListBox.Location = new System.Drawing.Point(116, 333);
            this.tipItemsListBox.Name = "tipItemsListBox";
            this.tipItemsListBox.Size = new System.Drawing.Size(276, 186);
            this.tipItemsListBox.TabIndex = 4;
            this.tipItemsListBox.SelectedIndexChanged += new System.EventHandler(this.tipItemsListBox_SelectedIndexChanged);
            // 
            // caclulateButton
            // 
            this.caclulateButton.Location = new System.Drawing.Point(183, 567);
            this.caclulateButton.Name = "caclulateButton";
            this.caclulateButton.Size = new System.Drawing.Size(129, 23);
            this.caclulateButton.TabIndex = 5;
            this.caclulateButton.Text = "Calclulate Total";
            this.caclulateButton.UseVisualStyleBackColor = true;
            this.caclulateButton.Click += new System.EventHandler(this.caclulateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 647);
            this.Controls.Add(this.caclulateButton);
            this.Controls.Add(this.tipItemsListBox);
            this.Controls.Add(this.additionalDiscountGroupBox);
            this.Controls.Add(this.partySizeGroupBox);
            this.Controls.Add(this.mealCostTextBox);
            this.Controls.Add(this.mealCostLabel);
            this.Name = "Form1";
            this.Text = "Meal Cost Calculator";
            this.partySizeGroupBox.ResumeLayout(false);
            this.partySizeGroupBox.PerformLayout();
            this.additionalDiscountGroupBox.ResumeLayout(false);
            this.additionalDiscountGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealCostLabel;
        private System.Windows.Forms.TextBox mealCostTextBox;
        private System.Windows.Forms.GroupBox partySizeGroupBox;
        private System.Windows.Forms.GroupBox additionalDiscountGroupBox;
        private System.Windows.Forms.CheckBox seniorCheckBox;
        private System.Windows.Forms.CheckBox studentCheckBox;
        private System.Windows.Forms.CheckBox veteranCheckBox;
        private System.Windows.Forms.RadioButton greaterRadioButton;
        private System.Windows.Forms.RadioButton lesserRadioButton;
        private System.Windows.Forms.ListBox tipItemsListBox;
        private System.Windows.Forms.Button caclulateButton;
    }
}

