using emlakWebForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emlakWebForms
{
    public partial class ContactLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"]) != true)
            {
                Response.Redirect("Login.aspx");
            }

            var new_list = ContactOperations.GetContactInfo();

            contactMail.InnerHtml = new_list[1];
            contactPhone.InnerHtml = new_list[0];
            contactAdress.InnerHtml = new_list[2];
        }
    }
}