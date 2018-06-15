namespace Stored_Procedure_Manager
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panelSlice = new System.Windows.Forms.Panel();
            this.logopanel = new System.Windows.Forms.Panel();
            this.HomeBorderPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbconnectbutton = new System.Windows.Forms.Button();
            this.buttonconfigbutton = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.sidepanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(122)))));
            this.sidepanel.Controls.Add(this.panelSlice);
            this.sidepanel.Controls.Add(this.logopanel);
            this.sidepanel.Controls.Add(this.panel4);
            this.sidepanel.Controls.Add(this.panel3);
            this.sidepanel.Controls.Add(this.toolsButton);
            this.sidepanel.Controls.Add(this.panel2);
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Controls.Add(this.dbconnectbutton);
            this.sidepanel.Controls.Add(this.buttonconfigbutton);
            this.sidepanel.Controls.Add(this.homebutton);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(250, 468);
            this.sidepanel.TabIndex = 0;
            // 
            // panelSlice
            // 
            this.panelSlice.BackColor = System.Drawing.Color.DimGray;
            this.panelSlice.Location = new System.Drawing.Point(239, 99);
            this.panelSlice.Name = "panelSlice";
            this.panelSlice.Size = new System.Drawing.Size(11, 55);
            this.panelSlice.TabIndex = 12;
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.Color.Transparent;
            this.logopanel.BackgroundImage = global::Stored_Procedure_Manager.Properties.Resources.Sierra_WS_250_83;
            this.logopanel.Controls.Add(this.HomeBorderPanel);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(250, 83);
            this.logopanel.TabIndex = 0;
            // 
            // HomeBorderPanel
            // 
            this.HomeBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeBorderPanel.Name = "HomeBorderPanel";
            this.HomeBorderPanel.Size = new System.Drawing.Size(250, 83);
            this.HomeBorderPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Stored_Procedure_Manager.Properties.Resources.Clocks_60_55;
            this.panel4.Location = new System.Drawing.Point(12, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 55);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Stored_Procedure_Manager.Properties.Resources.TerminalsConfiguration_60_53;
            this.panel3.Location = new System.Drawing.Point(12, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 55);
            this.panel3.TabIndex = 10;
            // 
            // toolsButton
            // 
            this.toolsButton.FlatAppearance.BorderSize = 0;
            this.toolsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.toolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolsButton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsButton.Location = new System.Drawing.Point(81, 305);
            this.toolsButton.Name = "toolsButton";
            this.toolsButton.Size = new System.Drawing.Size(166, 55);
            this.toolsButton.TabIndex = 9;
            this.toolsButton.Text = "Tools";
            this.toolsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolsButton.UseVisualStyleBackColor = true;
            this.toolsButton.Click += new System.EventHandler(this.ToolsButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Stored_Procedure_Manager.Properties.Resources.DBConnectionManager_60_55;
            this.panel2.Location = new System.Drawing.Point(12, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 55);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Stored_Procedure_Manager.Properties.Resources.ConfigurationCenter_60_55;
            this.panel1.Location = new System.Drawing.Point(12, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 55);
            this.panel1.TabIndex = 7;
            // 
            // dbconnectbutton
            // 
            this.dbconnectbutton.FlatAppearance.BorderSize = 0;
            this.dbconnectbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.dbconnectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbconnectbutton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbconnectbutton.Location = new System.Drawing.Point(81, 234);
            this.dbconnectbutton.Name = "dbconnectbutton";
            this.dbconnectbutton.Size = new System.Drawing.Size(166, 55);
            this.dbconnectbutton.TabIndex = 4;
            this.dbconnectbutton.Text = "Database Connection";
            this.dbconnectbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dbconnectbutton.UseVisualStyleBackColor = true;
            this.dbconnectbutton.Click += new System.EventHandler(this.DBConnectButton_Click);
            // 
            // buttonconfigbutton
            // 
            this.buttonconfigbutton.FlatAppearance.BorderSize = 0;
            this.buttonconfigbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.buttonconfigbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonconfigbutton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconfigbutton.Location = new System.Drawing.Point(81, 163);
            this.buttonconfigbutton.Name = "buttonconfigbutton";
            this.buttonconfigbutton.Size = new System.Drawing.Size(166, 55);
            this.buttonconfigbutton.TabIndex = 3;
            this.buttonconfigbutton.Text = "Button Configuration";
            this.buttonconfigbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonconfigbutton.UseVisualStyleBackColor = true;
            this.buttonconfigbutton.Click += new System.EventHandler(this.ButtonConfigButton_Click);
            // 
            // homebutton
            // 
            this.homebutton.FlatAppearance.BorderSize = 0;
            this.homebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebutton.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebutton.Location = new System.Drawing.Point(81, 99);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(166, 55);
            this.homebutton.TabIndex = 2;
            this.homebutton.Text = "Home";
            this.homebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.SystemColors.Control;
            this.container.BackgroundImage = global::Stored_Procedure_Manager.Properties.Resources.Body_Graphic_855x385_v2;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(250, 83);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(855, 385);
            this.container.TabIndex = 2;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerpanel.BackgroundImage = global::Stored_Procedure_Manager.Properties.Resources.Header_Graphic_855x83_v3;
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(250, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(855, 83);
            this.headerpanel.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 468);
            this.Controls.Add(this.container);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.sidepanel.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Button dbconnectbutton;
        private System.Windows.Forms.Button buttonconfigbutton;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button toolsButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel HomeBorderPanel;
        private System.Windows.Forms.Panel panelSlice;
    }
}