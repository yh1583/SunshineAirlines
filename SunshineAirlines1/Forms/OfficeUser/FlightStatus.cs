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

namespace SunshineAirlines1.Forms.OfficeUser
{
    public partial class FlightStatus : Form
    {
        public FlightStatus()
        {
            InitializeComponent();
        }

        private int sumPage = 0;

        private int nowPage = 1;

        private List<Schedule> schedulesList = new List<Schedule>();

        private DataTable dtDeparture = new DataTable();

        private DataColumn dc = null;


        private void btn_search_Click(object sender, EventArgs e)
        {

            btn_last.Enabled = true;
            btn_next.Enabled = true;
            btn_end.Enabled = true;
            btn_first.Enabled = true;
            txt_nowPage.Enabled = true;
            schedulesList = FlightStatusDal.GetList(dtp_dep.Value);
            InitDataTable();
            try
            {
                foreach (var scheduleitem in schedulesList)
                {
                    DataRow row = dtDeparture.NewRow();
                    row["FlightNumber"] = scheduleitem.FlightNumber;
                    row["From"] = scheduleitem.Route.Airport.City.CityName + "/" + scheduleitem.Route.Airport.IATACode;
                    row["To"] = scheduleitem.Route.Airport1.City.CityName + "/" + scheduleitem.Route.Airport1.IATACode;
                    row["ScheduleStart"] = new DateTime(2020, 1, 1, scheduleitem.Time.Hours, scheduleitem.Time.Minutes, scheduleitem.Time.Seconds).ToString("HH:mm");
                    row["ScheduleArrival"] = DateTime.Parse(row["ScheduleStart"].ToString()).AddMinutes(scheduleitem.Route.FlightTime).ToString("HH:mm");
                    row["ActualArrival"] = scheduleitem.FlightStatu.ActualArrivalTime.ToString("HH:mm");
                    row["Gate"] = scheduleitem.Gate;
                    TimeSpan ts = DateTime.Parse(row["ScheduleArrival"].ToString()) - DateTime.Parse(row["ActualArrival"].ToString());
                    if (ts.Minutes > 0)
                    {
                        row["Status"] = "Early " + ts.Minutes + " minute";
                    }
                    else if (ts.Minutes < 0)
                    {
                        row["Status"] = "Delay " + (-ts.Minutes) + " minute";
                    }
                    else
                    {
                        row["Status"] = "On Time";
                    }
                    dtDeparture.Rows.Add(row);
                }
                if (dtDeparture.Rows.Count>0)
                {
                    sumPage = (dtDeparture.Rows.Count / 10) + 1;
                    nowPage = 1;
                    txt_nowPage.Text = nowPage.ToString();
                    lbl_sumPage.Text = sumPage.ToString();
                }
                else
                {
                    MessageBox.Show("该日期没有查询结果");
                }
                ClearTable();
                dgv_resultList.DataSource = GetNewDataTable().DefaultView;
                
            }
            catch (Exception)
            {
                MessageBox.Show("该日期没有查询结果");
                return;
            }
        }

        private void InitDataTable()
        {
            dtDeparture = new DataTable();

            dc = dtDeparture.Columns.Add("NO", Type.GetType("System.Int32"));
            dc.AutoIncrement = true;
            dc.AutoIncrementSeed = 1;
            dc.AutoIncrementStep = 1;
            dc.AllowDBNull = false;
            dtDeparture.Columns.Add("FlightNumber", Type.GetType("System.String"));
            dtDeparture.Columns.Add("From", Type.GetType("System.String"));
            dtDeparture.Columns.Add("To", Type.GetType("System.String"));
            dtDeparture.Columns.Add("ScheduleStart", Type.GetType("System.String"));
            dtDeparture.Columns.Add("ScheduleArrival", Type.GetType("System.String"));
            dtDeparture.Columns.Add("ActualArrival", Type.GetType("System.String"));
            dtDeparture.Columns.Add("Gate", Type.GetType("System.String"));
            dtDeparture.Columns.Add("Status", Type.GetType("System.String"));
        }


        private DataTable GetNewDataTable()
        {
            DataTable dt = dtDeparture.Clone();
            for (int i = 10*(nowPage-1); i<((nowPage*10)>(dtDeparture.Rows.Count)?(dtDeparture.Rows.Count):(nowPage*10)); i++)
            {
                dt.Rows.Add(dtDeparture.Rows[i].ItemArray);
            }
            return dt;
        }

        private void ClearTable()
        {
            DataTable dt = dtDeparture.Clone();
            dgv_resultList.DataSource = dt;
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            nowPage = 1;
            ClearTable();
            txt_nowPage.Text = nowPage.ToString();
            dgv_resultList.DataSource = GetNewDataTable().DefaultView;
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            if (nowPage==1)
            {
                return;
            }
            else
            {
                nowPage -= 1;
                txt_nowPage.Text = nowPage.ToString();
                ClearTable();
                dgv_resultList.DataSource = GetNewDataTable().DefaultView;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (nowPage==sumPage)
            {
                return;
            }
            else
            {
                nowPage += 1;
                txt_nowPage.Text = nowPage.ToString();
                ClearTable();
                dgv_resultList.DataSource = GetNewDataTable().DefaultView;
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            nowPage = sumPage;
            txt_nowPage.Text = nowPage.ToString();
            ClearTable();
            dgv_resultList.DataSource = GetNewDataTable().DefaultView;
        }

        private void txt_nowPage_TextChanged(object sender, EventArgs e)
        {
            int outResult = 1;
            if (int.TryParse(txt_nowPage.Text,out outResult))
            {
                if (int.Parse(txt_nowPage.Text)>sumPage||int.Parse(txt_nowPage.Text)<1)
                {
                    MessageBox.Show("错误的数字");
                    return;
                }
                nowPage = int.Parse(txt_nowPage.Text);
                ClearTable();
                dgv_resultList.DataSource = GetNewDataTable().DefaultView;
            }
        }

        private void FlightStatus_Load(object sender, EventArgs e)
        {

            AllFun.CheckAllCtrls(this);
            AllFun.ReplaceByLanguageMode();
        }
    }
}
