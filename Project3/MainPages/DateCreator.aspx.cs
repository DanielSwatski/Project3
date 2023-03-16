using Project3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project3.MainPages
{
    public partial class DateCreator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtBoxUser1.Text = Request.Cookies["Date"].Values["User1"];
                txtBoxUser2.Text = Request.Cookies["Date"].Values["User2"];
                txtBoxDescription.Text = Request.Cookies["Date"].Values["Descript"];
                txtBoxTime.Text = Request.Cookies["Date"].Values["Time"];
                txtBoxDate.Text = Request.Cookies["Date"].Values["Locat"];
                // fill out the rest of the details from the stored procedure
            }

        }



        protected void btnAccept_Click(object sender, EventArgs e)
        {
            // pass in the logged in user
            TableChecker.UpdateDate(txtBoxUser1.Text, txtBoxUser2.Text, txtBoxDate.Text, txtBoxTime.Text, txtBoxDescription.Text);
        }
    }
}