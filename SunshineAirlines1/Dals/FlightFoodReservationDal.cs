using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunshineAirlines1.Dals
{
    public class FlightFoodReservationDal
    {

        private static MyDB mydb = new MyDB();

        public static void ConifrmFoodReservation(FlightFoodReservation flightFoodReservation)
        {
            mydb.FlightFoodReservations.Add(flightFoodReservation);
            mydb.SaveChanges();
        }

        public static bool IsAlreadyExist(int value)
        {
            if (mydb.FlightFoodReservations.Where(o=>o.ReservationId==value).Count()>0)
            {
               return true;
            }
            else
            {
                return false;
            }
        }

        public static List<FlightFoodReservation> GetListByID(int value)
        {
            return mydb.FlightFoodReservations.Where(o => o.ReservationId == value).ToList();
        }

        public static void ModifyFood(List<FlightFoodReservation> ffrList)
        {
            int rID = ffrList[0].ReservationId;
            foreach (var item in mydb.FlightFoodReservations.Where(o=>o.ReservationId==rID).ToList())
            {
                mydb.FlightFoodReservations.Remove(item);
                mydb.SaveChanges();
            }
            foreach (var ffr in ffrList)
            {
                if (ffr.Amount!=0)
                {
                    mydb.FlightFoodReservations.Add(ffr);
                    mydb.SaveChanges();
                }
            }
        }

        public static void ClearFood(int value)
        {
            foreach (var item in mydb.FlightReservations.Where(o=>o.ReservationId==value).ToList())
            {
                mydb.FlightReservations.Remove(item);
                mydb.SaveChanges();
            }
        }

    }
}
