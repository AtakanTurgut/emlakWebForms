using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using emlakWebForms.Classes;

namespace emlakWebForms
{
    public partial class NonUserPropertyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var myId = Convert.ToInt32(Request.QueryString["selectedid"]);

            DataList1.DataSource = PropertyOperations.GetPropById(myId);
            DataList1.DataBind();

            PropertyOperations.drGetPropById.Close();
        }
    }
}