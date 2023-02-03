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
    public partial class NonUserPropertyPage : System.Web.UI.Page
    {
        public SqlDataReader drProp;
        protected void Page_Load(object sender, EventArgs e)
        {
            drProp = PropertyOperations.GetAllProp();

            DataList1.DataSource = drProp;
            DataList1.DataBind();

            PropertyOperations.drGetAllProp.Close();
        }
    }
}