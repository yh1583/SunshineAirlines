namespace SunshineAirlines1
{
    partial class FrmSplashScreen
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
            this.pan_progressbarContainer = new System.Windows.Forms.Panel();
            this.pan_progressbar = new System.Windows.Forms.Panel();
            this.timer_progressbar = new System.Windows.Forms.Timer(this.components);
            this.pic_background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_background)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_progressbarContainer
            // 
            this.pan_progressbarContainer.BackColor = System.Drawing.Color.SteelBlue;
            this.pan_progressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_progressbarContainer.Location = new System.Drawing.Point(0, 385);
            this.pan_progressbarContainer.Name = "pan_progressbarContainer";
            this.pan_progressbarContainer.Size = new System.Drawing.Size(700, 15);
            this.pan_progressbarContainer.TabIndex = 1;
            // 
            // pan_progressbar
            // 
            this.pan_progressbar.BackColor = System.Drawing.Color.Orange;
            this.pan_progressbar.Location = new System.Drawing.Point(0, 385);
            this.pan_progressbar.Name = "pan_progressbar";
            this.pan_progressbar.Size = new System.Drawing.Size(25, 15);
            this.pan_progressbar.TabIndex = 2;
            // 
            // timer_progressbar
            // 
            this.timer_progressbar.Enabled = true;
            this.timer_progressbar.Interval = 30;
            this.timer_progressbar.Tick += new System.EventHandler(this.timer_progressbar_Tick);
            // 
            // pic_background
            // 
            this.pic_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_background.Image = global::SunshineAirlines1.Properties.Resources.SunshineAirlinesBackground;
            this.pic_background.Location = new System.Drawing.Point(0, 0);
            this.pic_background.Name = "pic_background";
            this.pic_background.Size = new System.Drawing.Size(700, 400);
            this.pic_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_background.TabIndex = 0;
            this.pic_background.TabStop = false;
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.pan_progressbar);
            this.Controls.Add(this.pan_progressbarContainer);
            this.Controls.Add(this.pic_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pic_background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_background;
        private System.Windows.Forms.Panel pan_progressbarContainer;
        private System.Windows.Forms.Panel pan_progressbar;
        private System.Windows.Forms.Timer timer_progressbar;
    }
}