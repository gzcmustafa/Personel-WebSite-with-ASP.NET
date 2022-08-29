using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {   
        DataSetTableAdapters.Tbl_EgitimTableAdapter dt = new DataSetTableAdapters.Tbl_EgitimTableAdapter();
        dt.EgitimEkle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtGenelNot.Text, TxtTarih.Text);
        Response.Redirect("AdminEgitimler.Aspx");

    }
}