<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserPropertyPage.aspx.cs" Inherits="emlakWebForms.UserPropertyPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href="UserPropertyDetails.aspx?selectedid=<%# Eval("PropertyId") %>">
                <div style="width: 1100px; min-height: 150px; margin: 10px; padding: 10px; border: 1px solid #808080; display: flex; flex-direction: row; justify-content: space-between; align-items: center">
                    <asp:Image ID="Image1" ImageUrl='<%# Eval("PropertyPhotos") %>' runat="server" Width="260px" Height="130px" />
                    <h2><%# Eval("PropertyTitle") %></h2>
                    <h2>Fiyat: <%# Eval("PropertyPrice") %> ₺</h2>

                </div>
            </a>

        </ItemTemplate>
    </asp:DataList>
</asp:Content>
