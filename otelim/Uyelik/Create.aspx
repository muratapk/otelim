<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="otelim.Uyelik.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 309px;
        }
        .auto-style3 {
            height: 23px;
            width: 309px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="auto-style2">Üye Adı</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Cep Telefonu</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Mail</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style2">Kullanıcı Adı</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
    <td class="auto-style2">Şifre:</td>
    <td>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
    <td>&nbsp;</td>
</tr>
                <tr>
    <td class="auto-style2">&nbsp;</td>
    <td>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </td>
    <td>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Index.aspx">Anasayfa Git</asp:HyperLink>
                    </td>
</tr>
    </table>
</asp:Content>
