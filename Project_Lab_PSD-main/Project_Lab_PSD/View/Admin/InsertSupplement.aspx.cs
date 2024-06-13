using Project_Lab_PSD.Model;
using Project_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab_PSD.View.Admin
{
    public partial class InsertSupplemeny : System.Web.UI.Page
    {
        MyDatabaseEntities3 db = new MyDatabaseEntities3();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<String> suppType = (from x in db.suplementTypeIds select x.SupplementTypeName).ToList();

                suppTypeList.DataSource = suppType;
                suppTypeList.DataBind();
            }

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            else
            {
                MsUser user;
                if (Session["user"] == null)
                { 
                    var id = Request.Cookies["user_cookie"].Value;
                    user = (from x in db.MsUsers where x.userID.ToString() == id select x).FirstOrDefault();
                    Session["user"] = user;
                }
                else
                {
                    user = (MsUser)Session["user"];

                }
            }
        }

        public int generateId()
        {
            int newId;
            int lastId = (from x in db.MsSupplements select x.SupplementID).ToList().LastOrDefault();
            if(lastId == 0)
            {
                newId = 1;
            }
            else
            {
                newId = lastId++;
            }
            return newId;
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            int newId = generateId();
            String newsuppName = suppNameTxt.Text.ToString();
            String newExpiryDate = suppExpiryTxt.Text.ToString();
            DateTime expiryDate = DateTime.Parse(newExpiryDate);
            int newPrice = Convert.ToInt32(suppPriceTxt.Text.ToString());
            String newTypeName = suppTypeList.Text.ToString();

            int newSupplementTypeID = (from x in db.suplementTypeIds where x.SupplementTypeName == newTypeName select x.SupplementTypeID)
                .FirstOrDefault();

            MsSupplement newSupp = SupplementFactory.CreateSupplement(newId, newsuppName, expiryDate, newPrice, newSupplementTypeID);
            SupplementRepository.AddSupplement(newSupp);

            Response.Redirect("~/View/HomePage.aspx");


        }
    }
}