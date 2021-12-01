using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineAirlines1.Dals
{
    public class FlightScheduleDal
    {
        private static MyDB mydb = new MyDB();

        public static List<Schedule> GetListByMonth(DateTime date)
        {
            return mydb.Schedules.Where(o => o.Date.Year == date.Year && o.Date.Month == date.Month).ToList();
        }

        public static List<FlightReservation> GetListByScheduleID(int scheduleID)
        {
            return mydb.FlightReservations.Where(o => o.ScheduleId == scheduleID).ToList();
        }

        public static List<Schedule> GetListByFlightNumberAndDate(Schedule schedule)
        {
            DateTime dateTime = schedule.Date.AddDays(-30);
            return mydb.Schedules.Where(o => o.Date <= schedule.Date && o.Date >= dateTime && o.FlightNumber == schedule.FlightNumber).ToList();
        }
    }
}
