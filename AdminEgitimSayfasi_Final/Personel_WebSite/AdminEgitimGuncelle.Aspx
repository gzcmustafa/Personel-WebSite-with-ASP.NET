<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminEgitimGuncelle.Aspx.cs" Inherits="AdminEgitimGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

     <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="TxtID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
             <div>
                <asp:Label ID="Label2" runat="server" Text="Başlık"></asp:Label>
                <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label5" runat="server" Text="Alt Başlık"></asp:Label>
                <asp:TextBox ID="TxtAltbaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
               <div>
                <asp:Label ID="Label6" runat="server" Text="Açıklama"></asp:Label>
                <asp:TextBox ID="TxtAciklama" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
             <div>
                <asp:Label ID="Label3" runat="server" Text="Genel Not Ortalaması"></asp:Label>
                <asp:TextBox ID="TxtGenelNot" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
             <div>
                <asp:Label ID="Label4" runat="server" Text="Tarih"></asp:Label>
                <asp:TextBox ID="TxtTarih" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
             
    
           
            <br />
            <asp:Button ID="Button1" runat="server" Text="KAYDET" OnClick="Button1_Click" />

        </div>

    </form>


</asp:Content>

