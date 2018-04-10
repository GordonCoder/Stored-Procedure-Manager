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
            this.SQLUtilitiesButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateTableLabel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateSPLabel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SQLUtilitieslabel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.CreateTableLabel.SuspendLayout();
            this.CreateSPLabel.SuspendLayout();
            this.SQLUtilitieslabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableButton
            // 
            this.TableButton.Location = new System.Drawing.Point(3, 27);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(154, 53);
            this.TableButton.TabIndex = 0;
            this.TableButton.Text = "Create Table";
            this.TableButton.UseVisualStyleBackColor = true;
            // 
            // SPButton
            // 
            this.SPButton.Location = new System.Drawing.Point(3, 151);
            this.SPButton.Name = "SPButton";
            this.SPButton.Size = new System.Drawing.Size(154, 53);
            this.SPButton.TabIndex = 1;
            this.SPButton.Text = " Create Stored Procedure";
            this.SPButton.UseVisualStyleBackColor = true;
            // 
            // SQLUtilitiesButton
            // 
            this.SQLUtilitiesButton.Location = new System.Drawing.Point(3, 275);
            this.SQLUtilitiesButton.Name = "SQLUtilitiesButton";
            this.SQLUtilitiesButton.Size = new System.Drawing.Size(154, 53);
            this.SQLUtilitiesButton.TabIndex = 6;
            this.SQLUtilitiesButton.Text = "Install SQL Utilities";
            this.SQLUtilitiesButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TableButton);
            this.panel1.Controls.Add(this.SQLUtilitiesButton);
            this.panel1.Controls.Add(this.SPButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 359);
            this.panel1.TabIndex = 7;
            // 
            // CreateTableLabel
            // 
            this.CreateTableLabel.Controls.Add(this.label2);
            this.CreateTableLabel.Controls.Add(this.label1);
            this.CreateTableLabel.Location = new System.Drawing.Point(178, 39);
            this.CreateTableLabel.Name = "CreateTableLabel";
            this.CreateTableLabel.Size = new System.Drawing.Size(523, 64);
            this.CreateTableLabel.TabIndex = 8;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create the table that is needed to stored the configuration for the application. " +
    "This table will be created within the database that is populated in the Database" +
    " Connection.";
            // 
            // CreateSPLabel
            // 
            this.CreateSPLabel.Controls.Add(this.label3);
            this.CreateSPLabel.Controls.Add(this.label4);
            this.CreateSPLabel.Location = new System.Drawing.Point(178, 160);
            this.CreateSPLabel.Name = "CreateSPLabel";
            this.CreateSPLabel.Size = new System.Drawing.Size(523, 64);
            this.CreateSPLabel.TabIndex = 9;
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
            this.SQLUtilitieslabel.Location = new System.Drawing.Point(178, 288);
            this.SQLUtilitieslabel.Name = "SQLUtilitieslabel";
            this.SQLUtilitieslabel.Size = new System.Drawing.Size(523, 64);
            this.SQLUtilitieslabel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 383);
            this.Controls.Add(this.SQLUtilitieslabel);
            this.Controls.Add(this.CreateSPLabel);
            this.Controls.Add(this.CreateTableLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tools";
            this.Text = "Tools";
            this.panel1.ResumeLayout(false);
            this.CreateTableLabel.ResumeLayout(false);
            this.CreateSPLabel.ResumeLayout(false);
            this.SQLUtilitieslabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button SPButton;
        private System.Windows.Forms.Button SQLUtilitiesButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel CreateTableLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel CreateSPLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SQLUtilitieslabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}