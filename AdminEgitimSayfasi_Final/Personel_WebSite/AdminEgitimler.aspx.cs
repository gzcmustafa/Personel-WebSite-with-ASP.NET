using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.Tbl_EgitimTableAdapter dt = new DataSetTableAdapters.Tbl_EgitimTableAdapter();
        Repeater1.DataSource = dt.EgitimListele();
        Repeater1.DataBind();
    }
}