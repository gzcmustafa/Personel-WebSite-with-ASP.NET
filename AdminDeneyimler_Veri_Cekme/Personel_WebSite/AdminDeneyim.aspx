<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminDeneyim.aspx.cs" Inherits="AdminDeneyim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <table class="table table-bordered">
        
        <tr>
            <th>ID</th>
            <th>BAŞLIK</th>
            <th>ALT BAŞLIK</th>
            <th>AÇIKLAMA</th>
            <th>TARİH</th>
        </tr>
        <tbody>
           
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID")%></td>
                        <td><%# Eval("BASLIK")%></td>
                        <td><%# Eval("ALTBASLIK")%></td>
                        <td><%# Eval("ACIKLAMA")%></td>
                        <td><%# Eval("TARİH")%></td>

                    </tr>                          
                </ItemTemplate>
            </asp:Repeater>

        </tbody>

    </table>


</asp:Content>

