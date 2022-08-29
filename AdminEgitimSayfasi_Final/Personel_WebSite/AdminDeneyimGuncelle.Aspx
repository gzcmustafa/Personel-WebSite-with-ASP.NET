<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminDeneyimGuncelle.Aspx.cs" Inherits="AdminDeneyimGuncelle" %>

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
                <asp:Label ID="Label3" runat="server" Text="Açıklama"></asp:Label>
                <asp:TextBox ID="TxtAciklama" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
             <div>
                <asp:Label ID="Label4" runat="server" Text="Tarih"></asp:Label>
                <asp:TextBox ID="TxtTarih" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
             
    
           
            <br />
            <asp:Button ID="Button2" runat="server" Text="GÜNCELLE" CssClass="btn btn-success" OnClick="Button2_Click"/>

        </div>

    </form>
</asp:Content>

