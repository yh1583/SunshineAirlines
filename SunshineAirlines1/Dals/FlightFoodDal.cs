using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineAirlines1.Dals
{
    public class FlightFoodDal
    {


        private static MyDB mydb = new MyDB();


        public static List<FlightFood> GetList() 
        {
            return mydb.FlightFoods.ToList();
        }
    }

}
