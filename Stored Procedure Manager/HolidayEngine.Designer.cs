namespace Stored_Procedure_Manager
{
    partial class HolidayEngine
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
            this.HolidayEngineComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExceptionsTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ApplyRateCheckBox = new System.Windows.Forms.CheckBox();
            this.TowardHolidayCheckBox = new System.Windows.Forms.CheckBox();
            this.TowardOTCheckBox = new System.Windows.Forms.CheckBox();
            this.DayAfterCheckBox = new System.Windows.Forms.CheckBox();
            this.DayBeforeCheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProbationMonthsTextBox = new System.Windows.Forms.TextBox();
            this.ProbationDaysTextBox = new System.Windows.Forms.TextBox();
            this.FutureDaysTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HolidayCommentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HolidayPayCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PayPolicyNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HolidayEngineComboBox
            // 
            this.HolidayEngineComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.HolidayEngineComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.HolidayEngineComboBox.FormattingEnabled = true;
            this.HolidayEngineComboBox.Location = new System.Drawing.Point(286, 12);
            this.HolidayEngineComboBox.Name = "HolidayEngineComboBox";
            this.HolidayEngineComboBox.Size = new System.Drawing.Size(256, 21);
            this.HolidayEngineComboBox.TabIndex = 0;
            this.HolidayEngineComboBox.SelectedIndexChanged += new System.EventHandler(this.HolidayEngineComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExceptionsTextBox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.ApplyRateCheckBox);
            this.panel1.Controls.Add(this.TowardHolidayCheckBox);
            this.panel1.Controls.Add(this.TowardOTCheckBox);
            this.panel1.Controls.Add(this.DayAfterCheckBox);
            this.panel1.Controls.Add(this.DayBeforeCheckBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ProbationMonthsTextBox);
            this.panel1.Controls.Add(this.ProbationDaysTextBox);
            this.panel1.Controls.Add(this.FutureDaysTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.HoursTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.HolidayCommentTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.HolidayPayCodeTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PayPolicyNameTextBox);
            this.panel1.Location = new System.Drawing.Point(167, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 334);
            this.panel1.TabIndex = 1;
            // 
            // ExceptionsTextBox
            // 
            this.ExceptionsTextBox.Location = new System.Drawing.Point(120, 202);
            this.ExceptionsTextBox.Name = "ExceptionsTextBox";
            this.ExceptionsTextBox.Size = new System.Drawing.Size(114, 20);
            this.ExceptionsTextBox.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Exceptions";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Hours (Mins)";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(290, 300);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ApplyRateCheckBox
            // 
            this.ApplyRateCheckBox.AutoSize = true;
            this.ApplyRateCheckBox.Location = new System.Drawing.Point(360, 203);
            this.ApplyRateCheckBox.Name = "ApplyRateCheckBox";
            this.ApplyRateCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ApplyRateCheckBox.TabIndex = 28;
            this.ApplyRateCheckBox.UseVisualStyleBackColor = true;
            // 
            // TowardHolidayCheckBox
            // 
            this.TowardHolidayCheckBox.AutoSize = true;
            this.TowardHolidayCheckBox.Location = new System.Drawing.Point(360, 176);
            this.TowardHolidayCheckBox.Name = "TowardHolidayCheckBox";
            this.TowardHolidayCheckBox.Size = new System.Drawing.Size(15, 14);
            this.TowardHolidayCheckBox.TabIndex = 27;
            this.TowardHolidayCheckBox.UseVisualStyleBackColor = true;
            // 
            // TowardOTCheckBox
            // 
            this.TowardOTCheckBox.AutoSize = true;
            this.TowardOTCheckBox.Location = new System.Drawing.Point(360, 149);
            this.TowardOTCheckBox.Name = "TowardOTCheckBox";
            this.TowardOTCheckBox.Size = new System.Drawing.Size(15, 14);
            this.TowardOTCheckBox.TabIndex = 26;
            this.TowardOTCheckBox.UseVisualStyleBackColor = true;
            // 
            // DayAfterCheckBox
            // 
            this.DayAfterCheckBox.AutoSize = true;
            this.DayAfterCheckBox.Location = new System.Drawing.Point(360, 123);
            this.DayAfterCheckBox.Name = "DayAfterCheckBox";
            this.DayAfterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DayAfterCheckBox.TabIndex = 25;
            this.DayAfterCheckBox.UseVisualStyleBackColor = true;
            // 
            // DayBeforeCheckBox
            // 
            this.DayBeforeCheckBox.AutoSize = true;
            this.DayBeforeCheckBox.Location = new System.Drawing.Point(361, 97);
            this.DayBeforeCheckBox.Name = "DayBeforeCheckBox";
            this.DayBeforeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DayBeforeCheckBox.TabIndex = 24;
            this.DayBeforeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Holiday Comment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Count Toward Holiday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Count Toward OT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Apply Exp Rate";
            // 
            // ProbationMonthsTextBox
            // 
            this.ProbationMonthsTextBox.Location = new System.Drawing.Point(120, 175);
            this.ProbationMonthsTextBox.Name = "ProbationMonthsTextBox";
            this.ProbationMonthsTextBox.Size = new System.Drawing.Size(114, 20);
            this.ProbationMonthsTextBox.TabIndex = 14;
            // 
            // ProbationDaysTextBox
            // 
            this.ProbationDaysTextBox.Location = new System.Drawing.Point(120, 149);
            this.ProbationDaysTextBox.Name = "ProbationDaysTextBox";
            this.ProbationDaysTextBox.Size = new System.Drawing.Size(114, 20);
            this.ProbationDaysTextBox.TabIndex = 13;
            // 
            // FutureDaysTextBox
            // 
            this.FutureDaysTextBox.Location = new System.Drawing.Point(120, 123);
            this.FutureDaysTextBox.Name = "FutureDaysTextBox";
            this.FutureDaysTextBox.Size = new System.Drawing.Size(114, 20);
            this.FutureDaysTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Day After Required";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Day Before Required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Probation Months";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Probation Days";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(119, 97);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(114, 20);
            this.HoursTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Days in future";
            // 
            // HolidayCommentTextBox
            // 
            this.HolidayCommentTextBox.Location = new System.Drawing.Point(120, 71);
            this.HolidayCommentTextBox.Name = "HolidayCommentTextBox";
            this.HolidayCommentTextBox.Size = new System.Drawing.Size(255, 20);
            this.HolidayCommentTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 30;
            // 
            // HolidayPayCodeTextBox
            // 
            this.HolidayPayCodeTextBox.Location = new System.Drawing.Point(120, 45);
            this.HolidayPayCodeTextBox.Name = "HolidayPayCodeTextBox";
            this.HolidayPayCodeTextBox.Size = new System.Drawing.Size(255, 20);
            this.HolidayPayCodeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Holiday Pay Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pay Policy Name";
            // 
            // PayPolicyNameTextBox
            // 
            this.PayPolicyNameTextBox.Location = new System.Drawing.Point(120, 19);
            this.PayPolicyNameTextBox.Name = "PayPolicyNameTextBox";
            this.PayPolicyNameTextBox.Size = new System.Drawing.Size(255, 20);
            this.PayPolicyNameTextBox.TabIndex = 0;
            // 
            // HolidayEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(855, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HolidayEngineComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HolidayEngine";
            this.Text = "HolidayEngine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox HolidayEngineComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FutureDaysTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HolidayCommentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HolidayPayCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PayPolicyNameTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ProbationMonthsTextBox;
        private System.Windows.Forms.TextBox ProbationDaysTextBox;
        private System.Windows.Forms.CheckBox TowardHolidayCheckBox;
        private System.Windows.Forms.CheckBox TowardOTCheckBox;
        private System.Windows.Forms.CheckBox DayAfterCheckBox;
        private System.Windows.Forms.CheckBox DayBeforeCheckBox;
        private System.Windows.Forms.CheckBox ApplyRateCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ExceptionsTextBox;
        private System.Windows.Forms.Label label14;
    }
}