namespace Stored_Procedure_Manager
{
    partial class CreateDBLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDBLoading));
            this.CreateDBProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateDBProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CreateDBProgressBar
            // 
            this.CreateDBProgressBar.Location = new System.Drawing.Point(65, 218);
            this.CreateDBProgressBar.Name = "CreateDBProgressBar";
            this.CreateDBProgressBar.Size = new System.Drawing.Size(538, 23);
            this.CreateDBProgressBar.TabIndex = 0;
            this.CreateDBProgressBar.Click += new System.EventHandler(this.CreateDBProgressBar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Automation Database is being created";
            // 
            // CreateDBProgressBarTimer
            // 
            this.CreateDBProgressBarTimer.Tick += new System.EventHandler(this.CreateDBProgressBarTimer_Tick);
            // 
            // CreateDBLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stored_Procedure_Manager.Properties.Resources.Body_Graphic_855x385_v2;
            this.ClientSize = new System.Drawing.Size(856, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateDBProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateDBLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar CreateDBProgressBar;
        public System.Windows.Forms.Timer CreateDBProgressBarTimer;
    }
}