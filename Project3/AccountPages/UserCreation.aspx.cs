using Project3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Project3.AccountPages
{
    public partial class UserCreationCur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitInfo_Click(object sender, EventArgs e)
        {
            Boolean contin = true;
            if (String.IsNullOrEmpty(txtBosUserName.Text) ||
                String.IsNullOrEmpty(txtBoxEmail.Text) ||
                String.IsNullOrEmpty(txtBoxFullName.Text) ||
                String.IsNullOrEmpty(txtBoxPassword.Text))
            {
               // MessageBox.Show("Something is missing. FIX IT!!!!");
                contin = false;
            }

            if (contin)
            {
                // check to see if a username is currently in the table

                if (TableChecker.UserInUser(txtBosUserName.Text))
                {
                   // MessageBox.Show("USER IS ALREADY IN THE TABLE");
                }
                else
                {
                   // MessageBox.Show(" INSERT USER INTO DATABASE");
                    TableChecker.insertIntoUsers(txtBosUserName.Text, txtBoxPassword.Text, txtBoxFullName.Text, txtBoxEmail.Text);
                    HttpCookie addable = new HttpCookie("UserLog");
                    addable.Values["Username"] = txtBosUserName.Text;
                    Response.Cookies.Add(addable);
                    Response.Redirect("ProfileCreation.aspx");

                }

            }



        }

        protected void btnSwitcher_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}