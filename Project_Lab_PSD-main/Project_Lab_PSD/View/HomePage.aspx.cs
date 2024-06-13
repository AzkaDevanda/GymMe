using Project_Lab_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab_PSD.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        private MyDatabaseEntities3 db = new MyDatabaseEntities3();
        protected void Page_Load(object sender, EventArgs e)
        {
            listUserContainer.Visible = false;
            adminUtlis.Visible = false;
            if (Session["user"] == null && Request.Cookies["user_cookie"]== null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            else
            {
                MsUser user;
                if (Session["user"]== null)
                {
                    var id = Request.Cookies["user_cookie"].Value;
                    user = (from x in db.MsUsers where x.userID.ToString() == id select x).FirstOrDefault();
                    Session["user"] = user;
                }
                else
                {
                    user = (MsUser) Session["user"];

                }

                name.Text = user.UserName;

                if (Application["user_count"] == null)
                {
                    UserLoggedinCount.Text = Application["count_user"] + " User(s) Online";
                }

                if (user.UserRole.Equals("admin"))
                {
                    listUserContainer.Visible = true;
                    adminUtlis.Visible = true;

                    var u = (from x in db.MsUsers select x);

                    foreach(var x in u)
                    {
                        listUser.Items.Add(x.UserName);
                    }

                }

            }
        }

        protected void logutButton_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;
            foreach(string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);

            }
            Application["count_user"] = ((int)Application["count_user"]) - 1;
            Session.Remove("user");
            Response.Redirect("~/View/Login.aspx");
        }

        protected void insertSuppBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Admin/InsertSupplement.aspx");
        }
    }
}