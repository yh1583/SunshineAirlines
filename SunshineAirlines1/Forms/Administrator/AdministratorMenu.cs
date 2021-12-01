using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines1.Forms.Administrator
{
    public partial class AdministratorMenu : Form
    {
        public AdministratorMenu(Login login)
        {
            InitializeComponent();
            LoginUI = login;
        }

        Login LoginUI;
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdministratorMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("你确定要退出程序吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    Environment.Exit(0);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void btn_searchFlight_Click(object sender, EventArgs e)
        {
            FlightScheduleManagement childUI = new FlightScheduleManagement();
            childUI.MdiParent = this;
            childUI.Show();
        }

        private void btn_FlightStatus_Click(object sender, EventArgs e)
        {
            UserManagement childUI = new UserManagement();
            childUI.MdiParent = this;
            childUI.Show();
        }

        private void btn_foodServices_Click(object sender, EventArgs e)
        {
            TicketStatistics childUI = new TicketStatistics();
            childUI.MdiParent = this;
            childUI.Show();
        }


    }
}
