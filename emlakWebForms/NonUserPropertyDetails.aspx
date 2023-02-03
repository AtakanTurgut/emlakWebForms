<%@ Page Title="" Language="C#" MasterPageFile="~/NonUser.Master" AutoEventWireup="true" CodeBehind="NonUserPropertyDetails.aspx.cs" Inherits="emlakWebForms.NonUserPropertyDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>

            <asp:Label ID="Label2" runat="server" Text='<%# Eval("PropertyTitle") %>'></asp:Label>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="511px" ImageUrl='<%# Eval("PropertyPhotos") %>' Width="1152px" />
            <br />
            <br />
            Tür:
            <asp:Label ID="Label3" runat="server" Text='<%# Eval("PropertyType") %>'></asp:Label>
            <br />
            Şehir:
            <asp:Label ID="Label4" runat="server" Text='<%# Eval("PropertyCity") %>'></asp:Label>
            <br />
            Mahalle:<asp:Label ID="Label5" runat="server" Text='<%# Eval("PropertyHood") %>'></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label6" runat="server" Text='<%# Eval("PropertyPrice") %>'></asp:Label>
            ₺<br /> Oda Sayısı:
            <asp:Label ID="Label7" runat="server" Text='<%# Eval("PropertyRoom") %>'></asp:Label>

        </ItemTemplate>
    </asp:DataList>
    </form>
</asp:Content>
