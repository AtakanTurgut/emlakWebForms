<%@ Page Title="" Language="C#" MasterPageFile="~/NonUser.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="emlakWebForms.Login" %>

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
            <h2>Giriş Yap</h2>
            <asp:TextBox CssClass="form-control mytbox" ID="tboxMail" placeholder="Mail Adresinizi Giriniz" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="form-control mytbox" ID="tboxPassword" placeholder="Şifrenizi Giriniz" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button CssClass="btn btn-success mybutton" ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş Yap" OnClientClick="Button1_Click" ForeColor="white" />
        </form>
    </body>
    </html>
</asp:Content>
