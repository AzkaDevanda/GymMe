using Project_Lab_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab_PSD.Repositories
{
    public class UserRepository
    {
        static MyDatabaseEntities3 db = new MyDatabaseEntities3();
        public static List<MsUser> GetAllUser()
        {
            return db.MsUsers.Where(u => u.UserRole.Equals("user")).ToList();
        }

        public static MsUser GetUserByUsername(string username)
        {
            return db.MsUsers.Where(u => u.UserName.Equals(username)).ToList().FirstOrDefault();
        }

        public static void AddUser(MsUser user)
        {
            db.MsUsers.Add(user);
            db.SaveChanges();
        }

        public static MsUser GetUserById(int id)
        {
            return db.MsUsers.Find(id);
        }

        public static bool UpdateUser(MsUser newUser)
        {
            MsUser oldUser = db.MsUsers.Find(newUser.userID);

            if (oldUser == null)
            {
                return false;
            }

            oldUser.UserName = newUser.UserName;
            oldUser.UserEmail = newUser.UserEmail;
            oldUser.UserDOB = newUser.UserDOB;
            oldUser.UserGender = newUser.UserGender;
            oldUser.UserRole = newUser.UserRole;
            oldUser.Password = newUser.Password;
            db.SaveChanges();
            
            return true;

        }

    }
}