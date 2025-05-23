<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="otelim.Uyelik.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <a href="Create.aspx">Yeni Kayıt</a>
    <asp:GridView ID="GridView1" runat="server" Width="431px">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="UyeId" DataNavigateUrlFormatString="Edit.aspx?Id={0}" DataTextField="UyeId" DataTextFormatString="Düzelt" HeaderText="Düzelt" Text="Düzelt" />
            <asp:HyperLinkField DataNavigateUrlFields="UyeId" DataNavigateUrlFormatString="Delete.aspx?Id={0}" DataTextField="UyeId" DataTextFormatString="Silme" HeaderText="Silme" Text="Silme" />
        </Columns>
    </asp:GridView>

</asp:Content>
