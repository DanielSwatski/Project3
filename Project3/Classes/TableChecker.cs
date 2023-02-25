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
        static DataSet ds;

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
            objCommand.CommandText = "CHECKUSERPASS";
            SqlParameter input = new SqlParameter("@USERN", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@PASSW", password);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            ds = null;
            ds = objDB.GetDataSetUsingCmdObj(objCommand);

            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
                return true;

        }

        public static Boolean profileExists(string username)
        {
            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CHECKPROFILEINUSERPROFILE";

            SqlParameter input = new SqlParameter("@USERNAME", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            ds = null;
            ds = objDB.GetDataSetUsingCmdObj(objCommand);

            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static Boolean UserInUser(String username)
        {
            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "USERNAMEINUSER";

            SqlParameter input = new SqlParameter("@USERNAME", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            ds = null;
            ds = objDB.GetDataSetUsingCmdObj(objCommand);

            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public static int insertUserProfiles(String username, String occupation, int age, String city, float height, float weigh, String profilePhoto, String FavoritePet, String FavoriteVacation, String FavoriteGenre, String FavoriteFood, String gender, String commitment, String descript, String telephone)
        {
            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "INSERTINTOPROFILE";

            SqlParameter input = new SqlParameter("@USERNAME", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@USERNAME", occupation);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@OCCUPATION", occupation);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@AGE", age);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@CITY", city);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@HEIGHT", height);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.Float;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@WEIGHT", weigh);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.Float;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@PROFILEPHOTO", profilePhoto);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@FAVORITEPET", FavoritePet);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@FAVORITEVACATION", FavoriteVacation);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@FAVORITEGENRE", FavoriteGenre);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@FAVORITEFOOD", FavoriteFood);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@GENDER", gender);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@COMMITMENTTYPES", commitment);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@DESCRIPTION", descript);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@TELEPHONE", telephone);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            ds = null;
            int i = objDB.DoUpdate(objCommand);

            return i;
        }

        public static void insertIntoUsers(String username, String password, String Fullname, String Email)
        {
            // write this later
        }


        public static DataSet pullUserProfile(String username)
        {
            ds = new DataSet();

            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "PULLLUSERINFOFROMUSERPROFILES";

            SqlParameter input = new SqlParameter("@USERNAME", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);


            ds = objDB.GetDataSet(objCommand);
            return ds;

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