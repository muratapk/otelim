<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="otelim.Admin.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" Width="343px">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="AdminId" DataNavigateUrlFormatString="Edit.aspx?Id={0}" DataTextField="AdminId" DataTextFormatString="Düzelt" HeaderText="Düzelt" Text="Düzelt" />
            <asp:HyperLinkField DataNavigateUrlFields="AdminId" DataNavigateUrlFormatString="Delete.aspx?Id={0}" DataTextField="AdminId" DataTextFormatString="Silme" HeaderText="Silme" Text="Silme" />
        </Columns>
    </asp:GridView>
</asp:Content>
