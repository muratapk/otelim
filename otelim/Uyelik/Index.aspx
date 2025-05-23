<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="otelim.Uyelik.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <a href="Create.aspx">Yeni Kayıt</a>
    <asp:GridView ID="GridView1" runat="server" Width="431px">
    </asp:GridView>

</asp:Content>
