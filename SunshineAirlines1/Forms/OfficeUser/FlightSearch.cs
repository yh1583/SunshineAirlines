using SunshineAirlines1.Dals;
using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines1.Forms.OfficeUser
{
    public partial class FlightSearch : Form
    {
        public FlightSearch()
        {
            InitializeComponent();
            backgroundSearchDelegate = new BackgroundSearchDelegate(BackgroundSearch);    // 实例化委托对象并指定调用的方法
        }

        private delegate void BackgroundSearchDelegate();

        private BackgroundSearchDelegate backgroundSearchDelegate;


        private Thread backgroundSearchThread;

        private DateTime selectDepTime = DateTime.MinValue;

        
        private DateTime selectRetTime = DateTime.MinValue;


        private void InvokeSearch()  // 调用非此线程创建的控件的操作必须用 Invoke 或 BeginInvoke .否则将抛出异常
        {
            btn_search.Invoke(backgroundSearchDelegate, null);
        }

        private void StopSearchThread()
        {
            if ((backgroundSearchThread != null) && (backgroundSearchThread.IsAlive))
            {
                backgroundSearchThread.Abort();
                backgroundSearchThread.Join();
            }
            backgroundSearchThread = null;
        }

        private void FlightSearch_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“session1DataSet.CabinType”中。您可以根据需要移动或删除它。
            this.cabinTypeTableAdapter.Fill(this.session1DataSet.CabinType);
            // TODO: 这行代码将数据加载到表“session1DataSet1.City”中。您可以根据需要移动或删除它。
            this.cityTableAdapter1.Fill(this.session1DataSet1.City);
            // TODO: 这行代码将数据加载到表“session1DataSet.City”中。您可以根据需要移动或删除它。
            this.cityTableAdapter.Fill(this.session1DataSet.City);

            cbx_flightType.SelectedIndex = 0;

            if (ConfigurationManager.AppSettings["fromCity"]!="")
            {
                cbx_fromCity.SelectedIndex = int.Parse(ConfigurationManager.AppSettings["fromCity"]);

                cbx_toCity.SelectedIndex = int.Parse(ConfigurationManager.AppSettings["toCity"]);
            }


            AllFun.CheckAllCtrls(this);
            AllFun.ReplaceByLanguageMode();
        }

        private void rbtn_one_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_round_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_round.Checked)
            {
                lbl_ret.Visible = true;
                dtp_ret.Visible = true;
            }
            else
            {
                lbl_ret.Visible = false;
                dtp_ret.Visible = false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            StopSearchThread();
            backgroundSearchThread = new Thread(new ThreadStart(InvokeSearch)); // 通过委托调用,合法
            backgroundSearchThread.IsBackground = true;
            backgroundSearchThread.Start();
        }

        private void BackgroundSearch()
        {
            selectDepTime = DateTime.MinValue;

            selectRetTime = DateTime.MinValue;

            RecordLasQuery();

            if (rbtn_one.Checked)
            {
                pan_ret.Controls.Clear();

                pan_dep.Controls.Clear();

                int y = 10;
                switch (cbx_flightType.SelectedIndex)
                {
                    case 0:
                        y = BuildNonStopDep(5, 10);
                        BuildStopDep(5, y);
                        break;
                    case 1:
                        BuildNonStopDep(5, 10);
                        break;
                    case 2:
                        BuildStopDep(5, y);
                        break;
                }
            }
            else
            {
                pan_ret.Controls.Clear();
                pan_dep.Controls.Clear();
                int y = 10;
                switch (cbx_flightType.SelectedIndex)
                {
                    case 0:
                        y = BuildNonStopDep(5, 10);
                        BuildStopDep(5, y);
                        break;
                    case 1:
                        BuildNonStopDep(5, 10);
                        break;
                    case 2:
                        BuildStopDep(5, y);
                        break;
                }
                y = 10;
                switch (cbx_flightType.SelectedIndex)
                {
                    case 0:
                        y = BuildNonStopDepAndRet(5, 10);
                        BuildStopDepAndRet(5, y);
                        break;
                    case 1:
                        BuildNonStopDepAndRet(5, 10);
                        break;
                    case 2:
                        BuildStopDepAndRet(5, y);
                        break;
                }
            }
        }

        private void BuildStopDepAndRet(int x, int y)
        {
            List<Schedule> schedulesList = FlightSearchDal.GetStopList(cbx_toCity.SelectedValue.ToString(), dtp_ret.Value);
            foreach (var schedule in schedulesList)
            {
                List<Schedule> schedulesStopList = FlightSearchDal.GetStopList(schedule.Route.Airport1.CityCode, cbx_fromCity.SelectedValue.ToString(), schedule.Date.Add(schedule.Time).AddMinutes(schedule.Route.FlightTime));
                if (schedulesStopList.Count != 0)
                {
                    foreach (var scheduleStop in schedulesStopList)
                    {
                        int totalsNumsOfTicketsBeforeTansfer = 0;
                        int totalsNumsOfTicketsAfterTansfer = 0;
                        float price = (float)(scheduleStop.EconomyPrice + schedule.EconomyPrice);
                        switch (cbx_cabinType.SelectedIndex)
                        {
                            case 0:
                                totalsNumsOfTicketsBeforeTansfer = schedule.Aircraft.EconomySeatsAmount;
                                totalsNumsOfTicketsAfterTansfer = scheduleStop.Aircraft.EconomySeatsAmount;
                                break;
                            case 1:
                                totalsNumsOfTicketsBeforeTansfer = schedule.Aircraft.BusinessSeatsAmount;
                                totalsNumsOfTicketsAfterTansfer = scheduleStop.Aircraft.BusinessSeatsAmount;
                                price = (float)(price * 1.25);
                                break;
                            case 2:
                                totalsNumsOfTicketsBeforeTansfer = schedule.Aircraft.FirstSeatsAmount;
                                totalsNumsOfTicketsAfterTansfer = scheduleStop.Aircraft.FirstSeatsAmount;
                                price = (float)(price * 1.25 * 1.5);
                                break;
                        }
                        int totalsNumsOfCabinTypeBeforeTansfer = 0;
                        int totalsNumsOfCabinTypeAfterTansfer = 0;
                        List<FlightReservation> flightReservationsListBeforeTansfer = FlightScheduleDal.GetListByScheduleID(schedule.ScheduleId).Where(o => o.CabinTypeId == cbx_cabinType.SelectedIndex + 1).ToList();
                        totalsNumsOfCabinTypeBeforeTansfer = flightReservationsListBeforeTansfer.Count;
                        List<Schedule> schedulesListBy30DayBeforeTansfer = FlightScheduleDal.GetListByFlightNumberAndDate(schedule);
                        List<FlightReservation> flightReservationsListAfterTansfer = FlightScheduleDal.GetListByScheduleID(scheduleStop.ScheduleId).Where(o => o.CabinTypeId == cbx_cabinType.SelectedIndex + 1).ToList();
                        totalsNumsOfCabinTypeAfterTansfer = flightReservationsListAfterTansfer.Count;
                        List<Schedule> schedulesListBy30AfterTansfer = FlightScheduleDal.GetListByFlightNumberAndDate(scheduleStop);
                        float rateBeforeTansfer = 1;
                        float rateAfterTansfer = 1;
                        int sumTimeBeforeTansfer = schedulesListBy30DayBeforeTansfer.Count;
                        int delayTimeBeforeTansfer = 0;
                        int sumTimeAfterTansfer = schedulesListBy30AfterTansfer.Count;
                        int delayTimeAfterTansfer = 0;

                        foreach (var schedule1 in schedulesListBy30DayBeforeTansfer)
                        {
                            try
                            {
                                DateTime dateTime = schedule1.Date.Add(schedule1.Time).AddMinutes(schedule1.Route.FlightTime).AddMinutes(15);
                                if (DateTime.Compare(dateTime, schedule1.FlightStatu.ActualArrivalTime) < 0)
                                {
                                    delayTimeBeforeTansfer++;
                                }
                            }
                            catch
                            {
                                continue;
                            }

                        }

                        foreach (var schedule2 in schedulesListBy30AfterTansfer)
                        {
                            try
                            {
                                DateTime dateTime = schedule2.Date.Add(schedule2.Time).AddMinutes(schedule2.Route.FlightTime).AddMinutes(15);
                                if (DateTime.Compare(dateTime, schedule2.FlightStatu.ActualArrivalTime) < 0)
                                {
                                    delayTimeAfterTansfer++;
                                }
                            }
                            catch
                            {

                                continue;
                            }

                        }


                        if (delayTimeBeforeTansfer == 0)
                        {
                            rateBeforeTansfer = 1;
                        }
                        else
                        {
                            rateBeforeTansfer -= ((float)delayTimeBeforeTansfer / (float)sumTimeBeforeTansfer);
                        }
                        if (delayTimeAfterTansfer == 0)
                        {
                            rateAfterTansfer = 1;
                        }
                        else
                        {
                            rateAfterTansfer -= ((float)delayTimeAfterTansfer / (float)sumTimeAfterTansfer);
                        }
                        StopUnit stopUnit = new StopUnit(
                            price,
                            cbx_cabinType.Text,
                            schedule.FlightNumber,
                            scheduleStop.FlightNumber,
                            rateBeforeTansfer,
                            rateAfterTansfer,
                            schedule.Route.Airport.City.CityName + "/" + schedule.Route.DepartureAirportIATA,
                            schedule.Route.Airport1.City.CityName + "/" + schedule.Route.ArrivalAirportIATA,
                            schedule.Date.Add(schedule.Time),
                            schedule.Date.Add(schedule.Time).AddMinutes(schedule.Route.FlightTime),
                            scheduleStop.Route.Airport.City.CityName + "/" + scheduleStop.Route.DepartureAirportIATA,
                            scheduleStop.Route.Airport1.City.CityName + "/" + scheduleStop.Route.DepartureAirportIATA,
                            scheduleStop.Date.Add(scheduleStop.Time),
                            scheduleStop.Date.Add(scheduleStop.Time).AddMinutes(scheduleStop.Route.FlightTime),
                            schedule.Route.FlightTime,
                            scheduleStop.Route.FlightTime,
                            (totalsNumsOfTicketsBeforeTansfer - totalsNumsOfCabinTypeBeforeTansfer) > (totalsNumsOfTicketsAfterTansfer - totalsNumsOfCabinTypeAfterTansfer) ? (totalsNumsOfTicketsAfterTansfer - totalsNumsOfCabinTypeAfterTansfer) : (totalsNumsOfTicketsBeforeTansfer - totalsNumsOfCabinTypeBeforeTansfer)
                            )
                        {
                            Location = new Point(x, y)
                        };
                        y += stopUnit.Height + 5;
                        pan_ret.Controls.Add(stopUnit);
                        RadioButton radio = stopUnit.Controls["rbtn_select"] as RadioButton;
                        radio.Name = schedule.ScheduleId + "_" + scheduleStop.ScheduleId;
                        if (radio != null)
                        {
                            radio.CheckedChanged += new EventHandler(rbtnRet_CheckedChanged);
                        }
                    }
                }
            }
        }

        private int BuildNonStopDepAndRet(int x, int y)
        {
            List<Schedule> schedulesList = FlightSearchDal.GetList(cbx_toCity.SelectedValue.ToString(), cbx_fromCity.SelectedValue.ToString(), dtp_ret.Value);
            foreach (var schedule in schedulesList)
            {
                int totalsNumsOfTickets = 0;
                float price = (float)schedule.EconomyPrice;
                switch (cbx_cabinType.SelectedIndex)
                {
                    case 0:
                        totalsNumsOfTickets = schedule.Aircraft.EconomySeatsAmount;
                       
                        break;
                    case 1:
                        totalsNumsOfTickets = schedule.Aircraft.BusinessSeatsAmount;
                        
                        price = (float)(price * 1.25);
                        break;
                    case 2:
                        totalsNumsOfTickets = schedule.Aircraft.FirstSeatsAmount;
                       
                        price = (float)(price * 1.25 * 1.5);
                        break;
                }
                int totalsNumsOfCabinType = 0;
                List<FlightReservation> flightReservationsList = FlightScheduleDal.GetListByScheduleID(schedule.ScheduleId).Where(o => o.CabinTypeId == cbx_cabinType.SelectedIndex + 1).ToList();
                totalsNumsOfCabinType = flightReservationsList.Count;
                List<Schedule> schedulesListBy30Day = FlightScheduleDal.GetListByFlightNumberAndDate(schedule);
                float rate = 1;
                int sumTime = schedulesListBy30Day.Count;
                int delayTime = 0;

                foreach (var schedule1 in schedulesListBy30Day)
                {
                    try
                    {
                        DateTime dateTime = schedule1.Date.Add(schedule1.Time).AddMinutes(schedule1.Route.FlightTime).AddMinutes(15);
                        if (DateTime.Compare(dateTime, schedule1.FlightStatu.ActualArrivalTime) < 0)
                        {
                            delayTime++;
                        }
                    }
                    catch
                    {

                        continue;
                    }

                }
                
              
                if (flightReservationsList.Count==0)
                {
                    continue;
                }
                if (delayTime==0)
                {
                    rate = 1;
                }
                else
                {
                    rate = rate - ((float)delayTime / (float)sumTime);
                }
                NonStopUnit nonStopUnit = new NonStopUnit(
                    price,
                    cbx_cabinType.Text,
                    schedule.FlightNumber,
                    rate,
                    schedule.Route.Airport.City.CityName + "/" + schedule.Route.DepartureAirportIATA,
                    schedule.Route.Airport1.City.CityName + "/" + schedule.Route.ArrivalAirportIATA,
                    schedule.Date.Add(schedule.Time),
                    schedule.Date.Add(schedule.Time).AddMinutes(schedule.Route.FlightTime),
                    schedule.Route.FlightTime,
                    totalsNumsOfTickets - totalsNumsOfCabinType
                    )
                {
                    Location = new Point(x, y)
                };
                y += nonStopUnit.Height + 5;
                pan_ret.Controls.Add(nonStopUnit);
                RadioButton radio = nonStopUnit.Controls["rbtn_select"] as RadioButton;
                radio.Name = schedule.ScheduleId.ToString();
                if (radio != null)
                {
                    radio.CheckedChanged += new EventHandler(rbtnRet_CheckedChanged);
                }
            }
            return y;
        }

        private void BuildStopDep(int x, int y)
        {
            List<Schedule> schedulesList = FlightSearchDal.GetStopList(cbx_fromCity.SelectedValue.ToString(), dtp_dep.Value);
            foreach (var schedule in schedulesList)
            {
                List<Schedule> schedulesStopList = FlightSearchDal.GetStopList(schedule.Route.Airport1.CityCode, cbx_toCity.SelectedValue.ToString(), schedule.Date.Add(schedule.Time).AddMinutes(schedule.Route.FlightTime));
                if (schedulesStopList.Count != 0)
                {
                    foreach (var scheduleStop in schedulesStopList)
                    {
                        int totalsNumsOfTicketsBeforeTansfer = 0;
                        int totalsNumsOfTicketsAfterTansfer = 0;
                        float price = (float)(schedule.EconomyPrice + scheduleStop.EconomyPrice);
                        switch (cbx_cabinType.SelectedIndex)
                        {
                            case 0:
                                totalsNumsOfTicketsBeforeTansfer = schedule.Aircraft.EconomySeatsAmount;
                                totalsNumsOfTicketsAfterTansfer = scheduleStop.Aircraft.EconomySeatsAmount;
                                break;
                            case 1:
                                totalsNumsOfTicketsBeforeTansfer = schedule.Aircraft.BusinessSeatsAmount;
                                totalsNumsOfTicketsAfterTansfer = scheduleStop.Aircraft.BusinessSeatsAmount;
                                price = (float)(price * 1.25);
                                break;
                            case 2:
                                totalsNumsOfTicketsBeforeTansfer = schedule.Aircraft.FirstSeatsAmount;
                                totalsNumsOfTicketsAfterTansfer = scheduleStop.Aircraft.FirstSeatsAmount;
                                price = (float)(price * 1.25 * 1.5);
                                break;
                        }
                        int totalsNumsOfCabinTypeBeforeTansfer = 0;
                        int totalsNumsOfCabinTypeAfterTansfer = 0;
                        List<FlightReservation> flightReservationsListBeforeTansfer = FlightScheduleDal.GetListByScheduleID(schedule.ScheduleId).Where(o => o.CabinTypeId == cbx_cabinType.SelectedIndex + 1).ToList();
                        totalsNumsOfCabinTypeBeforeTansfer = flightReservationsListBeforeTansfer.Count;
                        List<Schedule> schedulesListBy300DayBeforeTansfer = FlightScheduleDal.GetListByFlightNumberAndDate(schedule);
                        List<FlightReservation> flightReservationsListAfterTansfer = FlightScheduleDal.GetListByScheduleID(schedule.ScheduleId).Where(o => o.CabinTypeId == cbx_cabinType.SelectedIndex + 1).ToList();
                        totalsNumsOfCabinTypeAfterTansfer = flightReservationsListAfterTansfer.Count;
                        List<Schedule> schedulesListBy30AfterTansfer = FlightScheduleDal.GetListByFlightNumberAndDate(scheduleStop);
                        float rateBeforeTansfer = 1;
                        float rateAfterTansfer = 1;
                        int sumTimeBeforeTansfer = schedulesListBy300DayBeforeTansfer.Count;
                        int delayTimeBeforeTansfer = 0;
                        int sumTimeAfterTansfer = schedulesListBy30AfterTansfer.Count;
                        int delayTimeAfterTansfer = 0;

                        foreach (var schedule1 in schedulesListBy300DayBeforeTansfer)
                        {
                            try
                            {
                                DateTime dateTime = schedule1.Date.Add(schedule1.Time).AddMinutes(schedule1.Route.FlightTime).AddMinutes(15);
                                if (DateTime.Compare(dateTime, schedule1.FlightStatu.ActualArrivalTime) < 0)
                                {
                                    delayTimeBeforeTansfer++;
                                }

                            }
                            catch
                            {
                                continue;
                            }

                        }
                        foreach (var schedule2 in schedulesListBy30AfterTansfer)
                        {
                            try
                            {
                                DateTime dateTime = schedule2.Date.Add(schedule2.Time).AddMinutes(schedule2.Route.FlightTime).AddMinutes(15);
                                if (DateTime.Compare(dateTime, schedule2.FlightStatu.ActualArrivalTime) < 0)
                                {
                                    delayTimeAfterTansfer++;
                                }
                            }
                            catch
                            {
                                continue;
                            }

                        }
                    
                        
                        if (delayTimeBeforeTansfer == 0)
                        {
                            rateBeforeTansfer = 1;
                        }
                        else
                        {
                            rateBeforeTansfer -= ((float)delayTimeBeforeTansfer / (float)sumTimeBeforeTansfer);
                        }
                        if (delayTimeAfterTansfer == 0)
                        {
                            rateAfterTansfer = 1;
                        }
                        else
                        {
                            rateAfterTansfer -= ((float)delayTimeAfterTansfer / (float)sumTimeAfterTansfer);
                        }
                        StopUnit stopUnit = new StopUnit(
                            price,
                            cbx_cabinType.Text,
                            schedule.FlightNumber,
                            scheduleStop.FlightNumber,
                            rateBeforeTansfer,
                            rateAfterTansfer,
                            schedule.Route.Airport.City.CityName + "/" + schedule.Route.DepartureAirportIATA,
                            schedule.Route.Airport1.City.CityName + "/" + schedule.Route.ArrivalAirportIATA,
                            schedule.Date.Add(schedule.Time),
                            schedule.Date.Add(schedule.Time).AddMinutes(schedule.Route.FlightTime),
                            scheduleStop.Route.Airport.City.CityName + "/" + scheduleStop.Route.DepartureAirportIATA,
                            scheduleStop.Route.Airport1.City.CityName + "/" + scheduleStop.Route.DepartureAirportIATA,
                            scheduleStop.Date.Add(scheduleStop.Time),
                            scheduleStop.Date.Add(scheduleStop.Time).AddMinutes(scheduleStop.Route.FlightTime),
                            schedule.Route.FlightTime,
                            scheduleStop.Route.FlightTime,
                            (totalsNumsOfTicketsBeforeTansfer - totalsNumsOfCabinTypeBeforeTansfer) > (totalsNumsOfTicketsAfterTansfer - totalsNumsOfCabinTypeAfterTansfer) ? (totalsNumsOfTicketsAfterTansfer - totalsNumsOfCabinTypeAfterTansfer) : (totalsNumsOfTicketsBeforeTansfer - totalsNumsOfCabinTypeBeforeTansfer)
                            )
                        {
                            Location = new Point(x, y)
                        };
                        y += stopUnit.Height + 5;
                        pan_dep.Controls.Add(stopUnit);
                        RadioButton radio = stopUnit.Controls["rbtn_select"] as RadioButton;
                        radio.Name = schedule.ScheduleId + "_" + scheduleStop.ScheduleId;
                        if (radio != null)
                        {
                            radio.CheckedChanged += new EventHandler(rbtnDep_CheckedChange);
                        }
                    }
                }
            }
        }

        private int BuildNonStopDep(int x, int y)
        {
            List<Schedule> schedulesList = FlightSearchDal.GetList(cbx_fromCity.SelectedValue.ToString(), cbx_toCity.SelectedValue.ToString(), dtp_dep.Value);
            foreach (var schedule in schedulesList)
            {
                int totalsNumsOfTickets = 0;
                float price = (float)schedule.EconomyPrice;
                switch (cbx_cabinType.SelectedIndex)
                {
                    case 0:
                        totalsNumsOfTickets = schedule.Aircraft.EconomySeatsAmount;

                        break;
                    case 1:
                        totalsNumsOfTickets = schedule.Aircraft.BusinessSeatsAmount;

                        price = (float)(price * 1.25);
                        break;
                    case 2:
                        totalsNumsOfTickets = schedule.Aircraft.FirstSeatsAmount;

                        price = (float)(price * 1.25 * 1.5);
                        break;
                }
                int totalsNumsOfCabinType = 0;
                List<FlightReservation> flightReservationsList = FlightScheduleDal.GetListByScheduleID(schedule.ScheduleId).Where(o => o.CabinTypeId == cbx_cabinType.SelectedIndex + 1).ToList();
                totalsNumsOfCabinType = flightReservationsList.Count;
                List<Schedule> schedulesListBy30Day = FlightScheduleDal.GetListByFlightNumberAndDate(schedule);
                float rate = 1;
                int sumTime = schedulesListBy30Day.Count;
                int delayTime = 0;

                foreach (var schedule1 in schedulesListBy30Day)
                {
                    try
                    {
                        DateTime dateTime = schedule1.Date.Add(schedule1.Time).AddMinutes(schedule1.Route.FlightTime).AddMinutes(15);
                        if (DateTime.Compare(dateTime, schedule1.FlightStatu.ActualArrivalTime) < 0)
                        {
                            delayTime++;
                        }
                    }
                    catch
                    {
                        continue;

                    }

                }
                
               
                if (flightReservationsList.Count == 0)
                {
                    continue;
                }
                if (delayTime == 0)
                {
                    rate = 1;
                }
                else
                {
                    rate = rate - ((float)delayTime / (float)sumTime);
                }
                NonStopUnit nonStopUnit = new NonStopUnit(
                    price,
                    cbx_cabinType.Text,
                    schedule.FlightNumber,
                    rate,
                    schedule.Route.Airport.City.CityName + "/" + schedule.Route.DepartureAirportIATA,
                    schedule.Route.Airport1.City.CityName + "/" + schedule.Route.ArrivalAirportIATA,
                    schedule.Date.Add(schedule.Time),
                    schedule.Date.Add(schedule.Time).AddMinutes(schedule.Route.FlightTime),
                    schedule.Route.FlightTime,
                    totalsNumsOfTickets - totalsNumsOfCabinType
                    )
                {
                    Location = new Point(x, y)
                };
                y += nonStopUnit.Height + 5;
                pan_dep.Controls.Add(nonStopUnit);
                RadioButton radio = nonStopUnit.Controls["rbtn_select"] as RadioButton;
                radio.Name = schedule.ScheduleId.ToString();
                if (radio != null)
                {
                    radio.CheckedChanged += new EventHandler(rbtnDep_CheckedChange);
                }
            }
            return y;
        }

        private void RecordLasQuery()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["fromCity"].Value = cbx_fromCity.SelectedIndex.ToString();
            config.AppSettings.Settings["toCity"].Value = cbx_toCity.SelectedIndex.ToString();
            config.Save();
        }


        private void rbtnDep_CheckedChange(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                var unit = radio.Parent;
                if (unit is NonStopUnit)
                {
                    NonStopUnit nonStopUnit = unit as NonStopUnit;
                    foreach (Control cons in nonStopUnit.Controls)
                    {
                        foreach (Control control in cons.Controls)
                        {
                            if (control is Label && control.Name == "lbl_toDt")
                            {
                                selectDepTime = DateTime.Parse(control.Text);
                            }
                        }
                    }
                }
                else if (unit is StopUnit)
                {
                    StopUnit stopUnit = unit as StopUnit;
                    foreach (Control cons in stopUnit.Controls)
                    {
                        foreach (Control control in cons.Controls)
                        {
                            if (control is Label && control.Name == "lbl_toDt2")
                            {
                                selectDepTime = DateTime.Parse(control.Text);
                            }
                        }
                    }
                }
                foreach (Control item in pan_dep.Controls)
                {
                    foreach (Control control in item.Controls)
                    {
                        if (control is RadioButton)
                        {
                            if (radio.Name != control.Name)
                            {
                                RadioButton radioButton = control as RadioButton;
                                radioButton.Checked = false;
                            }
                        }
                    }
                }
                if (selectDepTime != DateTime.MinValue && selectRetTime != DateTime.MinValue && rbtn_round.Checked)
                {
                    if (DateTime.Compare(selectRetTime, selectDepTime) < 0)
                    {
                        MessageBox.Show("你选择的返程日期早于出发日期");
                    }
                }
            }
        }

        private void rbtnRet_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                var unit = radio.Parent;
                if (unit is NonStopUnit)
                {
                    NonStopUnit nonStopUnit = unit as NonStopUnit;
                    foreach (Control cons in nonStopUnit.Controls)
                    {
                        foreach (Control control in cons.Controls)
                        {
                            if (control is Label&&control.Name=="lbl_fromDt")
                            {
                                selectRetTime = DateTime.Parse(control.Text);
                            }
                        }
                    }
                }
                else if(unit is StopUnit)
                {
                    StopUnit stopUnit = unit as StopUnit;
                    foreach (Control cons in stopUnit.Controls)
                    {
                        foreach (Control control in cons.Controls)
                        {
                            if (control is Label && control.Name == "lbl_fromDt1")
                            {
                                selectRetTime = DateTime.Parse(control.Text);
                            }
                        }
                    }
                }
                foreach (Control item in pan_ret.Controls)
                {
                    foreach (Control control in item.Controls)
                    {
                        if (control is RadioButton)
                        {
                            if (radio.Name!=control.Name)
                            {
                                RadioButton radioButton = control as RadioButton;
                                radioButton.Checked = false;
                            }
                        }
                    }
                }
                if (selectDepTime!=DateTime.MinValue&&selectRetTime!=DateTime.MinValue&&rbtn_round.Checked)
                {
                    if (DateTime.Compare(selectRetTime,selectDepTime)<0)
                    {
                        MessageBox.Show("你选择的返程日期早于出发日期");
                    }
                }
            }
        }
    }
}
