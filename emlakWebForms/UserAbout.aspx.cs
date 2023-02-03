using emlakWebForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emlakWebForms
{
    public partial class UserAbout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"]) != true)
            {
                Response.Redirect("Login.aspx");
            }

            var newlist = AboutUserOperation.GetAboutUser();
            userName.InnerHtml = newlist[1];
            userSurname.InnerHtml = newlist[2];
            userMail.InnerHtml = newlist[0];
            userDate.InnerHtml = newlist[3];
            
        }
    }
}