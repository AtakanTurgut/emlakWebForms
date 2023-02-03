using emlakWebForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emlakWebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (UserOperations.UserLogin(tboxMail.Text, tboxPassword.Text).Rows.Count > 0)
            {
                if (tboxMail.Text == "admin@admin.com")
                {
                    Session["IsAdmin"] = true;
                    Session["UserMail"] = tboxMail.Text;

                    Response.Redirect("AdminMainPage.aspx");
                }
                else
                {
                    Session["IsUserOnline"] = true;
                    Session["UserMail"] = tboxMail.Text;

                    Response.Redirect("UserMainPage.aspx");
                }
            }
        }
    }
}