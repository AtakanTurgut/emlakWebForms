using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace emlakWebForms.Classes
{
    public class AboutUsOperation
    {
        public static string ListAboutUs()
        {
            SqlCommand cmdListAboutUs = new SqlCommand("Select * from TableAboutUs where AboutUsId=@pid", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();
            cmdListAboutUs.Parameters.AddWithValue("@pid", 1);

            SqlDataReader drListAboutUs = cmdListAboutUs.ExecuteReader();

            string myNewText = "";

            while (drListAboutUs.Read())
            {
                myNewText = drListAboutUs[1].ToString();
            }

            drListAboutUs.Close();

            return myNewText;
        }
    }
}