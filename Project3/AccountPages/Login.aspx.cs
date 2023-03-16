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
    public partial class logincur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // checks to see if the user and password combo exists in the table
            // MAY NEED TO CLEAR THE PARAMETERS COLLECTION EACH TIME YOU DO SOMETHING WITH IT OR REACREATE ANOTHER COMMMAND OBJECT
            // read through all the connection file to make sure you are using everything properly


            if (TableChecker.userLoginInfoCorrect(txtBosUserName.Text, txtBoxPassword.Text))
            {
               // MessageBox.Show("LOGGED IN");
                HttpCookie myCookie = new HttpCookie("UserInfo");
                myCookie.Values["Username"] = txtBosUserName.Text;
                Response.Cookies.Add(myCookie);

                // checks to see if a profile exists in the profile table
                if (TableChecker.userExists(txtBosUserName.Text))
                {
                    // MessageBox.Show("User is in the profile systme");
                    // need to do the cookie stuff here
                    Response.Redirect("../MainPages/HomePage.aspx");
                }
                else
                {
                    // MessageBox.Show("User does not have a profile");
                    // pass in some of the simple cookie info
                    Response.Redirect("ProfileCreation.aspx");


                }
            }
            else
            {
                // MessageBox.Show("NOT LOGGED IN");
            }

        }

        protected void btnSwitcher_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserCreation.aspx");
        }
    }
}