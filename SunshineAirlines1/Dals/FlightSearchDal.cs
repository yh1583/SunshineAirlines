using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineAirlines1.Dals
{
     public  class FlightSearchDal
    {
        private static MyDB mydb = new MyDB();

        public static List<Schedule> GetList(string fromCity,string toCity,DateTime depDate)
        {
            return mydb.Schedules.Where(o=>o.Route.Airport.CityCode==fromCity&&o.Route.Airport1.CityCode==toCity&&o.Date>=depDate.Date).ToList();
        }

        public static List<Schedule> GetStopList(string fromCity,DateTime depDate)
        {
            return mydb.Schedules.Where(o=>o.Route.Airport.CityCode==fromCity&&o.Date>=depDate.Date).ToList();
        }

        public static List<Schedule> GetStopList(string fromCity, string toCity, DateTime depDate)
        {
            DateTime time1 = depDate.AddHours(-2);
            DateTime time2 = depDate.AddHours(9);
            return mydb.Schedules.Where(o => o.Route.Airport.CityCode == fromCity && o.Route.Airport1.CityCode == toCity && o.Date >= time1.Date&&o.Date<=time2.Date&&o.Time>=time1.TimeOfDay&&o.Time<time2.TimeOfDay).ToList();
        }
    }
}
