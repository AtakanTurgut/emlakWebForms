using emlakWebForms.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emlakWebForms
{
    public partial class AdminApproveProperty : System.Web.UI.Page
    {
        public SqlDataReader drProp;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsAdmin"]) != true)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                drProp = AdminOperations.AdminGetAllPropUnapproved();

                DataList1.DataSource = drProp;
                DataList1.DataBind();

                AdminOperations.drGetAllPropUnapproved.Close();
            }
        }
    }
}