using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineAirlines1.Dals
{
    public class FlightStatusDal
    {
        private static MyDB mydb = new MyDB();
        
        public static List<Schedule> GetList(DateTime dt)
        {
            return mydb.Schedules.Where(e => e.Date == dt.Date).ToList();
        }
    }
}
