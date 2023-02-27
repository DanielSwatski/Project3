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
            lblUser.Text = Request.Cookies["UserInfo"].Values["Username"] + ", we hope you find love, a friend, or marriage. Just dont be a weirdo!!!";
            btnSwticher = (Button)Master.FindControl("btnSwitcher");
            btnSwticher.Text = "GO!";
            btnSwticher.Click += new EventHandler(this.btnSwitcher_Click);

            if (!IsPostBack)
            {

                // maybe put this just inside the homepage
                try
                { 

                    // pulls the currently logged in user and sets all the lists and profile photos for them
                    DataSet ds = TableChecker.pullUserProfile(Request.Cookies["UserInfo"].Values["Username"]);

                    MessageBox.Show("PULLED USER and creating object file.");
                    // ds.Tables[0].Rows[0].ItemArray this is good
                    loggedInUser = new UserProfile(ds.Tables[0].Rows[0]);

                    imgProfilePhoto.ImageUrl = loggedInUser.ProfileUrl;
                    // image1.Attributes.Add("width", "800")
                    imgProfilePhoto.Attributes.Add("width", "100");
                    imgProfilePhoto.Attributes.Add("height", "100");
                    // need to locate the photo better on the page


                    lstBoxUserInfo.Items.Add(loggedInUser.Occupation);
                    lstBoxUserInfo.Items.Add(loggedInUser.Age.ToString());
                    lstBoxUserInfo.Items.Add(loggedInUser.Gender.ToString());
                    lstBoxUserInfo.Items.Add(loggedInUser.City);
                    lstBoxUserInfo.Items.Add(loggedInUser.Telephone);



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong with the read in from the databases: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Not Postback");
            }

        }

        protected void btnSwitcher_Click(object sender, EventArgs e)
        {
            String selected =  ddlThingsToDo.SelectedValue.ToString();

            // double check to make sure the cookie gets passed properly
            Response.Redirect(selected + ".aspx");



            
        }



    }
}