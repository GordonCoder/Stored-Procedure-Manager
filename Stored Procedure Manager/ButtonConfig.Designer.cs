namespace Stored_Procedure_Manager
{
    partial class ButtonConfig
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
            this.ButtonConfigComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NotesButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExeCheckBox = new System.Windows.Forms.CheckBox();
            this.ExeParamTextBox = new System.Windows.Forms.TextBox();
            this.ExePathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ParamInputTextBox5 = new System.Windows.Forms.TextBox();
            this.ParamNameTextBox5 = new System.Windows.Forms.TextBox();
            this.ParamInputTextBox4 = new System.Windows.Forms.TextBox();
            this.ParamNameTextBox4 = new System.Windows.Forms.TextBox();
            this.ParamInputTextBox3 = new System.Windows.Forms.TextBox();
            this.ParamNameTextBox3 = new System.Windows.Forms.TextBox();
            this.ParamInputTextBox2 = new System.Windows.Forms.TextBox();
            this.ParamNameTextBox2 = new System.Windows.Forms.TextBox();
            this.ParamInputTextBox1 = new System.Windows.Forms.TextBox();
            this.ParamNameTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonNameTextBox = new System.Windows.Forms.TextBox();
            this.SPNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonConfigComboBox
            // 
            this.ButtonConfigComboBox.FormattingEnabled = true;
            this.ButtonConfigComboBox.Location = new System.Drawing.Point(12, 12);
            this.ButtonConfigComboBox.Name = "ButtonConfigComboBox";
            this.ButtonConfigComboBox.Size = new System.Drawing.Size(328, 21);
            this.ButtonConfigComboBox.TabIndex = 0;
            this.ButtonConfigComboBox.SelectedIndexChanged += new System.EventHandler(this.ButtonConfigComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of Button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of Stored Procedure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parameter Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parameter Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Path to Executable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Parameter Input";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NotesButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.InfoTextBox);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 342);
            this.panel1.TabIndex = 7;
            // 
            // NotesButton
            // 
            this.NotesButton.Location = new System.Drawing.Point(601, 313);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Size = new System.Drawing.Size(75, 23);
            this.NotesButton.TabIndex = 8;
            this.NotesButton.Text = "Notes";
            this.NotesButton.UseVisualStyleBackColor = true;
            this.NotesButton.Click += new System.EventHandler(this.NotesButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(753, 313);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(601, 8);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(227, 251);
            this.InfoTextBox.TabIndex = 6;
            this.InfoTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.ExeCheckBox);
            this.groupBox3.Controls.Add(this.ExeParamTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ExePathTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(3, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 74);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "      Executable to launch after the Stored Procedure has run";
            // 
            // ExeCheckBox
            // 
            this.ExeCheckBox.AutoSize = true;
            this.ExeCheckBox.Location = new System.Drawing.Point(11, 0);
            this.ExeCheckBox.Name = "ExeCheckBox";
            this.ExeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ExeCheckBox.TabIndex = 7;
            this.ExeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExeParamTextBox
            // 
            this.ExeParamTextBox.Location = new System.Drawing.Point(175, 45);
            this.ExeParamTextBox.Name = "ExeParamTextBox";
            this.ExeParamTextBox.Size = new System.Drawing.Size(411, 20);
            this.ExeParamTextBox.TabIndex = 6;
            // 
            // ExePathTextBox
            // 
            this.ExePathTextBox.Location = new System.Drawing.Point(175, 19);
            this.ExePathTextBox.Name = "ExePathTextBox";
            this.ExePathTextBox.Size = new System.Drawing.Size(411, 20);
            this.ExePathTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ParamInputTextBox5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ParamNameTextBox5);
            this.groupBox2.Controls.Add(this.ParamInputTextBox4);
            this.groupBox2.Controls.Add(this.ParamNameTextBox4);
            this.groupBox2.Controls.Add(this.ParamInputTextBox3);
            this.groupBox2.Controls.Add(this.ParamNameTextBox3);
            this.groupBox2.Controls.Add(this.ParamInputTextBox2);
            this.groupBox2.Controls.Add(this.ParamNameTextBox2);
            this.groupBox2.Controls.Add(this.ParamInputTextBox1);
            this.groupBox2.Controls.Add(this.ParamNameTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(3, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 174);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters Information";
            // 
            // ParamInputTextBox5
            // 
            this.ParamInputTextBox5.Location = new System.Drawing.Point(175, 148);
            this.ParamInputTextBox5.Name = "ParamInputTextBox5";
            this.ParamInputTextBox5.Size = new System.Drawing.Size(411, 20);
            this.ParamInputTextBox5.TabIndex = 9;
            // 
            // ParamNameTextBox5
            // 
            this.ParamNameTextBox5.Location = new System.Drawing.Point(10, 148);
            this.ParamNameTextBox5.Name = "ParamNameTextBox5";
            this.ParamNameTextBox5.Size = new System.Drawing.Size(159, 20);
            this.ParamNameTextBox5.TabIndex = 8;
            // 
            // ParamInputTextBox4
            // 
            this.ParamInputTextBox4.Location = new System.Drawing.Point(175, 121);
            this.ParamInputTextBox4.Name = "ParamInputTextBox4";
            this.ParamInputTextBox4.Size = new System.Drawing.Size(411, 20);
            this.ParamInputTextBox4.TabIndex = 7;
            // 
            // ParamNameTextBox4
            // 
            this.ParamNameTextBox4.Location = new System.Drawing.Point(10, 121);
            this.ParamNameTextBox4.Name = "ParamNameTextBox4";
            this.ParamNameTextBox4.Size = new System.Drawing.Size(159, 20);
            this.ParamNameTextBox4.TabIndex = 6;
            // 
            // ParamInputTextBox3
            // 
            this.ParamInputTextBox3.Location = new System.Drawing.Point(175, 94);
            this.ParamInputTextBox3.Name = "ParamInputTextBox3";
            this.ParamInputTextBox3.Size = new System.Drawing.Size(411, 20);
            this.ParamInputTextBox3.TabIndex = 5;
            // 
            // ParamNameTextBox3
            // 
            this.ParamNameTextBox3.Location = new System.Drawing.Point(10, 94);
            this.ParamNameTextBox3.Name = "ParamNameTextBox3";
            this.ParamNameTextBox3.Size = new System.Drawing.Size(159, 20);
            this.ParamNameTextBox3.TabIndex = 4;
            // 
            // ParamInputTextBox2
            // 
            this.ParamInputTextBox2.Location = new System.Drawing.Point(175, 67);
            this.ParamInputTextBox2.Name = "ParamInputTextBox2";
            this.ParamInputTextBox2.Size = new System.Drawing.Size(411, 20);
            this.ParamInputTextBox2.TabIndex = 3;
            // 
            // ParamNameTextBox2
            // 
            this.ParamNameTextBox2.Location = new System.Drawing.Point(10, 67);
            this.ParamNameTextBox2.Name = "ParamNameTextBox2";
            this.ParamNameTextBox2.Size = new System.Drawing.Size(159, 20);
            this.ParamNameTextBox2.TabIndex = 2;
            // 
            // ParamInputTextBox1
            // 
            this.ParamInputTextBox1.Location = new System.Drawing.Point(175, 40);
            this.ParamInputTextBox1.Name = "ParamInputTextBox1";
            this.ParamInputTextBox1.Size = new System.Drawing.Size(411, 20);
            this.ParamInputTextBox1.TabIndex = 1;
            // 
            // ParamNameTextBox1
            // 
            this.ParamNameTextBox1.Location = new System.Drawing.Point(10, 40);
            this.ParamNameTextBox1.Name = "ParamNameTextBox1";
            this.ParamNameTextBox1.Size = new System.Drawing.Size(159, 20);
            this.ParamNameTextBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ButtonNameTextBox);
            this.groupBox1.Controls.Add(this.SPNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Naming";
            // 
            // ButtonNameTextBox
            // 
            this.ButtonNameTextBox.Location = new System.Drawing.Point(145, 19);
            this.ButtonNameTextBox.Name = "ButtonNameTextBox";
            this.ButtonNameTextBox.Size = new System.Drawing.Size(441, 20);
            this.ButtonNameTextBox.TabIndex = 0;
            // 
            // SPNameTextBox
            // 
            this.SPNameTextBox.Location = new System.Drawing.Point(145, 45);
            this.SPNameTextBox.Name = "SPNameTextBox";
            this.SPNameTextBox.Size = new System.Drawing.Size(441, 20);
            this.SPNameTextBox.TabIndex = 2;
            // 
            // ButtonConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(855, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonConfigComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ButtonConfig";
            this.Text = "ButtonConfig";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ButtonNameTextBox;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ExeParamTextBox;
        private System.Windows.Forms.TextBox ExePathTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ParamInputTextBox5;
        private System.Windows.Forms.TextBox ParamNameTextBox5;
        private System.Windows.Forms.TextBox ParamInputTextBox4;
        private System.Windows.Forms.TextBox ParamNameTextBox4;
        private System.Windows.Forms.TextBox ParamInputTextBox3;
        private System.Windows.Forms.TextBox ParamNameTextBox3;
        private System.Windows.Forms.TextBox ParamInputTextBox2;
        private System.Windows.Forms.TextBox ParamNameTextBox2;
        private System.Windows.Forms.TextBox ParamInputTextBox1;
        private System.Windows.Forms.TextBox ParamNameTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SPNameTextBox;
        private System.Windows.Forms.Button NotesButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox ExeCheckBox;
        public System.Windows.Forms.ComboBox ButtonConfigComboBox;
    }
}