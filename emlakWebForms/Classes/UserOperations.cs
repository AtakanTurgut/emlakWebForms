using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace emlakWebForms.Classes
{
    public class UserOperations
    {
        public static void UserRegister(string temp_mail, string temp_name, string temp_surname, string temp_password)
        {
            SqlCommand commandRegister = new SqlCommand("Insert into TableUser (UserMail,UserName,UserSurname,UserPassword,UserRegisterDate) values (@pMail,@pName,@pSurname,@pPassword,@pDate)", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            commandRegister.Parameters.AddWithValue("@pMail", temp_mail);
            commandRegister.Parameters.AddWithValue("@pName", temp_name);
            commandRegister.Parameters.AddWithValue("@pSurname", temp_surname);
            commandRegister.Parameters.AddWithValue("@pPassword", sha256Converter.ComputeSha256Hash(temp_password));
            commandRegister.Parameters.AddWithValue("@pDate", DateTime.Now);

            commandRegister.ExecuteNonQuery();
        }

        public static DataTable UserLogin (string temp_mail, string temp_password)
        {
            SqlCommand commandLogin = new SqlCommand("Select * from TableUser where UserMail=@pMail and UserPassword=@pPass", sqlConnectionClass.connection);
            sqlConnectionClass.CheckConnection();

            commandLogin.Parameters.AddWithValue("@pMail", temp_mail);
            commandLogin.Parameters.AddWithValue("@pPass", sha256Converter.ComputeSha256Hash(temp_password));

            SqlDataAdapter da = new SqlDataAdapter(commandLogin);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}