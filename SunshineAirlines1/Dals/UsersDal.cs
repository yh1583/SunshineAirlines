using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunshineAirlines1.Models;

namespace SunshineAirlines1.Dals
{
    public class UsersDal
    {
        private static MyDB mydb = new MyDB();
        public static User QueryUsersByEmail(string email)
        {
            return mydb.Users.Where(e => e.Email == email).FirstOrDefault();
        }

        public static List<User> GetUserList(string name,int roleID)
        {
            if (roleID==0)
            {
                return mydb.Users.Where(o => (o.FirstName + o.LastName).Contains(name)).ToList();
            }
            else
            {
                return mydb.Users.Where(o => (o.FirstName + o.LastName).Contains(name)&&o.RoleId==roleID).ToList();
            }
        }
        public static int RegistAcount(User user)
        {
            try
            {
                mydb.Users.Add(user);
                mydb.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
           
        }

        public static int UpdateAcount(User user)
        {
            try
            {
                var query = mydb.Users.Where(o => o.UserId == user.UserId).FirstOrDefault();
                query.Address = user.Address;
                query.DateOfBirth = user.DateOfBirth;
                query.Email = user.Email;
                query.FirstName = user.FirstName;
                query.Gender = user.Gender;
                query.LastName = user.LastName;
                query.Password = user.Password;
                query.Phone = user.Phone;
                query.Photo = user.Photo;
                query.RoleId = user.RoleId;
                mydb.SaveChanges();
                return 1;
            }
            catch 
            {
                return 0;
            }
        }

    }
}
