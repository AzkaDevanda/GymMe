using Project_Lab_PSD.Model;
using Project_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab_PSD.View.User
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resetPassBtn_Click(object sender, EventArgs e)
        {
            MsUser currUser = Session["user"] as MsUser;
            string oldPassword = oldPassTxt.Text.ToString();
            string newPassword = newPasswordTxt.Text.ToString();

            if(!currUser.Password.Equals(oldPassword))
            {
                error.Text = "Wrong Old Password";
                
            }
            else
            {
                currUser.Password = newPassword;
                if (UserRepository.UpdateUser(currUser))
                {
                    error.Text = "Succsess";
                    error.ForeColor = Color.Green;
                }
                
            }

        }
    }
}