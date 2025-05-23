<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="otelim.Kategori.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Listeleme</h3>
    <a href="Create.aspx">Yeni Kayıt</a>
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="kategoriId" DataNavigateUrlFormatString="Delete.aspx?Id={0}" DataTextField="kategoriId" DataTextFormatString="Silme" HeaderText="Silme" Text="Silme" />
            <asp:HyperLinkField DataNavigateUrlFields="kategoriId" DataNavigateUrlFormatString="Edit.aspx?Id={0}" DataTextField="kategoriId" DataTextFormatString="Düzelt" HeaderText="Düzelt" Text="Düzelt" />
        </Columns>
    </asp:GridView>
</asp:Content>
