using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace emlakWebForms.Classes
{
    public class CityOperation
    {
        public static DataTable BindDropDownCity()
        {
            SqlCommand commandBindDropDownCity = new SqlCommand("Select * from TableCity", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            SqlDataAdapter da = new SqlDataAdapter(commandBindDropDownCity);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}