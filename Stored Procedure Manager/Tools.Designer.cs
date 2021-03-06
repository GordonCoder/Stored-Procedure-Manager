﻿namespace Stored_Procedure_Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools));
            this.CreateTableLabel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateSPLabel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SQLUtilitieslabel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SPButton = new System.Windows.Forms.Button();
            this.SQLUtilitiesButton = new System.Windows.Forms.Button();
            this.TableButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WaitTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxTools = new System.Windows.Forms.PictureBox();
            this.CreateTableLabel.SuspendLayout();
            this.CreateSPLabel.SuspendLayout();
            this.SQLUtilitieslabel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTools)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateTableLabel
            // 
            this.CreateTableLabel.Controls.Add(this.label2);
            this.CreateTableLabel.Controls.Add(this.label1);
            this.CreateTableLabel.ForeColor = System.Drawing.Color.Black;
            this.CreateTableLabel.Location = new System.Drawing.Point(182, 15);
            this.CreateTableLabel.Name = "CreateTableLabel";
            this.CreateTableLabel.Size = new System.Drawing.Size(523, 64);
            this.CreateTableLabel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create the table that is needed to stored the configuration for the application. " +
    "This table will be created within the database that is populated in the Database" +
    " Connection.";
            // 
            // CreateSPLabel
            // 
            this.CreateSPLabel.BackColor = System.Drawing.Color.White;
            this.CreateSPLabel.Controls.Add(this.label7);
            this.CreateSPLabel.Controls.Add(this.label3);
            this.CreateSPLabel.Controls.Add(this.label4);
            this.CreateSPLabel.ForeColor = System.Drawing.Color.Black;
            this.CreateSPLabel.Location = new System.Drawing.Point(182, 85);
            this.CreateSPLabel.Name = "CreateSPLabel";
            this.CreateSPLabel.Size = new System.Drawing.Size(523, 64);
            this.CreateSPLabel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(523, 64);
            this.label7.TabIndex = 2;
            this.label7.Text = "Create the Stored Procedure that is needed to process data for the application.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 64);
            this.label3.TabIndex = 1;
            this.label3.Text = "Create the Stored Procedure that is needed to process data for the application. T" +
    "his table will be created within the database that is populated in the Database " +
    "Connection.";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(523, 64);
            this.label4.TabIndex = 0;
            this.label4.Text = "Create the table that is needed to stored the configuration for the application. " +
    "This table will be created within the database that is populated in the Database" +
    " Connection.";
            // 
            // SQLUtilitieslabel
            // 
            this.SQLUtilitieslabel.Controls.Add(this.label5);
            this.SQLUtilitieslabel.Controls.Add(this.label6);
            this.SQLUtilitieslabel.Location = new System.Drawing.Point(182, 225);
            this.SQLUtilitieslabel.Name = "SQLUtilitieslabel";
            this.SQLUtilitieslabel.Size = new System.Drawing.Size(523, 64);
            this.SQLUtilitieslabel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(523, 64);
            this.label5.TabIndex = 1;
            this.label5.Text = "Install the needed tools to communicate with the database.";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(523, 64);
            this.label6.TabIndex = 0;
            this.label6.Text = "Create the table that is needed to stored the configuration for the application. " +
    "This table will be created within the database that is populated in the Database" +
    " Connection.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(182, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 64);
            this.panel2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(523, 64);
            this.label8.TabIndex = 2;
            this.label8.Text = "Test to make sure you are able to execute the Stored Procedure as well as enter d" +
    "ata into the table. This test wont run until it can see that you have created th" +
    "e database and stored procedure first.";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(523, 64);
            this.label9.TabIndex = 1;
            this.label9.Text = "Create the Stored Procedure that is needed to process data for the application. T" +
    "his table will be created within the database that is populated in the Database " +
    "Connection.";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(523, 64);
            this.label10.TabIndex = 0;
            this.label10.Text = "Create the table that is needed to stored the configuration for the application. " +
    "This table will be created within the database that is populated in the Database" +
    " Connection.";
            // 
            // SPButton
            // 
            this.SPButton.BackColor = System.Drawing.Color.White;
            this.SPButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.SPButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SPButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPButton.Location = new System.Drawing.Point(3, 73);
            this.SPButton.Name = "SPButton";
            this.SPButton.Size = new System.Drawing.Size(154, 64);
            this.SPButton.TabIndex = 1;
            this.SPButton.Text = " Create Stored Procedure";
            this.SPButton.UseVisualStyleBackColor = false;
            this.SPButton.Click += new System.EventHandler(this.SPButton_Click);
            // 
            // SQLUtilitiesButton
            // 
            this.SQLUtilitiesButton.BackColor = System.Drawing.Color.White;
            this.SQLUtilitiesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.SQLUtilitiesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SQLUtilitiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SQLUtilitiesButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLUtilitiesButton.Location = new System.Drawing.Point(3, 213);
            this.SQLUtilitiesButton.Name = "SQLUtilitiesButton";
            this.SQLUtilitiesButton.Size = new System.Drawing.Size(154, 64);
            this.SQLUtilitiesButton.TabIndex = 6;
            this.SQLUtilitiesButton.Text = "Install SQL Utilities";
            this.SQLUtilitiesButton.UseVisualStyleBackColor = false;
            this.SQLUtilitiesButton.Click += new System.EventHandler(this.SQLUtilitiesButton_Click);
            // 
            // TableButton
            // 
            this.TableButton.BackColor = System.Drawing.Color.White;
            this.TableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.TableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.TableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableButton.Location = new System.Drawing.Point(3, 3);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(154, 64);
            this.TableButton.TabIndex = 0;
            this.TableButton.Text = "Create Database";
            this.TableButton.UseVisualStyleBackColor = false;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.White;
            this.testButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.testButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.Location = new System.Drawing.Point(3, 143);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(154, 64);
            this.testButton.TabIndex = 7;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.testButton);
            this.panel1.Controls.Add(this.TableButton);
            this.panel1.Controls.Add(this.SQLUtilitiesButton);
            this.panel1.Controls.Add(this.SPButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 286);
            this.panel1.TabIndex = 7;
            // 
            // WaitTimer
            // 
            this.WaitTimer.Enabled = true;
            this.WaitTimer.Tick += new System.EventHandler(this.WaitTimer_Tick);
            // 
            // pictureBoxTools
            // 
            this.pictureBoxTools.Location = new System.Drawing.Point(241, 292);
            this.pictureBoxTools.Name = "pictureBoxTools";
            this.pictureBoxTools.Size = new System.Drawing.Size(375, 80);
            this.pictureBoxTools.TabIndex = 11;
            this.pictureBoxTools.TabStop = false;
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(855, 385);
            this.Controls.Add(this.pictureBoxTools);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SQLUtilitieslabel);
            this.Controls.Add(this.CreateSPLabel);
            this.Controls.Add(this.CreateTableLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tools";
            this.Text = "7";
            this.Load += new System.EventHandler(this.Tools_Load);
            this.CreateTableLabel.ResumeLayout(false);
            this.CreateSPLabel.ResumeLayout(false);
            this.SQLUtilitieslabel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTools)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel CreateTableLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel CreateSPLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SQLUtilitieslabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SPButton;
        private System.Windows.Forms.Button SQLUtilitiesButton;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer WaitTimer;
        private System.Windows.Forms.PictureBox pictureBoxTools;
    }
}