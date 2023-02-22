using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using Utilities;

namespace Project3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
         /* Label lblMasterStatus = (Label)Master.FindControl("lblStatus");

        lblMasterStatus.Text  = "Meaasage from content page";
        */

        // This is for the reference to the master in ecah object
        Label lblPageTitle;
        Button btnSwticher;

        protected void Page_PreRender(object sender, EventArgs e)
        {
            
            

            // need to figure out the button clicks to get it to work properly


            // cannot get an event handler working with this
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            // this is not gret code at the moment but it works well
            //btnSwitch_Click(btnSwtich, new EventArgs());
            lblPageTitle = (Label)Master.FindControl("lblPageTitle");
            lblPageTitle.Text = "User Creation";

            btnSwticher = (Button)Master.FindControl("btnSwitcher");
            btnSwticher.Text = "Switch to Login";
            btnSwticher.Click += new EventHandler(this.btnSwitcher_Click);
        }

        protected void btnSubmitInfo_Click(object sender, EventArgs e)
        {
            Boolean contin = true;
            if(String.IsNullOrEmpty(txtBosUserName.Text) || 
                String.IsNullOrEmpty(txtBoxEmail.Text) || 
                String.IsNullOrEmpty(txtBoxFullName.Text) ||
                String.IsNullOrEmpty(txtBoxPassword.Text))
            {
                MessageBox.Show("Something is missing. FIX IT!!!!");
                contin = false;
            }

            if (contin)
            {
                // check to see if a username is currently in the table
            }

           
            
        }


        // goes to the other aspx page 
        protected void btnSwitcher_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }



    }
}