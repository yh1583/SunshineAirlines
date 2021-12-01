using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineAirlines1.Dals
{
    public static class FlightScheduleManagementDal
    {
        private static MyDB mydb = new MyDB();

        public static List<City> GetCitiesList()
        {
            return mydb.Cities.ToList();
        }

        public static List<Route> GetDistinctDAIATA()
        {
            return mydb.Routes.DistinctBy(o => o.DepartureAirportIATA).ToList();
        }

        public static List<Route> QueryAAIATAByDAIATA(string DAIATA)
        {
            return mydb.Routes.Where(o => o.DepartureAirportIATA == DAIATA).ToList();
        }
        public static List<Schedule> QueryByCityAndDate(string from, string to, DateTime startDate, DateTime endDate)
        {
            return mydb.Schedules.Where(o => o.Date >= startDate.Date && o.Date <= endDate.Date && o.Route.Airport.City.CityName == from && o.Route.Airport1.City.CityName == to).ToList();
        }

        public static List<Schedule> QueryByIATAAndDate(string from, string to, DateTime startDate, DateTime endDate)
        {
            return mydb.Schedules.Where(o => o.Date >= startDate.Date && o.Date <= endDate.Date && o.Route.DepartureAirportIATA == from && o.Route.ArrivalAirportIATA == to).ToList();
        }


        public static void UpdateStatusByID(Schedule schedule)
        {
            var query = mydb.Schedules.Where(o => o.ScheduleId == schedule.ScheduleId).FirstOrDefault();
            query.Status = query.Status == "Confirmed" ? "Canceled" : "Confirmed";
            mydb.SaveChanges();
        }


        private static IEnumerable<TSource> DistinctBy<TSource, Tkey>(this IEnumerable<TSource> source, Func<TSource, Tkey> keySelector)
        {
            HashSet<Tkey> seenKeys = new HashSet<Tkey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
