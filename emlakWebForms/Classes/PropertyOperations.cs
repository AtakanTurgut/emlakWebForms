using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace emlakWebForms.Classes
{
    public class PropertyOperations
    {
        public static SqlDataReader drGetProp;
        public static SqlDataReader drGetPropById;
        public static SqlDataReader drGetAllProp;

        public static SqlDataReader GetAllProp()
        {
            SqlCommand commandLoadProperties = new SqlCommand("Select * from TableProperty where PropertyApprove=@pA", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            commandLoadProperties.Parameters.AddWithValue("@pA", 1);

            drGetAllProp = commandLoadProperties.ExecuteReader();
            
            return drGetAllProp;
        }

        public static SqlDataReader GetPropById(int fake_id)
        {
            SqlCommand cmdGetProperties = new SqlCommand("Select * from TableProperty where PropertyId=@pid ", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();
            cmdGetProperties.Parameters.AddWithValue("@pid", fake_id);

            drGetPropById = cmdGetProperties.ExecuteReader();

            return drGetPropById;
        }

        public static void AddProperty(string title, string price, int cityId, int hoodId, string type, string room, string photoLink)
        {
            SqlCommand commandAddProperty = new SqlCommand("Insert into TableProperty (PropertyTitle,PropertyPrice,PropertyCity,PropertyHood,PropertyType,PropertyRoom,PropertyPhotos) values (@pTT,@pP,@pC,@pH,@pT,@pR,@pPL)", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            commandAddProperty.Parameters.AddWithValue("@pTT", title); 
            commandAddProperty.Parameters.AddWithValue("@pP", price); 
            commandAddProperty.Parameters.AddWithValue("@pC", cityId); 
            commandAddProperty.Parameters.AddWithValue("@pH", hoodId); 
            commandAddProperty.Parameters.AddWithValue("@pT", type); 
            commandAddProperty.Parameters.AddWithValue("@pR", room); 
            commandAddProperty.Parameters.AddWithValue("@pPL", photoLink); 

            commandAddProperty.ExecuteNonQuery();
        }
    }
}