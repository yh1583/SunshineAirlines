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
    public partial class TicketSalesDetail : Form
    {
        public TicketSalesDetail(Schedule schedule)
        {
            InitializeComponent();
            nowSchedule = schedule;
        }

        private Schedule nowSchedule;

        private int sumSeats = 0;

        private int firstTotal = 0;

        private int firstSold = 0;

        private int firstSelected = 0;

        private int businessTotal = 0;

        private int businessSold = 0;

        private int businessSelected = 0;

        private int economyTotal = 0;

        private int economySold = 0;

        private int economySelected = 0;

        private void TicketSalesDetail_Load(object sender, EventArgs e)
        {
            InitSeatList();

            lbl_detail.Text = nowSchedule.Route.Airport.IATACode + " to " + nowSchedule.Route.Airport1.IATACode + "," + nowSchedule.Date.ToString("yyyy-MM-dd") + "," + new DateTime(2020, 1, 1, nowSchedule.Time.Hours, nowSchedule.Time.Minutes, 0).ToString("HH:mm") + "," + nowSchedule.Aircraft.Name;

            if (nowSchedule.AircraftId==1)
            {
                img_aircraft.Image = Image.FromFile(Application.StartupPath+ @"\Images\Aircraft-Boeing 737-800.jpg");
            }
            else
            {
                img_aircraft.Image = Image.FromFile(Application.StartupPath + @"\Images\Aircraft-Airbus  319.jpg");
            }

            firstTotal = nowSchedule.Aircraft.FirstSeatsAmount;

            economyTotal = nowSchedule.Aircraft.EconomySeatsAmount;

            businessTotal = nowSchedule.Aircraft.BusinessSeatsAmount;

            List<FlightReservation> flightReservationsList = FlightReservationDal.QueryByScheduleID(nowSchedule.ScheduleId);

            economySold = flightReservationsList.Where(o => o.CabinTypeId == 1).ToList().Count;

            businessSold = flightReservationsList.Where(o => o.CabinTypeId == 2).ToList().Count;

            firstSold = flightReservationsList.Where(o => o.CabinTypeId == 3).ToList().Count;

            firstSelected = flightReservationsList.Where(o => o.CabinTypeId == 3 && o.SeatLayoutId != null).ToList().Count;

            businessSelected = flightReservationsList.Where(o => o.CabinTypeId == 2 && o.SeatLayoutId != null).ToList().Count;

            economySelected = flightReservationsList.Where(o => o.CabinTypeId == 1 && o.SeatLayoutId != null).ToList().Count;

            lbl_firstPoint.Text = string.Format("{0}/{1} {2}%",firstSold,firstTotal,(((float)firstSold/ (float)firstTotal)*100).ToString("F2"));

            lbl_firstTotal.Text = firstTotal.ToString();

            lbl_firstSold.Text = firstSold.ToString();

            lbl_firstSeat.Text = firstSelected.ToString();

            lbl_businessPoint.Text = string.Format("{0}/{1} {2}%", businessSold, businessTotal, (((float)businessSold / (float)businessTotal) * 100).ToString("F2"));

            lbl_businessTotal.Text = businessTotal.ToString();

            lbl_businessSold.Text = businessSold.ToString();

            lbl_businessSeat.Text = businessSelected.ToString();

            lbl_economyPoint.Text = string.Format("{0}/{1} {2}%", economySold, economyTotal, (((float)economySold / (float)economyTotal) * 100).ToString("F2"));

            lbl_economyTotal.Text = economyTotal.ToString();

            lbl_economySold.Text = economySold.ToString();

            lbl_economySeat.Text = economySelected.ToString();

            MarkSelectedSeat();


            AllFun.CheckAllCtrls(this);
            AllFun.ReplaceByLanguageMode();

        }

        private void MarkSelectedSeat()
        {
            List<FlightReservation> flightReservationsList = nowSchedule.FlightReservations.ToList();

            foreach (var flightReservation in flightReservationsList.Where(o=>o.CabinTypeId==3).ToList())
            {
                foreach (Button button in pan_first.Controls)
                {
                    if (flightReservation.SeatLayoutId!=null)
                    {
                        if (flightReservation.SeatLayout.RowNumber+flightReservation.SeatLayout.ColumnName==button.Text)
                        {
                            button.BackColor = Color.Orange;
                        }
                    }
                }
            }
            foreach (var flightReservation in flightReservationsList.Where(o => o.CabinTypeId == 2).ToList())
            {
                foreach (Button button in pan_business.Controls)
                {
                    if (flightReservation.SeatLayoutId != null)
                    {
                        if (flightReservation.SeatLayout.RowNumber + flightReservation.SeatLayout.ColumnName == button.Text)
                        {
                            button.BackColor = Color.Orange;
                        }
                    }
                }
            }
            foreach (var flightReservation in flightReservationsList.Where(o => o.CabinTypeId == 1).ToList())
            {
                foreach (Button button in pan_economy.Controls)
                {
                    if (flightReservation.SeatLayoutId != null)
                    {
                        if (flightReservation.SeatLayout.RowNumber + flightReservation.SeatLayout.ColumnName == button.Text)
                        {
                            button.BackColor = Color.Orange;
                        }
                    }
                }
            }
        }

        private void InitSeatList()
        {
            int aircraftID = nowSchedule.AircraftId;

            int rowSpacing = 10;

            int columnSpacing = 8;

            int cindex = 0;

            List<SeatLayout> seatLayoutList = nowSchedule.Aircraft.SeatLayouts.Where(o => o.CabinTypeId == 3 && o.AircraftId == aircraftID)
                .OrderByDescending(o => o.ColumnName).ToList();

            int index = 0;

            for (int i = 0; i < int.Parse(nowSchedule.Aircraft.FirstSeatsLayout.Split('*')[1]); i++)
            {
                for (int j = 0; j < int.Parse(nowSchedule.Aircraft.FirstSeatsLayout.Split('*')[0]); j++)
                {
                    Button button = new Button()
                    {
                        Size = new Size(50, 30),
                        Text = ++cindex + "" + seatLayoutList[index++].ColumnName,
                        Location=new Point(columnSpacing,rowSpacing)
                    };
                    columnSpacing += button.Width + 4;
                    pan_first.Controls.Add(button);
                }

                cindex = 0;

                columnSpacing = 8;

                rowSpacing += 35;

                if ((i+1)%2==0)
                {
                    rowSpacing += 5;
                }
            }


            rowSpacing = 5;

            columnSpacing = 10;

            seatLayoutList = nowSchedule.Aircraft.SeatLayouts.Where(o => o.CabinTypeId == 2 && o.AircraftId == aircraftID)
                .OrderByDescending(o => o.ColumnName).ToList();

            index = 0;

            for (int i = 0; i < int.Parse(nowSchedule.Aircraft.BusinessSeatsLayout.Split('*')[1]); i++)
            {
                cindex = 2;
                for (int j = 0; j < int.Parse(nowSchedule.Aircraft.BusinessSeatsLayout.Split('*')[0]); j++)
                {
                    Button button = new Button()
                    {
                        Size = new Size(40, 18),
                        Text = ++cindex + "" + seatLayoutList[index++].ColumnName,
                        Location = new Point(columnSpacing, rowSpacing)
                    };
                    columnSpacing += button.Width + 5;
                    pan_business.Controls.Add(button);
                }

                rowSpacing += 23;

                columnSpacing = 10;
                if ((i + 1) %3 == 0)
                {
                    rowSpacing += 5;
                }
            }


            rowSpacing = 5;

            columnSpacing = 10;

            seatLayoutList = nowSchedule.Aircraft.SeatLayouts.Where(o => o.CabinTypeId == 1 && o.AircraftId == aircraftID)
                .OrderByDescending(o => o.ColumnName).ToList();

            index = 0;

            for (int i = 0; i < int.Parse(nowSchedule.Aircraft.EconomySeatsLayout.Split('*')[1]); i++)
            {
                cindex = 12;
                for (int j = 0; j < int.Parse(nowSchedule.Aircraft.EconomySeatsLayout.Split('*')[0]); j++)
                {
                    Button button = new Button()
                    {
                        Size = new Size(40, 18),
                        Text = ++cindex + "" + seatLayoutList[index++].ColumnName,
                        Location = new Point(columnSpacing, rowSpacing)
                    };
                    columnSpacing += button.Width + 5;
                    pan_economy.Controls.Add(button);
                }

                rowSpacing += 23;

                columnSpacing = 10;
                if ((i + 1) % 3 == 0)
                {
                    rowSpacing += 5;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
