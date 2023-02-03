<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminApproveProperty.aspx.cs" Inherits="emlakWebForms.AdminApproveProperty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
                <div style="width: 1100px; min-height: 150px; margin: 10px; padding: 10px; border: 1px solid #808080; display: flex; flex-direction: row; justify-content: space-between; align-items: center">
                    <asp:Image ID="Image1" ImageUrl='<%# Eval("PropertyPhotos") %>' runat="server" Width="260px" Height="130px" />
                    <h2><%# Eval("PropertyTitle") %></h2>
                    <h2>Fiyat: <%# Eval("PropertyPrice") %> ₺</h2>

                </div>
            </a>

            <a class="btn btn-info" href="AdminApprove.aspx?selectedid=<%# Eval("PropertyId") %>"">Onayla</a>

        </ItemTemplate>
    </asp:DataList>
</asp:Content>
