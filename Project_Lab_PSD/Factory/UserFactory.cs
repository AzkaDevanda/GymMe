using Project_Lab_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab_PSD.Repositories
{
    public class UserFactory
    {

        public static MsUser CreateUser(string username, string userEmail, DateTime userDob, string userGender, string userRole, string userPassword)
        {
            return new MsUser()
            {
                UserName = username,
                UserEmail = userEmail,
                UserGender = userGender,
                UserDOB = userDob,
                UserRole = userRole,
                Password = userPassword

            };
        }

        public static MsUser UpdateUser(string username, string userEmail, DateTime userDob, string userGender)
        { 
            return new MsUser()
            {
                UserName = username,
                UserEmail = userEmail,
                UserGender = userGender,
                UserDOB = userDob,
                

            };
        }
     } 
}