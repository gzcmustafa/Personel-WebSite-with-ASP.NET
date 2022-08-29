using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hakkımda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack==false)
        {
            DataSetTableAdapters.Tbl_HakkımdaTableAdapter dt = new DataSetTableAdapters.Tbl_HakkımdaTableAdapter();
            TextBox1.Text = dt.HakkımdaListele()[0].AD; // [0] demek ilk aldığı indeks
            TextBox2.Text = dt.HakkımdaListele()[0].SOYAD;
            TextBox3.Text = dt.HakkımdaListele()[0].ADRES;
            TextBox4.Text = dt.HakkımdaListele()[0].MAIL;
            TextBox5.Text = dt.HakkımdaListele()[0].TELEFON;
            TextBox6.Text = dt.HakkımdaListele()[0].KISANOT;
            TextBox7.Text = dt.HakkımdaListele()[0].FOTOGRAF;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.Tbl_HakkımdaTableAdapter dt2 = new DataSetTableAdapters.Tbl_HakkımdaTableAdapter();
        dt2.HakkımdaGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
        Response.Redirect("Default.Aspx"); //Defaul.Aspx Sayfasına yönlendirme yapar.
        
    }
}