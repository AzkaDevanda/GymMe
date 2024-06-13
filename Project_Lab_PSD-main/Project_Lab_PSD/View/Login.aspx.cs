using Project_Lab_PSD.Controller;
using Project_Lab_PSD.Model;
using Project_Lab_PSD.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab_PSD.View
{
    public partial class Login : System.Web.UI.Page
    {
        private MyDatabaseEntities3 db = new MyDatabaseEntities3();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String password = passwordTxt.Text;
            bool isRemember = rememberMe.Checked;

            

            var user = (from x in db.MsUsers where x.UserName.Equals(username) && 
                        x.Password.Equals(password) select x).FirstOrDefault();

            if(user != null)
            {
                Session["user"] = user;

                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.userID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }

                if (Application["count_user"] == null)
                {
                    Application["count_user"] = 1;
                
                }
                else
                {
                    Application["count_user"] = ((int)Application["count_user"]) + 1;
                }

                Response.Redirect("~/View/HomePage.aspx");
            }
            else
            {
                error.Text = "User not Found";
            }

        }
    }
}