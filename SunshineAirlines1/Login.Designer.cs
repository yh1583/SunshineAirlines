namespace SunshineAirlines1
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pic_background = new System.Windows.Forms.PictureBox();
            this.btn_showVC = new System.Windows.Forms.Button();
            this.cbx_autoLogin = new System.Windows.Forms.CheckBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_inputVC = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_VC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_background)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_background
            // 
            this.pic_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_background.Image = global::SunshineAirlines1.Properties.Resources.SunshineAirlinesBackgroundByLogin;
            this.pic_background.Location = new System.Drawing.Point(0, 0);
            this.pic_background.Name = "pic_background";
            this.pic_background.Size = new System.Drawing.Size(684, 361);
            this.pic_background.TabIndex = 0;
            this.pic_background.TabStop = false;
            // 
            // btn_showVC
            // 
            this.btn_showVC.Location = new System.Drawing.Point(378, 218);
            this.btn_showVC.Name = "btn_showVC";
            this.btn_showVC.Size = new System.Drawing.Size(57, 22);
            this.btn_showVC.TabIndex = 23;
            this.btn_showVC.UseVisualStyleBackColor = true;
            this.btn_showVC.Visible = false;
            this.btn_showVC.Click += new System.EventHandler(this.btn_showVC_Click);
            // 
            // cbx_autoLogin
            // 
            this.cbx_autoLogin.AutoSize = true;
            this.cbx_autoLogin.BackColor = System.Drawing.Color.Transparent;
            this.cbx_autoLogin.ForeColor = System.Drawing.Color.White;
            this.cbx_autoLogin.Location = new System.Drawing.Point(272, 269);
            this.cbx_autoLogin.Name = "cbx_autoLogin";
            this.cbx_autoLogin.Size = new System.Drawing.Size(144, 16);
            this.cbx_autoLogin.TabIndex = 22;
            this.cbx_autoLogin.Text = "Auto login in 7 days";
            this.cbx_autoLogin.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::SunshineAirlines1.Properties.Resources.Close;
            this.btn_close.Location = new System.Drawing.Point(633, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(51, 42);
            this.btn_close.TabIndex = 21;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Location = new System.Drawing.Point(211, 307);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(264, 23);
            this.btn_login.TabIndex = 20;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_inputVC
            // 
            this.txt_inputVC.Location = new System.Drawing.Point(272, 219);
            this.txt_inputVC.Name = "txt_inputVC";
            this.txt_inputVC.Size = new System.Drawing.Size(100, 21);
            this.txt_inputVC.TabIndex = 19;
            this.txt_inputVC.Visible = false;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(272, 182);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(163, 21);
            this.txt_pwd.TabIndex = 18;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(272, 142);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(163, 21);
            this.txt_email.TabIndex = 17;
            // 
            // lbl_VC
            // 
            this.lbl_VC.BackColor = System.Drawing.Color.Transparent;
            this.lbl_VC.Font = new System.Drawing.Font("宋体", 14F);
            this.lbl_VC.ForeColor = System.Drawing.Color.White;
            this.lbl_VC.Location = new System.Drawing.Point(96, 219);
            this.lbl_VC.Name = "lbl_VC";
            this.lbl_VC.Size = new System.Drawing.Size(169, 19);
            this.lbl_VC.TabIndex = 16;
            this.lbl_VC.Text = "Verifcation code";
            this.lbl_VC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_VC.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(177, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "The system can be logged in through email and password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Login";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btn_showVC);
            this.Controls.Add(this.cbx_autoLogin);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_inputVC);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_VC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_background;
        private System.Windows.Forms.Button btn_showVC;
        private System.Windows.Forms.CheckBox cbx_autoLogin;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_inputVC;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_VC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

