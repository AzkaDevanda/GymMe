using Project_Lab_PSD.Controller;
using Project_Lab_PSD.Model;
using Project_Lab_PSD.Modul;
using Project_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab_PSD.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        static MyDatabaseEntities3 db = new MyDatabaseEntities3();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            String  username = usernameTxt.Text.ToString();
            String email = emailTxt.Text.ToString();
            String password = passwrodTxt.Text.ToString();
            String confirm_pass = cfPasswordTxt.Text.ToString();
            genderList.DataTextField = "male";
            genderList.DataTextField = "female";
            genderList.DataBind();
            String gender = genderList.Text.ToString();
            String dob = dobTxt.Text.ToString();

            Response<MsUser> res = UserController.RegisterUser(username, email, dob, gender, password, confirm_pass);

            if (!res.Success)
            {
                error.Text = res.Message;
                return;
            }
            Response.Redirect("~/View/Login.aspx");

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {

        }
    }
}