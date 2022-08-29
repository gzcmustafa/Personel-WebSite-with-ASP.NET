using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt16(Request.QueryString["ID"]);
        TxtID.Enabled = false;
        TxtID.Text = id.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.Tbl_EgitimTableAdapter dt = new DataSetTableAdapters.Tbl_EgitimTableAdapter();
            //aşağıdaki yazılan kodlarda normalde DeneyimGetir metodunu kullanarak direk ilgili yerleri getirebilirdik
            //fakat biz bu getirme işlemini ID değişkenine göre yaptığımızdan dolayı DeneyimGetir metodu içine ID' değişkeninide yazıyoruz.
            TxtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].BASLIK;
            TxtAltbaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ALTBASLIK;
            TxtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
            TxtTarih.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].TARIH;
            TxtGenelNot.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].GNOT;


        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.Tbl_EgitimTableAdapter dt = new DataSetTableAdapters.Tbl_EgitimTableAdapter();
        dt.EgitimGuncelle(TxtBaslik.Text, TxtAltbaslik.Text, TxtAciklama.Text, TxtGenelNot.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
        Response.Redirect("AdminEgitimler.Aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.Tbl_EgitimTableAdapter dt = new DataSetTableAdapters.Tbl_EgitimTableAdapter();
        dt.EgitimGuncelle(TxtBaslik.Text, TxtAltbaslik.Text, TxtAciklama.Text, TxtGenelNot.Text, TxtTarih.Text, Convert.ToInt16(TxtID.Text));
        Response.Redirect("AdminEgitimler.Aspx");
    }
}