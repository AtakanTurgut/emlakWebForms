using emlakWebForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emlakWebForms
{
    public partial class AdminRemoveComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                var my_id = Request.QueryString["selectedid"];

                AdminOperations.AdminDeleteProperty(Convert.ToInt32(my_id));
                Response.Redirect("AdminMainPage");
            }
        }
    }
}