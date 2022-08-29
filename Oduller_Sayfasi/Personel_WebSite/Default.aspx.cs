using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // DatasetTableAdapters'da oluşturduğumuz Tbl_Hakkımda'dan bir nesne oluşturuyoruz.
       DataSetTableAdapters.Tbl_HakkımdaTableAdapter dt = new DataSetTableAdapters.Tbl_HakkımdaTableAdapter();
        // Verileri dt nesnesinde bulunan metottan alır
        Repeater1.DataSource = dt.HakkımdaListele();
        //işlemi çalıştır - sonlandır anlamlarında kullanılır
        Repeater1.DataBind();

        DataSetTableAdapters.Tbl_DeneyimTableAdapter dt2 = new DataSetTableAdapters.Tbl_DeneyimTableAdapter();
        Repeater2.DataSource=dt2.DeneyimListele();
        Repeater2.DataBind();

        DataSetTableAdapters.Tbl_EgitimTableAdapter dt3 = new DataSetTableAdapters.Tbl_EgitimTableAdapter();
        Repeater3.DataSource=dt3.EgitimListele();
        Repeater3.DataBind();
        
        DataSetTableAdapters.Tbl_HobilerTableAdapter dt4 = new DataSetTableAdapters.Tbl_HobilerTableAdapter();
        Repeater4.DataSource=dt4.HobilerListele();
        Repeater4.DataBind();

        DataSetTableAdapters.Tbl_OdullerTableAdapter dt5 = new DataSetTableAdapters.Tbl_OdullerTableAdapter();
        Repeater5.DataSource=dt5.OdullerListele();
        Repeater5.DataBind();
        
     

     }
}