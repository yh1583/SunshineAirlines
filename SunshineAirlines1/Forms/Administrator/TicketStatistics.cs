using SunshineAirlines1.Dals;
using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SunshineAirlines1.Forms.Administrator
{
    public partial class TicketStatistics : Form
    {
        public TicketStatistics()
        {
            InitializeComponent();
        }

        private DataTable ticketTable;

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            InitDataTable();
            DateTime date = dtp_startDate.Value;
            List<DateTime> datesList = new List<DateTime>();
            while (date.Date<=dtp_endDate.Value.Date)
            {
                datesList.Add(date);
                date = date.AddMonths(1);
            }
            foreach (var dt in datesList)
            {
                List<Schedule> schedulesList = FlightScheduleDal.GetListByMonth(dt);
                DataRow row = ticketTable.NewRow();
                row["Month"] = dt.ToString("yyyy-MM");
                row["FlightsAmount"] = schedulesList.Count.ToString();
                float flightsRevenue = 0;
                int ticketsAmount = 0;
                foreach (var schedule in schedulesList)
                {
                    List<FlightReservation> flightReservationsList = FlightScheduleDal.GetListByScheduleID(schedule.ScheduleId);
                    ticketsAmount += flightReservationsList.Count;
                    foreach (var flightReservation in flightReservationsList)
                    {
                        flightsRevenue += (float)(flightReservation.Payment);
                    }
                }
                row["TicketsAmount"] = ticketsAmount.ToString();
                row["TicketsRevenus"] = flightsRevenue.ToString("F2");
                ticketTable.Rows.Add(row);
            }
            dgv_resultList.DataSource = ticketTable.DefaultView;

            cbx_viewBy_SelectedIndexChanged(sender, e);
        }

        

        private void InitDataTable()
        {
            ticketTable = new DataTable();
            ticketTable.Columns.Add("Month",typeof(String));

            ticketTable.Columns.Add("FlightsAmount", typeof(String));
            ticketTable.Columns.Add("TicketsAmount", typeof(String));
            ticketTable.Columns.Add("TicketsRevenus", typeof(String));

        }

        private void che_showAmount_CheckedChanged(object sender, EventArgs e)
        {
            int index = 0;
            if (che_showAmount.Checked)
            {
                if (ticketTable.Rows.Count!=0)
                {
                    foreach (var point in crt_dataLineMap.Series[0].Points)
                    {
                        point.Label = ticketTable.Rows[index++][cbx_viewBy.SelectedIndex + 1].ToString();
                    }
                }
            }
            else
            {
                if (ticketTable.Rows.Count!=0)
                {
                    foreach (var point in crt_dataLineMap.Series[0].Points)
                    {
                        point.Label = "";
                    }
                }
            }
        }

        private void cbx_viewBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_viewBy.SelectedIndex>=0&&ticketTable!=null)
            {
                List<DateTime> xList = new List<DateTime>();
                List<float> yList = new List<float>();
                for (int i = 0; i < ticketTable.Rows.Count; i++)
                {
                    xList.Add(DateTime.Parse(ticketTable.Rows[i][0].ToString()));
                    yList.Add(float.Parse(ticketTable.Rows[i][cbx_viewBy.SelectedIndex + 1].ToString()));
                }
                if (ticketTable.Rows.Count>1)
                {
                    BindChart(xList,yList);
                }
                che_showAmount_CheckedChanged(sender, e);
            }
            crt_dataLineMap.Series[0].Name = cbx_viewBy.Text;
        }

        private void BindChart(List<DateTime> xList,List<float> yList)
        {
            crt_dataLineMap.Series[0].Points.DataBindXY(xList, yList);
            crt_dataLineMap.Series[0].Color = Color.Orange;
            crt_dataLineMap.Series[0].XValueType = ChartValueType.Date;
            crt_dataLineMap.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Months;
            crt_dataLineMap.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            crt_dataLineMap.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM";
            crt_dataLineMap.Series[0].BorderWidth = 2;
            crt_dataLineMap.ChartAreas[0].AxisX.Maximum = xList.Max().ToOADate();
            crt_dataLineMap.ChartAreas[0].AxisX.Minimum = xList.Min().ToOADate();
            crt_dataLineMap.ChartAreas[0].AxisY.Maximum = yList.Max() % 5 == 0 ? yList.Max() : GetScale(yList.Max());
            crt_dataLineMap.ChartAreas[0].AxisY.Minimum = 0;
        }

        private double GetScale(double v)
        {
            double numToDivede = v;
            while(numToDivede/5%10!=0)
            {
                numToDivede++;
            }
            return numToDivede;
        }

        private void TicketStatistics_Load(object sender, EventArgs e)
        {
            cbx_viewBy.SelectedIndex = 0;

            AllFun.CheckAllCtrls(this);
            AllFun.ReplaceByLanguageMode();
        }
    }
}
