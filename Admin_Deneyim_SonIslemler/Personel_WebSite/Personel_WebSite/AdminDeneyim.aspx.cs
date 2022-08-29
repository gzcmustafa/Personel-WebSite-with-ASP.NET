using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeneyim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.Tbl_DeneyimTableAdapter dt = new DataSetTableAdapters.Tbl_DeneyimTableAdapter();
        Repeater1.DataSource = dt.DeneyimListele();
        Repeater1.DataBind();

    }
}