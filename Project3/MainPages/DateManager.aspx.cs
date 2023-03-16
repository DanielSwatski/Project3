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
    public partial class DateManager : System.Web.UI.Page
    {
        UserProfile loggedInUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = TableChecker.pullUserProfile(Request.Cookies["UserInfo"].Values["Username"]);

            loggedInUser = new UserProfile(ds.Tables[0].Rows[0]);

            reload(); // check this function for working
        }

        protected void reload()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("User1", typeof(string)));
            dt.Columns.Add(new DataColumn("User2", typeof(string)));
            dt.Columns.Add(new DataColumn("Locat", typeof(string)));
            dt.Columns.Add(new DataColumn("Time", typeof(string)));
            dt.Columns.Add(new DataColumn("Descript", typeof(string)));

            DataSet date = TableChecker.DateData(loggedInUser.Username);

            foreach (DataRow cur in date.Tables[0].Rows)
            {
                // checks if the user is the same as the other users username or your username

                dt.Rows.Add(cur.ItemArray[0].ToString(), cur.ItemArray[1].ToString(), cur.ItemArray[2].ToString(), cur.ItemArray[3].ToString(), cur.ItemArray[4].ToString());

                // sets SEEN to 1 meaning its been seen
                TableChecker.SeenDate(loggedInUser.Username, cur.ItemArray[1].ToString());
            }

            grdViewDates.DataSource = dt;
            grdViewDates.DataBind();
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            GridViewRow gvr= (GridViewRow)btn.NamingContainer;
           // MessageBox.Show(gvr.RowIndex.ToString());


            // adds the date info from the button in the selected cookie
            HttpCookie addable = new HttpCookie("Date");
            addable.Values["User1"] = grdViewDates.Rows[int.Parse(gvr.RowIndex.ToString())].Cells[0].Text;
            addable.Values["User2"] = grdViewDates.Rows[int.Parse(gvr.RowIndex.ToString())].Cells[1].Text;
            addable.Values["Locat"] = grdViewDates.Rows[int.Parse(gvr.RowIndex.ToString())].Cells[2].Text;
            addable.Values["Time"] = grdViewDates.Rows[int.Parse(gvr.RowIndex.ToString())].Cells[3].Text;
            addable.Values["Descript"] = grdViewDates.Rows[int.Parse(gvr.RowIndex.ToString())].Cells[4].Text;
            Response.Cookies.Add(addable);

            

            Response.Redirect("DateCreator.aspx");
        }

        // removes the date
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;


            // removes all dates from system

            TableChecker.removeDate(grdViewDates.Rows[int.Parse(gvr.RowIndex.ToString())].Cells[0].Text, grdViewDates.Rows[int.Parse(gvr.RowIndex.ToString())].Cells[1].Text);




        }

        protected void grdViewDates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            Response.Redirect(DropDownList1.SelectedValue+".aspx");
        }
    }
}