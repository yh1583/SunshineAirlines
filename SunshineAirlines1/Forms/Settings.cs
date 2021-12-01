using SunshineAirlines1.Dals;
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

namespace SunshineAirlines1.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private bool loadValue = false;

        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                AllFun.CheckAllCtrls(this);
                AllFun.ReplaceByLanguageMode();
                cbx_languageSetting.SelectedIndex = int.Parse(ConfigurationManager.AppSettings["language"].ToString());
            }
            catch (Exception)
            {
                return;
            }
           
        }

        private void cbx_languageSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["language"].Value = cbx_languageSetting.SelectedIndex.ToString();
            config.Save();
            if (loadValue)
            {
                MessageBox.Show("保存成功，下次启动时更改生效！");
            }
            loadValue = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当前已是最新版，无需更新！");
        }
    }
}
