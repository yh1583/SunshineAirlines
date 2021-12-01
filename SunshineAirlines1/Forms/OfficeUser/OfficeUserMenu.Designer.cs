namespace SunshineAirlines1.Forms.OfficeUser
{
    partial class OfficeUserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeUserMenu));
            this.pan_menu = new System.Windows.Forms.Panel();
            this.btn_fold = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_userManagement = new System.Windows.Forms.Button();
            this.btn_ticketStatistics = new System.Windows.Forms.Button();
            this.btn_flightScheduleManagement = new System.Windows.Forms.Button();
            this.btn_flightStatus = new System.Windows.Forms.Button();
            this.btn_foodServices = new System.Windows.Forms.Button();
            this.pan_side = new System.Windows.Forms.Panel();
            this.btn_searchFlight = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.pan_status = new System.Windows.Forms.Panel();
            this.pic_weather = new System.Windows.Forms.PictureBox();
            this.lbl_weather = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_userRoleName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pan_showFrm = new System.Windows.Forms.Panel();
            this.pan_title = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.timer_closefrm = new System.Windows.Forms.Timer(this.components);
            this.timer_refreshSystemDT = new System.Windows.Forms.Timer(this.components);
            this.timer_fold = new System.Windows.Forms.Timer(this.components);
            this.timer_refreshWeather = new System.Windows.Forms.Timer(this.components);
            this.pan_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.pan_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_weather)).BeginInit();
            this.pan_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_menu
            // 
            this.pan_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.pan_menu.Controls.Add(this.btn_fold);
            this.pan_menu.Controls.Add(this.btn_setting);
            this.pan_menu.Controls.Add(this.btn_userManagement);
            this.pan_menu.Controls.Add(this.btn_ticketStatistics);
            this.pan_menu.Controls.Add(this.btn_flightScheduleManagement);
            this.pan_menu.Controls.Add(this.btn_flightStatus);
            this.pan_menu.Controls.Add(this.btn_foodServices);
            this.pan_menu.Controls.Add(this.pan_side);
            this.pan_menu.Controls.Add(this.btn_searchFlight);
            this.pan_menu.Controls.Add(this.pic_Logo);
            this.pan_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_menu.Location = new System.Drawing.Point(0, 0);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Size = new System.Drawing.Size(213, 905);
            this.pan_menu.TabIndex = 3;
            // 
            // btn_fold
            // 
            this.btn_fold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fold.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_fold.FlatAppearance.BorderSize = 0;
            this.btn_fold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fold.Image = global::SunshineAirlines1.Properties.Resources.fold;
            this.btn_fold.Location = new System.Drawing.Point(0, 0);
            this.btn_fold.Name = "btn_fold";
            this.btn_fold.Size = new System.Drawing.Size(213, 33);
            this.btn_fold.TabIndex = 0;
            this.btn_fold.UseVisualStyleBackColor = true;
            this.btn_fold.Click += new System.EventHandler(this.btn_fold_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("TeX Gyre Adventor", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.White;
            this.btn_setting.Image = global::SunshineAirlines1.Properties.Resources.system_setting;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(5, 521);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(208, 63);
            this.btn_setting.TabIndex = 7;
            this.btn_setting.Text = "Settings";
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_userManagement
            // 
            this.btn_userManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userManagement.FlatAppearance.BorderSize = 0;
            this.btn_userManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userManagement.Font = new System.Drawing.Font("TeX Gyre Adventor", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userManagement.ForeColor = System.Drawing.Color.White;
            this.btn_userManagement.Image = global::SunshineAirlines1.Properties.Resources.User_Management;
            this.btn_userManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_userManagement.Location = new System.Drawing.Point(5, 452);
            this.btn_userManagement.Name = "btn_userManagement";
            this.btn_userManagement.Size = new System.Drawing.Size(208, 63);
            this.btn_userManagement.TabIndex = 6;
            this.btn_userManagement.Text = "Users";
            this.btn_userManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_userManagement.UseVisualStyleBackColor = true;
            this.btn_userManagement.Click += new System.EventHandler(this.btn_userManagement_Click);
            // 
            // btn_ticketStatistics
            // 
            this.btn_ticketStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ticketStatistics.FlatAppearance.BorderSize = 0;
            this.btn_ticketStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ticketStatistics.Font = new System.Drawing.Font("TeX Gyre Adventor", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ticketStatistics.ForeColor = System.Drawing.Color.White;
            this.btn_ticketStatistics.Image = global::SunshineAirlines1.Properties.Resources.flight_statistics;
            this.btn_ticketStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ticketStatistics.Location = new System.Drawing.Point(5, 383);
            this.btn_ticketStatistics.Name = "btn_ticketStatistics";
            this.btn_ticketStatistics.Size = new System.Drawing.Size(208, 63);
            this.btn_ticketStatistics.TabIndex = 5;
            this.btn_ticketStatistics.Text = "Ticket Statistics";
            this.btn_ticketStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ticketStatistics.UseVisualStyleBackColor = true;
            this.btn_ticketStatistics.Click += new System.EventHandler(this.btn_ticketStatistics_Click);
            // 
            // btn_flightScheduleManagement
            // 
            this.btn_flightScheduleManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_flightScheduleManagement.FlatAppearance.BorderSize = 0;
            this.btn_flightScheduleManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_flightScheduleManagement.Font = new System.Drawing.Font("TeX Gyre Adventor", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flightScheduleManagement.ForeColor = System.Drawing.Color.White;
            this.btn_flightScheduleManagement.Image = global::SunshineAirlines1.Properties.Resources.flight_management;
            this.btn_flightScheduleManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_flightScheduleManagement.Location = new System.Drawing.Point(5, 314);
            this.btn_flightScheduleManagement.Name = "btn_flightScheduleManagement";
            this.btn_flightScheduleManagement.Size = new System.Drawing.Size(208, 63);
            this.btn_flightScheduleManagement.TabIndex = 4;
            this.btn_flightScheduleManagement.Text = "Management";
            this.btn_flightScheduleManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_flightScheduleManagement.UseVisualStyleBackColor = true;
            this.btn_flightScheduleManagement.Click += new System.EventHandler(this.btn_flightScheduleManagement_Click);
            // 
            // btn_flightStatus
            // 
            this.btn_flightStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_flightStatus.FlatAppearance.BorderSize = 0;
            this.btn_flightStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_flightStatus.Font = new System.Drawing.Font("TeX Gyre Adventor", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flightStatus.ForeColor = System.Drawing.Color.White;
            this.btn_flightStatus.Image = global::SunshineAirlines1.Properties.Resources.flight_status;
            this.btn_flightStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_flightStatus.Location = new System.Drawing.Point(5, 245);
            this.btn_flightStatus.Name = "btn_flightStatus";
            this.btn_flightStatus.Size = new System.Drawing.Size(208, 63);
            this.btn_flightStatus.TabIndex = 3;
            this.btn_flightStatus.Text = "Flight Status";
            this.btn_flightStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_flightStatus.UseVisualStyleBackColor = true;
            this.btn_flightStatus.Click += new System.EventHandler(this.btn_FlightStatus_Click);
            // 
            // btn_foodServices
            // 
            this.btn_foodServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_foodServices.FlatAppearance.BorderSize = 0;
            this.btn_foodServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_foodServices.Font = new System.Drawing.Font("TeX Gyre Adventor", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_foodServices.ForeColor = System.Drawing.Color.White;
            this.btn_foodServices.Image = global::SunshineAirlines1.Properties.Resources.food;
            this.btn_foodServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_foodServices.Location = new System.Drawing.Point(5, 176);
            this.btn_foodServices.Name = "btn_foodServices";
            this.btn_foodServices.Size = new System.Drawing.Size(208, 63);
            this.btn_foodServices.TabIndex = 2;
            this.btn_foodServices.Text = "Food Services";
            this.btn_foodServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_foodServices.UseVisualStyleBackColor = true;
            this.btn_foodServices.Click += new System.EventHandler(this.btn_foodServices_Click);
            // 
            // pan_side
            // 
            this.pan_side.BackColor = System.Drawing.Color.White;
            this.pan_side.Location = new System.Drawing.Point(0, 107);
            this.pan_side.Name = "pan_side";
            this.pan_side.Size = new System.Drawing.Size(5, 63);
            this.pan_side.TabIndex = 0;
            // 
            // btn_searchFlight
            // 
            this.btn_searchFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_searchFlight.FlatAppearance.BorderSize = 0;
            this.btn_searchFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchFlight.Font = new System.Drawing.Font("TeX Gyre Adventor", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchFlight.ForeColor = System.Drawing.Color.White;
            this.btn_searchFlight.Image = ((System.Drawing.Image)(resources.GetObject("btn_searchFlight.Image")));
            this.btn_searchFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchFlight.Location = new System.Drawing.Point(5, 107);
            this.btn_searchFlight.Name = "btn_searchFlight";
            this.btn_searchFlight.Size = new System.Drawing.Size(208, 63);
            this.btn_searchFlight.TabIndex = 1;
            this.btn_searchFlight.Text = "Search Flights";
            this.btn_searchFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_searchFlight.UseVisualStyleBackColor = true;
            this.btn_searchFlight.Click += new System.EventHandler(this.btn_searchFlight_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_Logo.Image = global::SunshineAirlines1.Properties.Resources.SunshineAirlinesLogo;
            this.pic_Logo.Location = new System.Drawing.Point(0, 0);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(213, 107);
            this.pic_Logo.TabIndex = 0;
            this.pic_Logo.TabStop = false;
            // 
            // pan_status
            // 
            this.pan_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.pan_status.Controls.Add(this.pic_weather);
            this.pan_status.Controls.Add(this.lbl_weather);
            this.pan_status.Controls.Add(this.lbl_date);
            this.pan_status.Controls.Add(this.lbl_time);
            this.pan_status.Controls.Add(this.lbl_userRoleName);
            this.pan_status.Controls.Add(this.label5);
            this.pan_status.Controls.Add(this.lbl_username);
            this.pan_status.Controls.Add(this.label2);
            this.pan_status.Location = new System.Drawing.Point(212, 45);
            this.pan_status.Name = "pan_status";
            this.pan_status.Size = new System.Drawing.Size(1200, 62);
            this.pan_status.TabIndex = 4;
            // 
            // pic_weather
            // 
            this.pic_weather.BackColor = System.Drawing.Color.Transparent;
            this.pic_weather.Image = ((System.Drawing.Image)(resources.GetObject("pic_weather.Image")));
            this.pic_weather.Location = new System.Drawing.Point(1150, 14);
            this.pic_weather.Name = "pic_weather";
            this.pic_weather.Size = new System.Drawing.Size(36, 36);
            this.pic_weather.TabIndex = 8;
            this.pic_weather.TabStop = false;
            // 
            // lbl_weather
            // 
            this.lbl_weather.AutoSize = true;
            this.lbl_weather.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weather.ForeColor = System.Drawing.Color.White;
            this.lbl_weather.Location = new System.Drawing.Point(911, 21);
            this.lbl_weather.Name = "lbl_weather";
            this.lbl_weather.Size = new System.Drawing.Size(247, 24);
            this.lbl_weather.TabIndex = 16;
            this.lbl_weather.Text = "Yingcheng Hubei Rain 19℃";
            this.lbl_weather.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(722, 21);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(120, 24);
            this.lbl_date.TabIndex = 15;
            this.lbl_date.Text = "DD-MM-YYYY";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(599, 21);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(94, 24);
            this.lbl_time.TabIndex = 14;
            this.lbl_time.Text = "HH:MM:SS";
            // 
            // lbl_userRoleName
            // 
            this.lbl_userRoleName.AutoSize = true;
            this.lbl_userRoleName.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userRoleName.ForeColor = System.Drawing.Color.White;
            this.lbl_userRoleName.Location = new System.Drawing.Point(363, 21);
            this.lbl_userRoleName.Name = "lbl_userRoleName";
            this.lbl_userRoleName.Size = new System.Drawing.Size(66, 24);
            this.lbl_userRoleName.TabIndex = 13;
            this.lbl_userRoleName.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(314, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Role:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(121, 21);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(38, 24);
            this.lbl_username.TabIndex = 11;
            this.lbl_username.Text = "YFF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome:";
            // 
            // pan_showFrm
            // 
            this.pan_showFrm.BackColor = System.Drawing.SystemColors.Control;
            this.pan_showFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_showFrm.Location = new System.Drawing.Point(212, 107);
            this.pan_showFrm.Name = "pan_showFrm";
            this.pan_showFrm.Size = new System.Drawing.Size(1200, 800);
            this.pan_showFrm.TabIndex = 5;
            // 
            // pan_title
            // 
            this.pan_title.BackColor = System.Drawing.SystemColors.Control;
            this.pan_title.Controls.Add(this.btn_logout);
            this.pan_title.Controls.Add(this.btn_close);
            this.pan_title.Controls.Add(this.lbl_title);
            this.pan_title.Location = new System.Drawing.Point(0, 0);
            this.pan_title.Name = "pan_title";
            this.pan_title.Size = new System.Drawing.Size(1412, 47);
            this.pan_title.TabIndex = 7;
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Image = global::SunshineAirlines1.Properties.Resources.log_out;
            this.btn_logout.Location = new System.Drawing.Point(1304, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(51, 47);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::SunshineAirlines1.Properties.Resources.Close;
            this.btn_close.Location = new System.Drawing.Point(1361, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(51, 47);
            this.btn_close.TabIndex = 8;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.lbl_title.Location = new System.Drawing.Point(241, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(204, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Sunshine Airlines Menu";
            // 
            // timer_closefrm
            // 
            this.timer_closefrm.Interval = 30;
            this.timer_closefrm.Tick += new System.EventHandler(this.timer_closefrm_Tick);
            // 
            // timer_refreshSystemDT
            // 
            this.timer_refreshSystemDT.Enabled = true;
            this.timer_refreshSystemDT.Interval = 1000;
            this.timer_refreshSystemDT.Tick += new System.EventHandler(this.timer_refreshSystemDT_Tick);
            // 
            // timer_fold
            // 
            this.timer_fold.Interval = 30;
            this.timer_fold.Tick += new System.EventHandler(this.timer_fold_Tick);
            // 
            // timer_refreshWeather
            // 
            this.timer_refreshWeather.Enabled = true;
            this.timer_refreshWeather.Interval = 3600000;
            this.timer_refreshWeather.Tick += new System.EventHandler(this.timer_refreshWeather_Tick);
            // 
            // OfficeUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1410, 905);
            this.Controls.Add(this.pan_menu);
            this.Controls.Add(this.pan_status);
            this.Controls.Add(this.pan_showFrm);
            this.Controls.Add(this.pan_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "OfficeUserMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfficeUserMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OfficeUserMenu_FormClosing);
            this.Load += new System.EventHandler(this.OfficeUserMenu_Load);
            this.pan_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.pan_status.ResumeLayout(false);
            this.pan_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_weather)).EndInit();
            this.pan_title.ResumeLayout(false);
            this.pan_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_menu;
        private System.Windows.Forms.Panel pan_status;
        private System.Windows.Forms.Panel pan_showFrm;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Button btn_searchFlight;
        private System.Windows.Forms.Panel pan_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pan_side;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_userManagement;
        private System.Windows.Forms.Button btn_ticketStatistics;
        private System.Windows.Forms.Button btn_flightScheduleManagement;
        private System.Windows.Forms.Button btn_flightStatus;
        private System.Windows.Forms.Button btn_foodServices;
        private System.Windows.Forms.Button btn_fold;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_userRoleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_weather;
        private System.Windows.Forms.Timer timer_closefrm;
        private System.Windows.Forms.Timer timer_refreshSystemDT;
        private System.Windows.Forms.Timer timer_fold;
        private System.Windows.Forms.Timer timer_refreshWeather;
        private System.Windows.Forms.PictureBox pic_weather;
    }
}