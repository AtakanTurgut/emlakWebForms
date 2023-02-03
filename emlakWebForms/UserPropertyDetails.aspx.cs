using emlakWebForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emlakWebForms
{
    public partial class UserPropertyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"]) != true)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                var myId = Convert.ToInt32(Request.QueryString["selectedid"]);

                DataList1.DataSource = PropertyOperations.GetPropById(myId);
                DataList1.DataBind();

                PropertyOperations.drGetPropById.Close();
            }
        }
    }
}