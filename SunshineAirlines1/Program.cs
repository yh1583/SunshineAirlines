using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmSplashScreen splashScreen = new FrmSplashScreen();
            if (splashScreen.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Login());
            }
        }
    }
}
