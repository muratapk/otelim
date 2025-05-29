<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="otelim.Login.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4Q6Gf2aSP4eDXB8Miphtr37CMZZQ5oXLH2yaXMJ2w8e2ZtHTl7GptT4jmndRuHDT" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <div class="container">
             <div class="row">
                 <div class="col-md-6 offset-md-3">
                     <h2>Login</h2>
                     <div class="mb-3">
                         <asp:Label ID="Label1" CssClass="form-control" runat="server" Text="Kullanıcı Adını Girin"></asp:Label>
                         <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                     </div>

                   <div class="mb-3">
                     <asp:Label ID="Label2" CssClass="form-control" runat="server" Text="Şifrenizi Girin:"></asp:Label>
                     <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                     <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Button" Height="43px" Width="103px" OnClick="Button1_Click" />
                 </div>
             </div>
         </div>
        </div>
    </form>
</body>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js" integrity="sha384-j1CDi7MgGQ12Z7Qab0qlWQ/Qqz24Gc6BM0thvEMVjHnfYGF0rmFCozFSxQBxwHKO" crossorigin="anonymous"></script>
</html>
