using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines1.Forms.OfficeUser
{
    public partial class NonStopUnit : UserControl
    {
        public NonStopUnit(float price,string cabinType,string flightNumber,float rate,string departure,string arrival,DateTime depDate,DateTime arrDate,int flightTime,int available)
        {
            InitializeComponent();
            lbl_price.Text = string.Format("${0}", price.ToString());
            lbl_cabinType.Text = cabinType.ToString();
            lbl_flightNumAndRate.Text = string.Format("Flight{0}({1}%)", flightNumber, (int)(rate * 100));
            lbl_fromPlace.Text = departure.ToString();
            lbl_toPlace.Text = arrival.ToString();
            lbl_fromDt.Text=depDate.ToString("yyyy-MM-dd HH:mm");
            lbl_toDt.Text=arrDate.ToString("yyyy-MM-dd HH:mm");
            DateTime time = new DateTime(2020,1,1,0,0,0);
            time = time.AddMinutes(flightTime);
            lbl_totalTime.Text = string.Format("Total Time:{0}h{1}m", time.Hour, time.Minute);
            if (available <= 3)
            {
                lbl_available.ForeColor = Color.Red;
            }
            lbl_available.Text = string.Format("{0}available tickets", available);
        }

        private void NonStopUnit_Load(object sender, EventArgs e)
        {

        }
    }
}
