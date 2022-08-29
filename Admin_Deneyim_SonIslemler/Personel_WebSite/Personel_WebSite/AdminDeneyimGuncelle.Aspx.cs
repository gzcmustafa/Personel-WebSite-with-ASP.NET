using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeneyimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id=Convert.ToInt16(Request.QueryString["ID"]);
        TxtID.Enabled = false;
        TxtID.Text = id.ToString();

        if (Page.IsPostBack == false) { 
        DataSetTableAdapters.Tbl_DeneyimTableAdapter dt = new DataSetTableAdapters.Tbl_DeneyimTableAdapter();
        //aşağıdaki yazılan kodlarda normalde DeneyimGetir metodunu kullanarak direk ilgili yerleri getirebilirdik
        //fakat biz bu getirme işlemini ID değişkenine göre yaptığımızdan dolayı DeneyimGetir metodu içine ID' değişkeninide yazıyoruz.
        TxtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].BASLIK;
        TxtAltbaslik.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].ALTBASLIK;
        TxtAciklama.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
        TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].TARİH;


    }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {    
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        DataSetTableAdapters.Tbl_DeneyimTableAdapter dt = new DataSetTableAdapters.Tbl_DeneyimTableAdapter();
        dt.DeneyimGuncelle(TxtBaslik.Text, TxtAltbaslik.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
        Response.Redirect("AdminDeneyim.Aspx");
    }
}