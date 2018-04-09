namespace Stored_Procedure_Manager
{
    partial class Tools
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
            this.TableButton = new System.Windows.Forms.Button();
            this.SPButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SQLUtilitiesButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TableButton
            // 
            this.TableButton.Location = new System.Drawing.Point(533, 66);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(144, 53);
            this.TableButton.TabIndex = 0;
            this.TableButton.Text = "Create Table";
            this.TableButton.UseVisualStyleBackColor = true;
            // 
            // SPButton
            // 
            this.SPButton.Location = new System.Drawing.Point(533, 144);
            this.SPButton.Name = "SPButton";
            this.SPButton.Size = new System.Drawing.Size(144, 53);
            this.SPButton.TabIndex = 1;
            this.SPButton.Text = " Create Stored Procedure";
            this.SPButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create the table that is needed to stored the configuration for the application. " +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "This table will be created within the database that is populated in the Database " +
    "Connection.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Create the Stored Procedure that is needed to process data for the application";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "This table will be created within the database that is populated in the Database " +
    "Connection.";
            // 
            // SQLUtilitiesButton
            // 
            this.SQLUtilitiesButton.Location = new System.Drawing.Point(533, 222);
            this.SQLUtilitiesButton.Name = "SQLUtilitiesButton";
            this.SQLUtilitiesButton.Size = new System.Drawing.Size(144, 53);
            this.SQLUtilitiesButton.TabIndex = 6;
            this.SQLUtilitiesButton.Text = "Install SQL Utilities";
            this.SQLUtilitiesButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Install the needed tools to communicate with the database.";
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 383);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SQLUtilitiesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SPButton);
            this.Controls.Add(this.TableButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tools";
            this.Text = "Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button SPButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SQLUtilitiesButton;
        private System.Windows.Forms.Label label5;
    }
}