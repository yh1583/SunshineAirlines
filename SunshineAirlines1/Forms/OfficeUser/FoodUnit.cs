using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunshineAirlines1.Models;

namespace SunshineAirlines1.Forms.OfficeUser
{
    public partial class FoodUnit : UserControl
    {
        public FoodUnit(FlightFood food)
        {
            InitializeComponent();
            lbl_title.Text = food.Name;
            lbl_price.Text = "$" + ((float)(food.Price)).ToString("F2");
            pic_foodImg.Image = Image.FromFile(Application.StartupPath+ @"\Images\Food\"+food.Img);
        }

        private void FoodUnit_Load(object sender, EventArgs e)
        {

        }
    }
}
