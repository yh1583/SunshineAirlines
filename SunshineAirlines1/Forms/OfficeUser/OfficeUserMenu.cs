using SunshineAirlines1.Forms.Administrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SunshineAirlines1.Models;
using SunshineAirlines1.Properties;
using System.Configuration;
using SunshineAirlines1.Dals;

namespace SunshineAirlines1.Forms.OfficeUser
{
    public partial class OfficeUserMenu : Form
    {
        public OfficeUserMenu(Login login,User user)
        {
            InitializeComponent();
            LoginUI = login;
            userInfo = user;
        }
        Login LoginUI;

        private bool isFold = false;

        private Weather weathers;

        private User userInfo;


        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI.Show();
        }

        private void OfficeUserMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("你确定要退出程序吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    try
            //    {
            //        timer_closefrm.Start();
            //    }
            //    catch (Exception)
            //    {
            //        return;
            //    }
            //}
        }

        public static string HttpGet(string url, Encoding encoding)
        {
            string data = "";
            try
            {
                WebRequest request; //使用url发出请求的类
                request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;   //使用默认的身份验证
                request.Timeout = 10000;    //设定超时
                WebResponse response;   //提供响应的类
                response = request.GetResponse();
                data = new StreamReader(response.GetResponseStream(), encoding).ReadToEnd();    //获取数据
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return data;
        }

        private void btn_FlightStatus_Click(object sender, EventArgs e)
        {
            moveSidePanel(sender as Button);
            FlightStatus childUI = new FlightStatus();
            childUI.MdiParent = this;
            childUI.Parent = this.pan_showFrm;
            childUI.Show();
        }

        private void btn_foodServices_Click(object sender, EventArgs e)
        {
            moveSidePanel(sender as Button);
            FoodServices childUI = new FoodServices();
            childUI.MdiParent = this;
            childUI.Parent = this.pan_showFrm;
            childUI.Show();
        }

        private void btn_searchFlight_Click(object sender, EventArgs e)
        {
            moveSidePanel(sender as Button);
            FlightSearch childUI = new FlightSearch();
            childUI.MdiParent = this;
            childUI.Parent = this.pan_showFrm;
            childUI.Show();
        }

     

        private void btn_close_Click(object sender, EventArgs e)
        {
            timer_closefrm.Start();
        }

        private void timer_closefrm_Tick(object sender, EventArgs e)
        {
            if (this.Opacity>=0.025)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer_closefrm.Stop();
                Environment.Exit(0);
            }
        }

        private void moveSidePanel(Control btn)
        {
            pan_side.Top = btn.Top;
            pan_side.Height = btn.Height;
            foreach (Control control in pan_showFrm.Controls)
            {
                if (control is Form)
                {
                    Form form = control as Form;
                    form.Close();
                }
            }
        }

        private void timer_refreshSystemDT_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btn_fold_Click(object sender, EventArgs e)
        {
            timer_fold.Start();
        }

        private void timer_fold_Tick(object sender, EventArgs e)
        {
            if (isFold)
            {
               
                pan_menu.Width += 4;
                lbl_title.Location = new Point(lbl_title.Location.X + 4, lbl_title.Location.Y);
                pan_status.Width -= 4;
                pan_status.Location = new Point(pan_status.Location.X + 4, pan_status.Location.Y);
                pan_showFrm.Width -= 4;
                pan_showFrm.Location = new Point(pan_showFrm.Location.X + 4, pan_showFrm.Location.Y);
                if (pan_menu.Width >= 213)
                {
                    pic_Logo.Visible = true;
                    timer_fold.Stop();
                    isFold = false;
                    this.Refresh();
                }
            }
            else
            {
                pic_Logo.Visible = false;
                pan_menu.Width -= 4;
                lbl_title.Location = new Point(lbl_title.Location.X - 4, lbl_title.Location.Y);
                pan_status.Width += 4;
                pan_status.Location = new Point(pan_status.Location.X - 4, pan_status.Location.Y);
                pan_showFrm.Width += 4;
                pan_showFrm.Location = new Point(pan_showFrm.Location.X - 4, pan_showFrm.Location.Y);
                if (pan_menu.Width <= 58)
                {
                    timer_fold.Stop();
                    isFold = true;
                    this.Refresh();
                }
            }
        }

       

        private void btn_flightScheduleManagement_Click(object sender, EventArgs e)
        {
            moveSidePanel(sender as Button);
            FlightScheduleManagement childUI = new FlightScheduleManagement();
            childUI.MdiParent = this;
            childUI.Parent = this.pan_showFrm;
            childUI.Show();
        }

        private void btn_ticketStatistics_Click(object sender, EventArgs e)
        {
            moveSidePanel(sender as Button);
            TicketStatistics childUI = new TicketStatistics();
            childUI.MdiParent = this;
            childUI.Parent = this.pan_showFrm;
            childUI.Show();
        }

        private void btn_userManagement_Click(object sender, EventArgs e)
        {
            moveSidePanel(sender as Button);
            UserManagement childUI = new UserManagement();
            childUI.MdiParent = this;
            childUI.Parent = this.pan_showFrm;
            childUI.Show();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            moveSidePanel(sender as Button);
            Settings childUI = new Settings();
            childUI.MdiParent = this;
            childUI.Parent = this.pan_showFrm;
            childUI.Show();
        }

        private void OfficeUserMenu_Load(object sender, EventArgs e)
        {
            timer_refreshWeather_Tick(sender, e);
            timer_refreshSystemDT_Tick(sender, e);
            ModeChangeUI();
            AllFun.CheckAllCtrls(this);
            AllFun.ReplaceByLanguageMode();
        }




        

        private void ModeChangeUI()
        {
            FlightSearch childUI = new FlightSearch();
            childUI.MdiParent = this;
            childUI.Parent = this.pan_showFrm;
            childUI.Show();

            lbl_username.Text = string.Format("{0} {1}", (userInfo.Gender == "M" ? "Mr" : "Ms"), userInfo.LastName);
            if (userInfo.RoleId==1)
            {
                lbl_userRoleName.Text = "User";
                btn_flightScheduleManagement.Visible = false;
                btn_ticketStatistics.Visible = false;
                btn_userManagement.Visible = false;
                btn_setting.Location = new Point(5,314);
            }
            else
            {
                lbl_userRoleName.Text = "Admin";
                btn_flightScheduleManagement.Visible = true;
                btn_ticketStatistics.Visible = true;
                btn_userManagement.Visible = true;
                btn_setting.Location = new Point(5, 521);
            }
        }

        private Weather GetWeatherInfo()
        {
            try
            {
                string url = "https://tianqiapi.com/api?version=v61&appid=83718765&appsecret=NQm2uUfp";
                Encoding encoding = Encoding.GetEncoding("utf-8");
                string data = HttpGet(url, encoding);

                 return JsonConvert.DeserializeObject<Weather>(data);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void timer_refreshWeather_Tick(object sender, EventArgs e)
        {

            weathers = GetWeatherInfo();
            if (weathers != null)
            {
                
                lbl_weather.Text = string.Format("{0} {1} {2}℃", weathers.city, weathers.wea, weathers.tem);
                switch (weathers.wea_img)
                {
                    case "xue": pic_weather.Image = Resources.xue; break;
                    case "lei": pic_weather.Image = Resources.leidian; break;
                    case "shachen": pic_weather.Image = Resources.shachen; break;
                    case "wu": pic_weather.Image = Resources.wu; break;
                    case "bingbao": pic_weather.Image = Resources.bingbao; break;
                    case "yun": pic_weather.Image = Resources.duoyun; break;
                    case "yu": pic_weather.Image = Resources.yu; break;
                    case "yin": pic_weather.Image = Resources.yin; break;
                    case "qing": pic_weather.Image = Resources.qing; break;
                }
                pic_weather.Location = new Point(lbl_weather.Location.X+lbl_weather.Width+3,lbl_weather.Location.Y-3);
            }
            else
            {
                lbl_weather.Text = "当前无网络";
                pic_weather.Image = Resources.noInternet;
                pic_weather.Location = new Point(lbl_weather.Location.X + lbl_weather.Width+3, lbl_weather.Location.Y-3);
            }
        }
    }
}
