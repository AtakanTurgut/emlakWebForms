using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace emlakWebForms.Classes
{
    public class ContactOperations
    {
        public static List<string> GetContactInfo()
        {
            SqlCommand commandGetContactInfo = new SqlCommand("Select * from TableContact where ContactId=@pid", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            commandGetContactInfo.Parameters.AddWithValue("@pid", 1);
            SqlDataReader drGetContactInfo = commandGetContactInfo.ExecuteReader();

            string c_mail = "";
            string c_phone = "";
            string c_adress = "";

            List<string> myList = new List<string>();

            while (drGetContactInfo.Read())
            {
                c_phone = drGetContactInfo[1].ToString();
                c_mail = drGetContactInfo[2].ToString();
                c_adress = drGetContactInfo[3].ToString();

                myList.Add(c_phone);
                myList.Add(c_mail);
                myList.Add(c_adress);
            }

            drGetContactInfo.Close();

            return myList;
        }
    }
}