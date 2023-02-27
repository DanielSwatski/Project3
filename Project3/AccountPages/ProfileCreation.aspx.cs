using Microsoft.Graph;
using Project3.Classes;
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
            catch (Exception)
            {
                MessageBox.Show("Cookie is not there");
            }



        }

        // upload to the table 
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // either replace current or finish

            // check to see if everything is filled in properly
            // double check the below if statement to be 100 percent sure



            // checks to see if any issue is present with the numbers or empty or anything imaginable that might be needed to control for errors
            // need umerical checking later
            if (String.IsNullOrEmpty(txtBoxOccupation.Text) ||
                String.IsNullOrEmpty(txtBoxProfileURL.Text) ||
                String.IsNullOrEmpty(txtBoxProfileURL.Text) ||
                String.IsNullOrEmpty(txtBoxAge.Text) || // int.TryParse(txtBoxAge.Text, out age) ||
                String.IsNullOrEmpty(txtBoxCity.Text) ||
                String.IsNullOrEmpty(txtBoxDescripiton.Text) ||
                //String.IsNullOrEmpty(txtBoxPhone.Text) || Regex.IsMatch(txtBoxPhone.Text, @"/d{3}-/d{3}-/d{4}") ||
                String.IsNullOrEmpty(txtBoxWeight.Text) || //int.TryParse(txtBoxWeight.Text, out weight) ||
                String.IsNullOrEmpty(txtBoxHeight.Text) || //int.TryParse(txtBoxHeight.Text, out height) ||
                chkBoxFoods.SelectedIndex == -1 ||
                chkBoxMusic.SelectedIndex == -1 ||
                chkBoxVacation.SelectedIndex == -1
                
                )
            {
                MessageBox.Show("SOMETHING WENT WRONG. MAKE SURE EVERYTHING IS ENTERED IN PROPERLY. YOU MAY NEED TO MAKE SURE ALL THE DATA IS PROPERLY ENTERED AS NUMBER OR STRINGS AND IS NOT EMPTY");
            }
            else
            {
                MessageBox.Show("ALL INFO IS CORRECT");
                // need to check to either update the records or make news ones in it

                if (TableChecker.profileExists(txtBoxUsername.Text))
                {
                    // means that there is a profile so it updates
                    MessageBox.Show("USER IN PROFILE and will update AND NOT WORKING YET");
                    

                }
                else
                {
                    // means that there isnt a profile so it inserts into db
                    MessageBox.Show("USER NOT IN PROFILE and will insert but not working at the moment");
                    int i = TableChecker.insertUserProfiles(txtBoxUsername.Text, txtBoxOccupation.Text, int.Parse(txtBoxAge.Text), txtBoxCity.Text, float.Parse(txtBoxHeight.Text), float.Parse(txtBoxWeight.Text), txtBoxProfileURL.Text, ddlFavoritePet.SelectedValue.ToString(), chkBoxVacation.SelectedValue.ToString(), chkBoxMusic.SelectedValue.ToString(), chkBoxFoods.SelectedValue.ToString(), ddlGender.SelectedValue.ToString(), ddlCommintmentType.SelectedValue.ToString(), txtBoxDescripiton.Text, txtBoxPhone.Text);

                    if (i != -1)
                    {
                        MessageBox.Show("INSERTED");
                        Response.Redirect("../MainPages/HomePage.aspx");
                    }
                    else
                    {
                        MessageBox.Show("NOT INSERTED FOR SOME REASONT");
                    }
                }



            }


        }

    }
}