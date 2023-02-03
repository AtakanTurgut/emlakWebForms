<%@  Title="" Language="C#" MasterPageFile="~/NonUser.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="emlakWebForms.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
        <meta http-equiv="content-type" content="text/html; charset=utf-8" />

        <style type="text/css">
            .mytbox {
                width: 250px;
                height: 40px;
                margin-top: 20px;
            }

            .mybutton {
                width: 250px;
                height: 40px;
                margin-top: 20px;
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server" method="post" style="display: flex; flex-direction: column; height: 500px; margin-left: 20px">
            <h2>Kayıt Ol</h2>
            <asp:TextBox CssClass="form-control mytbox" ID="tboxName" placeholder="Adınızı Giriniz" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="form-control mytbox" ID="tboxSurname" placeholder="Soyadınızı Giriniz" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="form-control mytbox" ID="tboxMail" placeholder="Mail Adresinizi Giriniz" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="form-control mytbox" ID="tboxPassword" placeholder="Şifrenizi Giriniz" runat="server"></asp:TextBox>
            <asp:Button CssClass="btn btn-primary mybutton" ID="Button1" runat="server" OnClick="Button1_Click" Text="Kayıt Ol" ForeColor="White" />
        </form>
    </body>
    </html>
</asp:Content>
