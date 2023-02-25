using Project3.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Project3.MasterFiles
{
    public partial class NestedMasterPage1 : System.Web.UI.MasterPage
    {
        Button btnSwticher;
        UserProfile loggedInUser;
        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                lblUser.Text = Request.Cookies["UserInfo"].Values["Username"] + ", we hope you find love, a friend, or marriage. Just dont be a weirdo!!!";
                btnSwticher = (Button)Master.FindControl("btnSwitcher");
                btnSwticher.Text = "GO!";

                // pulls the currently logged in user and sets all the lists and profile photos for them
                DataSet ds = TableChecker.pullUserProfile(Request.Cookies["UserInfo"].Values["Username"]);

                MessageBox.Show("PULLED USER and creating object file." );
                // ds.Tables[0].Rows[0].ItemArray this is good
                loggedInUser = new UserProfile(ds.Tables[0].Rows[0]);

                imgProfilePhoto.ImageUrl = loggedInUser.ProfileUrl;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the read in from the databases: " + ex.Message);
            }


        }

        
    }
}