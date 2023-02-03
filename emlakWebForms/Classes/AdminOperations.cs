using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace emlakWebForms.Classes
{
    public class AdminOperations
    {
        public static SqlDataReader drGetAllPropUnapproved;

        public static SqlDataReader AdminGetAllPropUnapproved()
        {
            SqlCommand commandGetAllPropUnapproved = new SqlCommand("Select * from TableProperty where PropertyApprove=@pA", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            commandGetAllPropUnapproved.Parameters.AddWithValue("@pA", 0);

            drGetAllPropUnapproved = commandGetAllPropUnapproved.ExecuteReader();

            return drGetAllPropUnapproved;
        }

        public static void AdminApprove(int id)
        {
            SqlCommand commandApprove = new SqlCommand("Update TableProperty set PropertyApprove=@p1 where PropertyId=@pid", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            commandApprove.Parameters.AddWithValue("@p1", 1);
            commandApprove.Parameters.AddWithValue("@pid", id);

            commandApprove.ExecuteNonQuery();   
        }

        public static void AdminDeleteProperty(int id)
        {
            SqlCommand commandAdminDeleteProperty = new SqlCommand("Delete from TableProperty where PropertyId=@pid", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            commandAdminDeleteProperty.Parameters.AddWithValue("@pid", id);
            commandAdminDeleteProperty.ExecuteNonQuery();
        }
    }
}