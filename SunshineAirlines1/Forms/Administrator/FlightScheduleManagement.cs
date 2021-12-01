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

namespace SunshineAirlines1.Forms.Administrator
{
    public partial class FlightScheduleManagement : Form
    {
        public FlightScheduleManagement()
        {
            InitializeComponent();
        }

        private bool isByCity = false;

        private string changeText = "";

        private DataTable dtDeparture;

        private DataColumn dc;

        private List<Schedule> schedulesList;

        private void InitDataTable()
        {
            dtDeparture = new DataTable();

            dtDeparture.Columns.Add("Date", Type.GetType("System.String"));
            dtDeparture.Columns.Add("Time", Type.GetType("System.String"));
            dtDeparture.Columns.Add("From", Type.GetType("System.String"));
            dtDeparture.Columns.Add("To", Type.GetType("System.String"));
            dtDeparture.Columns.Add("Aircraft", Type.GetType("System.String"));
            dtDeparture.Columns.Add("Economy Price", Type.GetType("System.String"));
            dtDeparture.Columns.Add("Flight Number", Type.GetType("System.String"));
            dtDeparture.Columns.Add("Gate", Type.GetType("System.String"));
            dtDeparture.Columns.Add("Status", Type.GetType("System.String"));

        }

        private void IniCombobox()
        {
            cbx_from.DataSource = null;
            cbx_to.DataSource = null;
            if (isByCity)
            {
                List<City> citiesFrom = FlightScheduleManagementDal.GetCitiesList();
                List<City> citiesTo = FlightScheduleManagementDal.GetCitiesList();
                cbx_from.DisplayMember = "CityName";
                cbx_from.ValueMember = "CityName";
                cbx_from.DataSource = citiesFrom;
                cbx_to.DisplayMember = "CityName";
                cbx_to.ValueMember = "CityName";
                cbx_to.DataSource = citiesTo;
                cbx_to.SelectedIndex = 0;
                cbx_from.SelectedIndex = 0;
            }
            else
            {
                List<Route> routesFrom = FlightScheduleManagementDal.GetDistinctDAIATA();
                List<Route> routesTo = FlightScheduleManagementDal.QueryAAIATAByDAIATA(routesFrom[0].DepartureAirportIATA);
                cbx_from.DisplayMember = "DepartureAirportIATA";
                cbx_from.ValueMember = "DepartureAirportIATA";
                cbx_from.DataSource = routesFrom;

                cbx_to.DisplayMember = "ArrivalAirportIATA";
                cbx_to.ValueMember = "ArrivalAirportIATA";
                cbx_to.DataSource = routesTo;

                cbx_to.SelectedIndex = 0;
                cbx_from.SelectedIndex = 0;
            }
        }

        private void BindDataTable()
        {
            if (isByCity)
            {
                schedulesList = FlightScheduleManagementDal.QueryByCityAndDate(
                    cbx_from.SelectedValue.ToString(),
                    cbx_to.SelectedValue.ToString(),
                    dtp_startDate.Value,
                    dtp_endDate.Value
                    );

                lbl_total.Text = "Total Schedule:"+schedulesList.Count;

            }
            else
            {
                schedulesList = FlightScheduleManagementDal.QueryByIATAAndDate(
                    cbx_from.SelectedValue.ToString(),
                    cbx_to.SelectedValue.ToString(),
                    dtp_startDate.Value,
                    dtp_endDate.Value
                    );
                lbl_total.Text = "Total Schedule:" + schedulesList.Count;
            }
            try
            {
                foreach (var scheduleitem in schedulesList)
                {
                    DataRow row = dtDeparture.NewRow();
                    row["Flight Number"] = scheduleitem.FlightNumber.ToString();
                    row["From"] = scheduleitem.Route.Airport.City.CityName + "/" + scheduleitem.Route.Airport.IATACode;
                    row["To"] = scheduleitem.Route.Airport1.City.CityName + "/" + scheduleitem.Route.Airport1.IATACode;
                    row["Date"] = scheduleitem.Date.ToString("yyyy-MM-dd");
                    row["Time"] = new DateTime(2020, 1, 1, scheduleitem.Time.Hours, scheduleitem.Time.Minutes, scheduleitem.Time.Seconds).ToString("HH:mm");
                    row["Aircraft"] = scheduleitem.Aircraft.Name;
                    row["Gate"] = scheduleitem.Gate;
                    row["Status"] = scheduleitem.Status;
                    row["Economy Price"] = scheduleitem.EconomyPrice.ToString();

                    dtDeparture.Rows.Add(row);
                }
                ClearTable();
                dgv_resultList.DataSource = dtDeparture.DefaultView;
                loopChangeTableItem();

            }
            catch (Exception)
            {
                MessageBox.Show("查询时发生异常");
                return;
            }
        }


        //private DataTable GetNewDataTable()
        //{
        //    DataTable dt = dtDeparture.Clone();
        //    for (int i = 10 * (nowPage - 1); i < ((nowPage * 10) > (dtDeparture.Rows.Count) ? (dtDeparture.Rows.Count) : (nowPage * 10)); i++)
        //    {
        //        dt.Rows.Add(dtDeparture.Rows[i].ItemArray);
        //    }
        //    return dt;
        //}

        private void ClearTable()
        {
            DataTable dt = dtDeparture.Clone();
            dgv_resultList.DataSource = dt;
        }

        private void FlightScheduleManagement_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“session1DataSet.Airport”中。您可以根据需要移动或删除它。
            this.airportTableAdapter.Fill(this.session1DataSet.Airport);

            IniCombobox();


            AllFun.CheckAllCtrls(this);
            AllFun.ReplaceByLanguageMode();
        }

        private void btn_Exchange_Click(object sender, EventArgs e)
        {
            if (isByCity)
            {
                int i = cbx_from.SelectedIndex;
                cbx_from.SelectedIndex = cbx_to.SelectedIndex;
                cbx_to.SelectedIndex = i;
            }
            else
            {
                changeText = cbx_from.SelectedValue.ToString();
                cbx_from.SelectedIndex = cbx_from.FindString(cbx_to.SelectedValue.ToString());
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            InitDataTable();
            BindDataTable();
        }

        private void cbx_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isByCity)
            { 
                changeText = "";
            }
            else
            {
                if (cbx_from.SelectedValue!=null)
                {
                    cbx_to.DataSource = FlightScheduleManagementDal.QueryAAIATAByDAIATA(cbx_from.Text);
                    cbx_to.DisplayMember = "ArrivalAirportIATA";
                    cbx_to.ValueMember = "ArrivalAirportIATA";
                    if (changeText!=""&&cbx_to.FindString(changeText)>=0)
                    {
                        cbx_to.SelectedIndex = cbx_to.FindString(changeText);
                    }
                    else
                    {
                        cbx_to.SelectedIndex = 0;
                        changeText = "";
                    }
                }
                
            }
        }

        private void loopChangeTableItem()
        {
            for (int i = 0;  i<dgv_resultList.Rows.Count;i++)
            {
                if (dgv_resultList.Rows[i].Cells[9].Value.ToString()=="Canceled")
                {
                    dgv_resultList.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void cbx_to_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (dgv_resultList.CurrentRow!=null)
            {
                FlightScheduleManagementDal.UpdateStatusByID(schedulesList[dgv_resultList.CurrentRow.Index]);
                InitDataTable();
                BindDataTable();
            }
        }

        private void rbtn_byAirport_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_byCity_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_byCity.Checked)
            {
                isByCity = true;
                IniCombobox();
            }
            else
            {
                isByCity = false;
                IniCombobox();
            }
        }

        private void dgv_resultList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    TicketSalesDetail detailUI = new TicketSalesDetail(schedulesList[e.RowIndex]);
                    detailUI.MdiParent = this.MdiParent;
                    detailUI.TopLevel = false;
                    detailUI.Parent = this.Parent;
                    detailUI.BringToFront();
                    detailUI.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误:"+ex);
            }
            
        }
    }
}
