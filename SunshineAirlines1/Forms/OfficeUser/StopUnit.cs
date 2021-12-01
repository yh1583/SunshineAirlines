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
    public partial class StopUnit : UserControl
    {
        public StopUnit(float price, string cabinType, string flightNumber1, string flightNumber2, float rateBeforeTansfer,float rateAfterTansfer,string from1,string to1,DateTime dateTime1,DateTime dateTime2,string from2,string to2,DateTime dateTime3,DateTime dateTime4,int flightTime1,int flightTime2 ,int available)
        {
            InitializeComponent();
            lbl_price.Text = string.Format("${0}",price.ToString());
            lbl_cabinType.Text = cabinType.ToString();
            lbl_flightNumAndRateBT.Text = string.Format("Flight{0}({1}%)",flightNumber1,(int)(rateBeforeTansfer*100));
            lbl_flightNumAndRateAT.Text= string.Format("Flight{0}({1}%)", flightNumber2, (int)(rateAfterTansfer * 100));
            lbl_fromPlace1.Text = from1.ToString();
            lbl_toPlace1.Text = to1.ToString();
            lbl_fromDt1.Text = dateTime1.ToString("yyyy-MM-dd HH:mm");
            lbl_toDt1.Text=dateTime2.ToString("yyyy-MM-dd HH:mm");
            lbl_fromPlace2.Text = from2.ToString();
            lbl_toPlace2.Text = to2.ToString();
            lbl_fromDt2.Text = dateTime3.ToString("yyyy-MM-dd HH:mm");
            lbl_toDt2.Text = dateTime4.ToString("yyyy-MM-dd HH:mm");
            lbl_tansferTime.Text = string.Format("{0}h{1}m Transfer in {2}",(dateTime3-dateTime2).Hours,(dateTime3-dateTime2).Minutes,to1);
            DateTime time = new DateTime(2020,1,1,0,0,0);
            time=time.AddMinutes(flightTime1).Add(dateTime3-dateTime2).AddMinutes(flightTime2);
            lbl_totalTime.Text = string.Format("Total Time:{0}h{1}m",time.Hour,time.Minute);
            if (available<=3)
            {
                lbl_available.ForeColor = Color.Red;
            }
            lbl_available.Text = string.Format("{0}available tickets",available);
        }

        private void StopUnit_Load(object sender, EventArgs e)
        {

        }
    }
}
