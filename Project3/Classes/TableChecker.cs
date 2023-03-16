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
            objCommand.Parameters.Clear();


            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "INSERINTOPROFILE";

            SqlParameter input = new SqlParameter("@USERNAME", username);
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

            input = new SqlParameter("@COMMITMENTTPYES", commitment);
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

            int i = objDB.DoUpdate(objCommand);

            return i;
        }

        public static void insertIntoUsers(String username, String password, String Fullname, String Email)
        {
            // write this later
            objCommand = new SqlCommand();
            objDB = new DBConnect();
            objCommand.Parameters.Clear();


            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "INSERTINTOUSER";

            SqlParameter input = new SqlParameter("@USERNAME", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@PASSWORD", password);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@FULLNAME", Fullname);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@EMAIL", Email);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            int i = objDB.DoUpdate(objCommand);

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

        public static DataSet searchUserProfiles(String category, String arg)
        {
            ds = new DataSet();

            objCommand = new SqlCommand();
            objDB = new DBConnect();

            if (category.Equals("City"))
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "SEARCHUSERPORFILESCITY";

                SqlParameter input = new SqlParameter("@ARGS", arg);
                input.Direction = ParameterDirection.Input;
                input.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(input);

            }

            else if (category.Equals("Gender"))
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "SEARCHUSERPORFILESGENDER";

                SqlParameter input = new SqlParameter("@ARGS", arg);
                input.Direction = ParameterDirection.Input;
                input.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(input);

            }

            else if (category.Equals("Age"))
            {
                // age needs to split the string
                int age1 = int.Parse(arg.Split(' ')[0]);
                int age2 = int.Parse(arg.Split(' ')[1]);

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "SEARCHUSERPORFILESAGE";

                SqlParameter input = new SqlParameter("@AGE1", age1);
                input.Direction = ParameterDirection.Input;
                input.SqlDbType = SqlDbType.Int;
                objCommand.Parameters.Add(input);

                input = new SqlParameter("@AGE2", age2);
                input.Direction = ParameterDirection.Input;
                input.SqlDbType = SqlDbType.Int;
                objCommand.Parameters.Add(input);

                ds = objDB.GetDataSet(objCommand);
                return ds;
            }

            else
            {
                // commitmenttypes
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "SEARCHUSERPORFILESCOMMITMENT";

                SqlParameter input = new SqlParameter("@ARGS", arg);
                input.Direction = ParameterDirection.Input;
                input.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(input);
            }

            ds = objDB.GetDataSet(objCommand);
            return ds;
        }
        

        public static void ToggleProfile(string username)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TOGGLEPROFILE";

            objCommand.Parameters.Clear();
            SqlParameter input = new SqlParameter("@USERNAME", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            int i = objDB.DoUpdate(objCommand);

        }




        // do it based upon string usernames for these as well
        // these are actually well written procedures
        public static void like(String User1, String User2)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "LIKEUSER";

            objCommand.Parameters.Clear();
            SqlParameter input = new SqlParameter("@USERNAME1", User1);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@USERNAME2", User2);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            int i = objDB.DoUpdate(objCommand);
        }

        public static void unlike(String User1, String User2)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UNLIKEUSER";

            objCommand.Parameters.Clear();
            SqlParameter input = new SqlParameter("@USERNAME1", User1);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@USERNAME2", User2);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            int i = objDB.DoUpdate(objCommand);
        }



        // these two usernames work in tandom
        public static DataSet userData(String Username)
        {
            ds = new DataSet();

            objCommand = new SqlCommand();
            objDB = new DBConnect();


            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "USERMATCHES";

            SqlParameter input = new SqlParameter("@USER", Username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);



            ds = objDB.GetDataSet(objCommand);

            return ds;
        }

        public static DataSet matchData(String Username) {
            ds = new DataSet();

            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "PULLMATCHUSERPROFILE";

            SqlParameter input = new SqlParameter("@USER", Username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);



            ds = objDB.GetDataSet(objCommand);

            return ds;
        }


        public static void MakeMatch(String username1, String username2)
        {
            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "ACCEPTMATCH";

            SqlParameter input = new SqlParameter("@USERNAME1", username1);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@USERNAME2", username2);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);


            int i = objDB.DoUpdate(objCommand);

        }




        public static DataSet DateData(String username)
        {
            ds = new DataSet();

            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "PULLDATEDATA";

            SqlParameter input = new SqlParameter("@USERNAME", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);


            ds = objDB.GetDataSet(objCommand);

            return ds;

        }


        public static void UpdateDate(String username1, String username2, String Locat, String Time, String Descript)
        {
            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UPDATEDATE";

            SqlParameter input = new SqlParameter("@USER1", username1);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@USER2", username2);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@LOCAT", Locat);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@Time", Time);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@DESCRIPT", Descript);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);


            int i = objDB.DoUpdate(objCommand);


        }
        
        public static void removeDate(String user1, String user2)
        {
            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "REMOVEDATE";

            SqlParameter input = new SqlParameter("@USER1", user1);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@USER2", user2);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);


            int i = objDB.DoUpdate(objCommand);


        }

        public static void MakeUnMatch(String user1, String user2)
        {
            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "REMOVEMATCH";

            SqlParameter input = new SqlParameter("@USER1", user1);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@USER2", user2);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);


            int i = objDB.DoUpdate(objCommand);
        }


        public static DataSet UserData(String username)
        {
            ds = new DataSet();

            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "PULLALLUSERPROFILE";

            SqlParameter input = new SqlParameter("@USERNAME", username);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);


            ds = objDB.GetDataSet(objCommand);

            return ds;

        }


        public static void SeenMatch(String user1, String user2)
        {
            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SEENMATCH";

            SqlParameter input = new SqlParameter("@USER1", user1);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@USER2", user2);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);


            int i = objDB.DoUpdate(objCommand);

        }

        public static void SeenDate(String user1, String user2)
        {
            objCommand = new SqlCommand();
            objDB = new DBConnect();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SEENDATE";

            SqlParameter input = new SqlParameter("@USER1", user1);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);

            input = new SqlParameter("@USER2", user2);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(input);


            int i = objDB.DoUpdate(objCommand);
        }

    }
}