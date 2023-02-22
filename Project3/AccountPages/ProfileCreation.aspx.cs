using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Project3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Label lblPageTitle;
        Button btnSwitcher;

        // this page should only be able to get back to usercreation page
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPageTitle = (Label)Master.FindControl("lblPageTitle");
            lblPageTitle.Text = "Profile Creation";

            // hiding the button here so its easy for me to just use the user creation page
            btnSwitcher = (Button)Master.FindControl("btnSwitcher");
            btnSwitcher.Visible = false;



            // read in things from cookie to fill information
            // username - make it not changable

            // makes it so the username 
            try
            {
                txtBoxUsername.Text = Request.Cookies["UserInfo"].Values["Username"];
                txtBoxUsername.ReadOnly = true;
            }
            catch(Exception )
            {
                MessageBox.Show("Cookie is not there");
            }



        }

        // upload to the table 
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // either replace current or finish

            // check to see if everything is filled in properly
            int age;
            double weight;
            double height;

            

            // checks to see if any issue is present with the numbers or empty or anything imaginable that might be needed to control for errors
            if (String.IsNullOrEmpty(txtBoxOccupation.Text) ||
                String.IsNullOrEmpty(txtBoxProfileURL.Text) ||
                String.IsNullOrEmpty(txtBoxProfileURL.Text) ||
                String.IsNullOrEmpty(txtBoxAge.Text) || int.TryParse(txtBoxAge.Text, out age) ||
                String.IsNullOrEmpty(txtBoxCity.Text) ||
                String.IsNullOrEmpty(txtBoxDescripiton.Text) ||
                String.IsNullOrEmpty(txtBoxPhone.Text) || Regex.IsMatch(txtBoxPhone.Text, @"/d{3}-/d{3}-/d{4}") ||
                String.IsNullOrEmpty(txtBoxWeight.Text) || double.TryParse(txtBoxWeight.Text, out weight) ||
                String.IsNullOrEmpty(txtBoxHeight.Text) || double.TryParse(txtBoxHeight.Text, out height) 
                // need to check the ddls and lists and other stuff 
                
                )
            {
                MessageBox.Show("ALL INFO IS CORRECT");
            }
            else
            {
                MessageBox.Show("SOMETHING WENT WRONG. MAKE SURE EVERYTHING IS ENTERED IN PROPERLY. YOU MAY NEED TO MAKE SURE ALL THE DATA IS PROPERLY ENTERED AS NUMBER OR STRINGS AND IS NOT EMPTY");
            }


        }
    }
}