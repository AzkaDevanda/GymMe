using Project_Lab_PSD.Handlers;
using Project_Lab_PSD.Model;
using Project_Lab_PSD.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab_PSD.Controller
{
    public class UserController
    {
        public static Response<List<MsUser>> GetAllUser()
        {
            return UserHandler.GetAllUser();
        }

        public static Response<MsUser> LoginUser(string username, string password)
        {
            if(username == null || password == null)
            {
                return new Response<MsUser>(false, "All fields must be filled", null);
            }

            return UserHandler.LoginUser(username, password);
        }
        public static Response<MsUser> RegisterUser(string username, string userEmail, string userDob, string userGender,
            string userPassword, string conPassowrd)
        {
            string error = "";
            if(userPassword != conPassowrd)
            {
                error = "Password do not match";
            }
            return UserHandler.RegisterUser(username, userEmail, DateTime.Parse(userDob), userGender, "user", userPassword);
        }
    }
}