using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace emlakWebForms.Classes
{
    public class sqlConnectionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R6K64T9\\SQLEXPRESS;Initial Catalog=emlakWebFormsDB;Integrated Security=True");

        public static void CheckConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {

            }
        }

    }
}