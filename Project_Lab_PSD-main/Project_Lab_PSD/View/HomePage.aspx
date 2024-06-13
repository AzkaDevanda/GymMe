<%@ Page Title="" Language="C#" MasterPageFile="~/Master Page/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project_Lab_PSD.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
    <h1>Home Page</h1>

    <div ID="adminUtlis" runat="server">
        <asp:Button ID="insertSuppBtn" runat="server" Text="Insert Supplement" OnClick="insertSuppBtn_Click" />
        <asp:Button ID="updateSuppBtn" runat="server" Text="Update Supplement" />
        <asp:Button ID="deleteSuppBtn" runat="server" Text="Delete Supplement" />
    </div>

    <div>
        <asp:Label ID="name" runat="server" Text="Name"></asp:Label>
    </div>

    <div id="listUserContainer" runat="server">
        <h1>List User</h1>
        <asp:ListBox ID="listUser" runat="server"></asp:ListBox>
    </div>

    <div>
        <asp:Label ID="UserLoggedinCount" runat="server" Text="0 User(s) Online"></asp:Label>
    </div>

    <div>
        <asp:Button ID="logutButton" runat="server" Text="Logout" OnClick="logutButton_Click" />
    </div>



</asp:Content>
