using Project_Lab_PSD.Model;
using Project_Lab_PSD.Modul;
using Project_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab_PSD.Handlers
{
    public class UserHandler
    {

        public static Response<List<MsUser>> GetAllUser()
        {
            List<MsUser> users = UserRepository.GetAllUser();

            return new Response<List<MsUser>>(true, "User Found", users);
        }

        public static Response<MsUser> RegisterUser(string username, string userEmail, DateTime userDob, string userGender
            , string userRole, String userPassword)
        {
            MsUser user = UserFactory.CreateUser(username, userEmail, userDob, userGender, userRole, userPassword);
            UserRepository.AddUser(user);
            return new Response<MsUser>(true, "Register Succsess,", user);
        }

        public static Response<MsUser> LoginUser(string username, string password)
        {
            MsUser user = UserRepository.GetUserByUsername(username);

            if (user == null)
            {
                return new Response<MsUser>(false, "User Not Found", null);
            }

            if(!user.Password.Equals(password))
            {
                return new Response<MsUser>(false, "Wrong Password", null);
            }
            return new Response<MsUser>(true, "Login Succsess", user);
        }

        public static Response<MsUser> GetUserById(int id)
        {
            MsUser user = UserRepository.GetUserById(id);

            if (user == null)
            {
                return new Response<MsUser>(false, "User not found", null);
            }

            return new Response<MsUser>(true, "User Found", user);
        }

 

    }

}