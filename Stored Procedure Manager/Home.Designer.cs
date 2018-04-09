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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbconnectbutton = new System.Windows.Forms.Button();
            this.buttonconfigbutton = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.logopanel = new System.Windows.Forms.Panel();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.sidepanel.SuspendLayout();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(122)))));
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Controls.Add(this.dbconnectbutton);
            this.sidepanel.Controls.Add(this.buttonconfigbutton);
            this.sidepanel.Controls.Add(this.homebutton);
            this.sidepanel.Controls.Add(this.logopanel);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(250, 466);
            this.sidepanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 83);
            this.panel1.TabIndex = 6;
            // 
            // dbconnectbutton
            // 
            this.dbconnectbutton.FlatAppearance.BorderSize = 0;
            this.dbconnectbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.dbconnectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbconnectbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dbconnectbutton.Location = new System.Drawing.Point(-3, 219);
            this.dbconnectbutton.Name = "dbconnectbutton";
            this.dbconnectbutton.Size = new System.Drawing.Size(250, 48);
            this.dbconnectbutton.TabIndex = 4;
            this.dbconnectbutton.Text = "Database Connection";
            this.dbconnectbutton.UseVisualStyleBackColor = true;
            this.dbconnectbutton.Click += new System.EventHandler(this.dbconnectbutton_Click);
            // 
            // buttonconfigbutton
            // 
            this.buttonconfigbutton.FlatAppearance.BorderSize = 0;
            this.buttonconfigbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.buttonconfigbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonconfigbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonconfigbutton.Location = new System.Drawing.Point(-3, 159);
            this.buttonconfigbutton.Name = "buttonconfigbutton";
            this.buttonconfigbutton.Size = new System.Drawing.Size(250, 48);
            this.buttonconfigbutton.TabIndex = 3;
            this.buttonconfigbutton.Text = "Button Configuration";
            this.buttonconfigbutton.UseVisualStyleBackColor = true;
            this.buttonconfigbutton.Click += new System.EventHandler(this.buttonconfigbutton_Click);
            // 
            // homebutton
            // 
            this.homebutton.FlatAppearance.BorderSize = 0;
            this.homebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebutton.Location = new System.Drawing.Point(-3, 99);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(250, 48);
            this.homebutton.TabIndex = 2;
            this.homebutton.Text = "Home";
            this.homebutton.UseVisualStyleBackColor = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // logopanel
            // 
            this.logopanel.BackgroundImage = global::Stored_Procedure_Manager.Properties.Resources.Sierra_WS_250_83;
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(250, 83);
            this.logopanel.TabIndex = 0;
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.White;
            this.headerpanel.Controls.Add(this.CloseButton);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(250, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(713, 83);
            this.headerpanel.TabIndex = 1;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(250, 83);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(713, 383);
            this.container.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(658, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(43, 48);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 466);
            this.Controls.Add(this.container);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.sidepanel.ResumeLayout(false);
            this.headerpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dbconnectbutton;
        private System.Windows.Forms.Button buttonconfigbutton;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button CloseButton;
    }
}