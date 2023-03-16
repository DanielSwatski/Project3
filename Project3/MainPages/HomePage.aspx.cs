using Project3.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace Project3.MainPages
{
    public partial class Homepag : System.Web.UI.Page
    {
        UserProfile loggedInUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = TableChecker.pullUserProfile(Request.Cookies["UserInfo"].Values["Username"]);

            loggedInUser = new UserProfile(ds.Tables[0].Rows[0]);

            imgProfilePhoto.ImageUrl = loggedInUser.ProfileUrl;
            // image1.Attributes.Add("width", "800")
            imgProfilePhoto.Attributes.Add("width", "100");
            imgProfilePhoto.Attributes.Add("height", "100");
            // need to locate the photo better on the page

            //Request.Cookies[""].Values[];


            lstBoxUserInfo.Text = loggedInUser.ToString();


            // pulls the new matches and dates into the repeater
            DBConnect objDB = new DBConnect();

            String strSQL = "SELECT * FROM Matches where User2 = '" + loggedInUser.Username + "' and SEEN = '0' ";

            rptNewMatches.DataSource = objDB.GetDataSet(strSQL);
            rptNewMatches.DataBind();

            objDB = new DBConnect();

            strSQL = "SELECT * FROM Dates where User2 = '" + loggedInUser.Username + "' and SEEN = '0' ";

            rptNewDates.DataSource = objDB.GetDataSet(strSQL);
            rptNewDates.DataBind();



            // pull the dates here

        }

        protected void btnSwitcher_Click(object sender, EventArgs e)
        {
            Response.Redirect(ddlThingsToDo.SelectedValue.ToString() + ".aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Pass in the objects from the profile creator

            HttpCookie addable = new HttpCookie("UserProfiles"); // pull user profiles info here
            DataSet userInfo = TableChecker.UserData(loggedInUser.Username);

            addable.Values["Occupation"] = userInfo.Tables[0].Rows[0].ItemArray[1].ToString();
            addable.Values["Age"] = userInfo.Tables[0].Rows[0].ItemArray[2].ToString();
            addable.Values["City"] = userInfo.Tables[0].Rows[0].ItemArray[3].ToString();
            addable.Values["Height"] = userInfo.Tables[0].Rows[0].ItemArray[4].ToString();
            addable.Values["weigh"] = userInfo.Tables[0].Rows[0].ItemArray[5].ToString();
            addable.Values["ProfilePhoto"] = userInfo.Tables[0].Rows[0].ItemArray[6].ToString();
            addable.Values["FavoritePet"] = userInfo.Tables[0].Rows[0].ItemArray[7].ToString();
            addable.Values["FavoriteVacation"] = userInfo.Tables[0].Rows[0].ItemArray[8].ToString();
            addable.Values["FavoriteGenre"] = userInfo.Tables[0].Rows[0].ItemArray[9].ToString();
            addable.Values["FavoriteFood"] = userInfo.Tables[0].Rows[0].ItemArray[10].ToString();
            addable.Values["Gender"] = userInfo.Tables[0].Rows[0].ItemArray[11].ToString();
            addable.Values["CommitmentType"] = userInfo.Tables[0].Rows[0].ItemArray[12].ToString();
            addable.Values["descript"] = userInfo.Tables[0].Rows[0].ItemArray[13].ToString();
            addable.Values["Telephone"] = userInfo.Tables[0].Rows[0].ItemArray[14].ToString();
            
            Response.Cookies.Add(addable);
            

            Response.Redirect("../AccountPages/ProfileCreation.aspx");
        }

        protected void btnHide_Click(object sender, EventArgs e)
        {
            // hide the profile
            TableChecker.ToggleProfile(loggedInUser.Username);

        }
    }
}