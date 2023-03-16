using Project3.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Project3.MainPages
{
    public partial class Search : System.Web.UI.Page
    {
        UserProfile loggedInUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = TableChecker.pullUserProfile(Request.Cookies["UserInfo"].Values["Username"]);

            loggedInUser = new UserProfile(ds.Tables[0].Rows[0]);
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            // work on exluding currently logged in user and if publicprofile = 1
            DataSet ds = TableChecker.searchUserProfiles(ddlSearchCategory.SelectedValue.ToString(), txtBoxArgs.Text);

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Picture", typeof(String))); //need to get the photos working properly
            dt.Columns.Add(new DataColumn("Username", typeof(String)));
            dt.Columns.Add(new DataColumn("Occupation", typeof(String)));
            dt.Columns.Add(new DataColumn("Age", typeof(int)));
            dt.Columns.Add(new DataColumn("City", typeof(String)));
            dt.Columns.Add(new DataColumn("descript", typeof(String)));

            foreach (DataRow cur in ds.Tables[0].Rows)
            {
                // check to see if the last element which is number 15 to see if something is public
                // cur.ItemArray[6]

                // when it fills the row make sure it pulls if its already been liked
                dt.Rows.Add(cur.ItemArray[6], cur.ItemArray[0], cur.ItemArray[1], cur.ItemArray[2], cur.ItemArray[3], cur.ItemArray[13]);
            }
           // dt.Rows.Add(ds.Tables[0].Rows[0].ItemArray[6], ds.Tables[0].Rows[0].ItemArray[0], ds.Tables[0].Rows[0].ItemArray[1], ds.Tables[0].Rows[0].ItemArray[2], ds.Tables[0].Rows[0].ItemArray[3], ds.Tables[0].Rows[0].ItemArray[13]);

            grdViewSearchResults.DataSource = dt;
            grdViewSearchResults.DataBind();
      
            

            // pull the shit by columns

           // UserProfile a = new UserProfile(ds.Tables[0].Rows[0]);
            // MessageBox.Show("Inside it");
        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            // go through the gridview and update the database if necessary

            foreach (GridViewRow row in grdViewSearchResults.Rows)
            {
                CheckBox chkRow = (row.Cells[0].FindControl("chkBoxLike") as CheckBox);

                // like a user
                if (chkRow.Checked)
                {
                    // make like
                    TableChecker.like(loggedInUser.Username, row.Cells[2].Text);
                }

                // unlike a user work on this later
                else
                {
                    TableChecker.unlike(loggedInUser.Username, row.Cells[2].Text);
                }
                
            }
        }

        protected void btnLike0_Click(object sender, EventArgs e)
        {
            Response.Redirect(ddlThingsToDo.SelectedValue.ToString() + ".aspx");
        }
    }
}