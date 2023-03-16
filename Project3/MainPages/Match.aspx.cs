using Project3.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project3.MainPages
{
    public partial class MatchNew : System.Web.UI.Page
    {

        UserProfile loggedInUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            // loads any potential matches from the logged in user into the table and gives them information about them
            reload();
        }

        protected void reload()
        {

            DataSet ds = TableChecker.pullUserProfile(Request.Cookies["UserInfo"].Values["Username"]);

            loggedInUser = new UserProfile(ds.Tables[0].Rows[0]);

            // checks to see if the matches exist for the logged in user and then will pull it

            // pulls all matches from database for the user


            // testing if it works

            // go through the list an only pull ones that are not logged in user
            // add more of these later
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("Picture", typeof(string)));
            dt.Columns.Add(new DataColumn("Username", typeof(string)));
            dt.Columns.Add(new DataColumn("Occupation", typeof(string)));
            dt.Columns.Add(new DataColumn("Age", typeof(int)));
            dt.Columns.Add(new DataColumn("City", typeof(string)));
            dt.Columns.Add(new DataColumn("Height", typeof(int)));
            dt.Columns.Add(new DataColumn("weigh", typeof(int)));

            dt.Columns.Add(new DataColumn("FavoritePet", typeof(string)));
            dt.Columns.Add(new DataColumn("FavoriteVacation", typeof(string)));
            dt.Columns.Add(new DataColumn("FavoriteGenre", typeof(string)));
            dt.Columns.Add(new DataColumn("FavoriteFood", typeof(string)));
            dt.Columns.Add(new DataColumn("Gender", typeof(string)));
            dt.Columns.Add(new DataColumn("CommitmentTypes", typeof(string)));
            dt.Columns.Add(new DataColumn("descript", typeof(string)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(string)));
            int counter = 0;
            foreach (DataRow cur in TableChecker.userData(loggedInUser.Username).Tables[0].Rows)
            {

                // goes through and checks if the element is not logged in and then appends it to the list
                if (cur.ItemArray[0].ToString().Equals(loggedInUser.Username) == false)
                {
                    DataSet inside = TableChecker.matchData(cur.ItemArray[0].ToString());
                    try
                    {
                        dt.Rows.Add(inside.Tables[0].Rows[counter].ItemArray[6], inside.Tables[0].Rows[counter].ItemArray[0], inside.Tables[0].Rows[counter].ItemArray[1], inside.Tables[0].Rows[counter].ItemArray[2], inside.Tables[0].Rows[counter].ItemArray[3], inside.Tables[0].Rows[counter].ItemArray[4], inside.Tables[0].Rows[counter].ItemArray[5], inside.Tables[0].Rows[counter].ItemArray[7], inside.Tables[0].Rows[counter].ItemArray[8], inside.Tables[0].Rows[counter].ItemArray[9], inside.Tables[0].Rows[counter].ItemArray[10], inside.Tables[0].Rows[counter].ItemArray[11], inside.Tables[0].Rows[counter].ItemArray[12], inside.Tables[0].Rows[counter].ItemArray[13], inside.Tables[0].Rows[counter].ItemArray[14]);

                        // sets the current match to being seen by the user
                        TableChecker.SeenMatch(loggedInUser.Username, inside.Tables[0].Rows[counter].ItemArray[0].ToString());
                    }
                    catch (Exception ex)
                    {

                    }
                    counter++;
                }
            }

            grdViewLikes.DataSource = dt;
            grdViewLikes.DataBind();
        }

        //match
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //match
            LinkButton btn = (LinkButton)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            //addable.Values["User1"] = grdViewDates.Rows[int.Parse(gvr.RowIndex.ToString())].Cells[0].Text;

            TableChecker.MakeMatch(loggedInUser.Username, grdViewLikes.Rows[int.Parse(gvr.RowIndex.ToString())].Cells[1].Text);
        }

        //unmatch
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;

            TableChecker.MakeUnMatch(loggedInUser.Username, grdViewLikes.Rows[int.Parse(gvr.RowIndex.ToString())].Cells[1].Text);
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            Response.Redirect(DropDownList1.SelectedValue + ".aspx");
        }

    }
}