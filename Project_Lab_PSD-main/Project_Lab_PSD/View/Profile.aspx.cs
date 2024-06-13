using Project_Lab_PSD.Model;
using Project_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Project_Lab_PSD.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            else
            {
                MsUser user;
                if (Session["user"] == null)
                {
                    int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    user = UserRepository.GetUserById(id);
                    Session["user"] = user;
                }
                else
                {
                    user = (MsUser)Session["user"];
                }
            }

            MsUser currUser = Session["user"] as MsUser;

            if (!IsPostBack)
            {
                usernameTxt.Text = currUser.UserName;
                emailTxt.Text = currUser.UserEmail;
                genderList.SelectedValue = currUser.UserGender;
                dobTxt.Text = string.Format("{0:yyyy-MM-dd}", currUser.UserDOB);
            }
            
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            MsUser newUser = Session["user"] as MsUser;
            newUser.UserName = usernameTxt.Text;
            newUser.UserEmail = emailTxt.Text ;
            newUser.UserGender = genderList.Text;

            if (UserRepository.UpdateUser(newUser))
            {
                error.Text = "Update Succsess";
                error.ForeColor = Color.Green;
                
               
            }
            else
            {
                error.Text = "Update Failed";
            }
            
        }

        protected void resetPassBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/User/ResetPassword.aspx");
        }
    }
}