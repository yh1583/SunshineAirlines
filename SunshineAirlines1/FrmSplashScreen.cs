using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines1
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer_progressbar_Tick(object sender, EventArgs e)
        {
            pan_progressbar.Width += 5;
            if (pan_progressbar.Width>=pan_progressbarContainer.Width)
            {
                timer_progressbar.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }


    }
}
