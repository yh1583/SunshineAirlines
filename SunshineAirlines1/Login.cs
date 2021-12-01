using SunshineAirlines1.Dals;
using SunshineAirlines1.Forms.Administrator;
using SunshineAirlines1.Forms.OfficeUser;
using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private int LoginErrTimes = 0;


        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = UsersDal.QueryUsersByEmail(txt_email.Text);

            if (user != null && user.Password == txt_pwd.Text)
            {
                if (btn_showVC.Visible && txt_inputVC.Text != btn_showVC.Text)
                {
                    MessageBox.Show("验证码错误");
                    return;
                }
                if (cbx_autoLogin.Checked)
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["email"].Value = txt_email.Text;
                    config.AppSettings.Settings["password"].Value = txt_pwd.Text;
                    config.AppSettings.Settings["date"].Value = DateTime.Now.ToString();
                    config.AppSettings.Settings["roleId"].Value = user.RoleId.ToString();
                    config.Save();
                }
                else
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["email"].Value = "";
                    config.AppSettings.Settings["password"].Value = "";
                    config.AppSettings.Settings["date"].Value = "";
                    config.AppSettings.Settings["roleId"].Value = "";
                    config.Save();
                }

                OfficeUserMenu userUI = new OfficeUserMenu(this, user);
                userUI.Show();
                this.Hide();

            }
            else
            {
                LoginErrTimes++;
                if (LoginErrTimes >= 3)
                {
                    lbl_VC.Visible = true;
                    txt_inputVC.Visible = true;
                    btn_showVC.Visible = true;
                    btn_showVC.Text = GetVerificationCode();
                }
                MessageBox.Show("用户名或密码错误");
            }

        }

        private string GetVerificationCode()
        {
            char[] vcArr = new char[4];
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                if (rand.Next(0,2)==0)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        vcArr[i] = (char)('a' + rand.Next(0, 26));
                    }
                    else
                    {
                        vcArr[i] = (char)('A' + rand.Next(0, 26));
                    }
                }
                else
                {
                    vcArr[i] = (char)('0' + rand.Next(0, 10));
                }
            }
            return new String(vcArr);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void btn_showVC_Click(object sender, EventArgs e)
        {
            btn_showVC.Text = GetVerificationCode();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            List<Control> controlCollection=new List<Control>();
            foreach (Control control in this.Controls)
            {
                if (control.Name != "pic_background")
                {
                    controlCollection.Add(control);
                }
            }
            foreach (var control1 in controlCollection)
            {
                control1.Parent = pic_background;
            }


            AllFun.CheckAllCtrls(this);
            AllFun.ReplaceByLanguageMode();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
          
            if (ConfigurationManager.AppSettings["email"]!="")
            {
                this.Visible = true   ;
                if ((DateTime.Now - DateTime.Parse(ConfigurationManager.AppSettings["date"])).TotalDays <= 7)
                {
                    cbx_autoLogin.Checked = true;
                    txt_email.Text = ConfigurationManager.AppSettings["email"];
                    txt_pwd.Text = ConfigurationManager.AppSettings["password"];
                    string roleid = ConfigurationManager.AppSettings["roleId"];
                    OfficeUserMenu userUI = new OfficeUserMenu(this, UsersDal.QueryUsersByEmail(txt_email.Text));
                    userUI.Show();
                    this.Hide();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity>=0.025)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer1.Stop();
                Environment.Exit(0);
            }
        }
    }
}
