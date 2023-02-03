using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace emlakWebForms.Classes
{
    public class AboutUserOperation
    {
        public static List<string> GetAboutUser()
        {
            SqlCommand cmdListAboutUserAbout = new SqlCommand("Select * from TableUser where UserId=@puserid", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            cmdListAboutUserAbout.Parameters.AddWithValue("@puserid", 2);

            SqlDataReader drGetAboutUserAbout = cmdListAboutUserAbout.ExecuteReader();
            string c_mail = "";
            string c_name = "";
            string c_surname = "";
            string c_date = "";

            List<string> myList = new List<string>();

            while (drGetAboutUserAbout.Read())
            {
                c_mail = drGetAboutUserAbout[1].ToString();
                c_name = drGetAboutUserAbout[2].ToString();
                c_surname = drGetAboutUserAbout[3].ToString();
                c_date = drGetAboutUserAbout[5].ToString();

                myList.Add(c_mail);
                myList.Add(c_name);
                myList.Add(c_surname);
                myList.Add(c_date);
            }

            drGetAboutUserAbout.Close();

            return myList;
        }
    }
}