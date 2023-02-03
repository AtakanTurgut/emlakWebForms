using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace emlakWebForms.Classes
{
    public class HoodOperation
    {
        public static DataTable BindDropDownHood(int id)
        {
            SqlCommand commandBindDropDownHood = new SqlCommand("Select * from TableHood where HoodCityId=@pid", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            commandBindDropDownHood.Parameters.AddWithValue("@pid", id);

            SqlDataAdapter da = new SqlDataAdapter(commandBindDropDownHood);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}