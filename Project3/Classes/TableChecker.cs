using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utilities;

namespace Project3.Classes
{

    // this is going to be a class that checks to see if info for the table is actually present
    public static class TableChecker
    {
        static SqlCommand objCommand;
        static DBConnect objDB;

        // MAYBE MAKE A SINGLE FUNCTION TAT PULLS EVERYTHING IN ONE FOR THE TABLE CHECKER

        public static Boolean userExists(string username)
        {

            // this is how the command system works for it
            objCommand = new SqlCommand();
            
            objDB = new DBConnect();

            /*
            // if it comes back good for both 
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Test";
            */

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CheckUserName";

            SqlParameter input = new SqlParameter("@USERNAME", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);

            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static Boolean userLoginInfoCorrect(string username, string password)
        {
            
            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CheckUserAndPass";

            SqlParameter input = new SqlParameter("@USERNAME", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@PASSW", password);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);

            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
                return true;

        }

        public static Boolean profileExists(string username)
        {
            return false;
        }

        // do it based upon string usernames for these as well
        public static Boolean likeExists()
        {
            return false;
        }

        public static Boolean matchExists()
        {
            return false;
        }

        

    }
}