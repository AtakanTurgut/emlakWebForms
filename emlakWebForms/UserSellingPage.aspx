<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserSellingPage.aspx.cs" Inherits="emlakWebForms.UserSellingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" method="post">
        <h2>Kullanıcı Satış Sayfası</h2>
        <asp:TextBox ID="tboxTitle" placeholder="Başlık" runat="server" Width="410px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="tboxPrice" placeholder="Fiyat" runat="server" Width="410px"></asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="DropDownListCity" AutoPostBack="true" OnSelectedIndexChanged="DropDownListCity_SelectedIndexChanged" runat="server" Height="22px" Width="410px"></asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="DropDownListHood" runat="server" Height="22px" Width="410px"></asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="DropDownListType" AutoPostBack="true" OnSelectedIndexChanged="DropDownListType_SelectedIndexChanged" runat="server" Height="22px" Width="410px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="DropDownListRoom" runat="server" Height="22px" Width="410px"></asp:DropDownList>
        <br />
        <br />
        <asp:TextBox ID="tboxPhoto" placeholder="Fotoğraf Linki" runat="server" Width="410px"></asp:TextBox>
        <br />
        <br />
        <p>
            <asp:Button ID="btnAddProperty" CssClass="btn btn-success" OnClick="btnAddProperty_Click" runat="server" Text="İlan Ekle" />
        </p>
    </form>
</asp:Content>
