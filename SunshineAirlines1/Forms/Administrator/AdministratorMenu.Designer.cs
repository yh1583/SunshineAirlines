namespace SunshineAirlines1.Forms.Administrator
{
    partial class AdministratorMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_searchFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_foodServices = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_FlightStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_searchFlight,
            this.btn_foodServices,
            this.btn_FlightStatus,
            this.btn_Logout,
            this.btn_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_searchFlight
            // 
            this.btn_searchFlight.Name = "btn_searchFlight";
            this.btn_searchFlight.Size = new System.Drawing.Size(188, 21);
            this.btn_searchFlight.Text = "Flight Schedule Management";
            this.btn_searchFlight.Click += new System.EventHandler(this.btn_searchFlight_Click);
            // 
            // btn_foodServices
            // 
            this.btn_foodServices.Name = "btn_foodServices";
            this.btn_foodServices.Size = new System.Drawing.Size(109, 21);
            this.btn_foodServices.Text = "Ticket Statistice";
            this.btn_foodServices.Click += new System.EventHandler(this.btn_foodServices_Click);
            // 
            // btn_FlightStatus
            // 
            this.btn_FlightStatus.Name = "btn_FlightStatus";
            this.btn_FlightStatus.Size = new System.Drawing.Size(128, 21);
            this.btn_FlightStatus.Text = "User Management";
            this.btn_FlightStatus.Click += new System.EventHandler(this.btn_FlightStatus_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(61, 21);
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(40, 21);
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // AdministratorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 768);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "AdministratorMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_searchFlight;
        private System.Windows.Forms.ToolStripMenuItem btn_foodServices;
        private System.Windows.Forms.ToolStripMenuItem btn_FlightStatus;
        private System.Windows.Forms.ToolStripMenuItem btn_Logout;
        private System.Windows.Forms.ToolStripMenuItem btn_Exit;
    }
}