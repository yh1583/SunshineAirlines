using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineAirlines1.Dals
{
    public class FlightReservationDal
    {
        private static MyDB mydb = new MyDB();

        public static List<FlightReservation> FindById(string id)
        {
            return mydb.FlightReservations.Where(o => o.IDTypeNumber == id && o.CabinTypeId != 1).ToList();
        }

        public static List<FlightReservation> QueryByScheduleID(int ScheduleID)
        {
            return mydb.FlightReservations.Where(o => o.ScheduleId == ScheduleID).ToList();
        }

        public static DateTime QueryDateTimeByRID(string id)
        {
            var query = (from fr in mydb.FlightReservations join sc in mydb.Schedules on fr.ScheduleId equals sc.ScheduleId where fr.ReservationId.ToString() == id select sc).FirstOrDefault();
            if (query!=null)
            {
                DateTime date = query.Date;
                date.AddHours(query.Time.Hours);
                date.AddMinutes(query.Time.Minutes);
                date.AddSeconds(query.Time.Seconds);
                return date;
            }
            else
            {
                return DateTime.MinValue;
            }
        }
    }
}
