using Project3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project3.AccountPages
{
    public partial class ProfileCreation : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            // read in things from cookie to fill information
            // username - make it not changable

            // makes it so the username 
            try
            {
                txtBoxUsername.Text = Request.Cookies["UserInfo"].Values["Username"];
                txtBoxUsername.ReadOnly = true;
            }
            catch(Exception)
            {
                txtBoxUsername.Text = Request.Cookies["UserLog"].Values["Username"];
                txtBoxUsername.ReadOnly = true;
            }
            try {
                if (Request.Cookies["UserProfiles"] != null)
                {
                    txtBoxOccupation.Text = Request.Cookies["UserProfiles"].Values["Occupation"];
                    txtBoxAge.Text = Request.Cookies["UserProfiles"].Values["Age"];
                    txtBoxCity.Text = Request.Cookies["UserProfiles"].Values["City"];
                    txtBoxHeight.Text = Request.Cookies["UserProfiles"].Values["Height"];
                    txtBoxWeight.Text = Request.Cookies["UserProfiles"].Values["weigh"];
                    txtBoxProfileURL.Text = Request.Cookies["UserProfiles"].Values["ProfilePhoto"];
                    txtBoxDescription.Text = Request.Cookies["UserProfiles"].Values["descript"];
                    txtBoxPhone.Text = Request.Cookies["UserProfiles"].Values["Telephone"];


                    chkBoxFoods.SelectedValue = Request.Cookies["UserProfiles"].Values["FavoriteFood"];
                    chkBoxMusic.SelectedValue = Request.Cookies["UserProfiles"].Values["FavoriteGenre"];
                    chkBoxVacation.SelectedValue = Request.Cookies["UserProfiles"].Values["FavoriteVacation"];
                    ddlGender.SelectedValue = Request.Cookies["UserProfiles"].Values["Gender"];
                    ddlFavoritePet.SelectedValue = Request.Cookies["UserProfiles"].Values["FavoritePet"];
                    ddlCommitmentTypes.SelectedValue = Request.Cookies["UserProfiles"].Values["CommitmentType"];
                }
                // read in for editing from the main page
            }
            catch (Exception)
            {
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxOccupation.Text) ||
                String.IsNullOrEmpty(txtBoxProfileURL.Text) ||
                String.IsNullOrEmpty(txtBoxAge.Text) ||  int.TryParse(txtBoxAge.Text, out _) == false ||
                String.IsNullOrEmpty(txtBoxCity.Text) ||
                String.IsNullOrEmpty(txtBoxDescription.Text) ||
                String.IsNullOrEmpty(txtBoxPhone.Text) ||// Regex.IsMatch(txtBoxPhone.Text, @"/d{3}-/d{3}-/d{4}") ||
                String.IsNullOrEmpty(txtBoxWeight.Text) || int.TryParse(txtBoxWeight.Text, out _) == false ||
                String.IsNullOrEmpty(txtBoxHeight.Text) || int.TryParse(txtBoxHeight.Text, out _) == false

                )
            {
                Label1.Text = "Made mistake. Fix it somewhere";
            }
            else
            {

                    int i = TableChecker.insertUserProfiles(txtBoxUsername.Text, txtBoxOccupation.Text, int.Parse(txtBoxAge.Text), txtBoxCity.Text, float.Parse(txtBoxHeight.Text), float.Parse(txtBoxWeight.Text), txtBoxProfileURL.Text, ddlFavoritePet.SelectedValue.ToString(), chkBoxVacation.SelectedValue.ToString(), chkBoxMusic.SelectedValue.ToString(), chkBoxFoods.SelectedValue.ToString(), ddlGender.SelectedValue.ToString(), ddlCommitmentTypes.SelectedValue.ToString(), txtBoxDescription.Text, txtBoxPhone.Text);


                Response.Redirect("../MainPages/Homepage.aspx");

            }



        }
    }
}