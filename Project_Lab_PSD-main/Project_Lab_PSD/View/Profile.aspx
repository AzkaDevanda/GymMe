<%@ Page Title="" Language="C#" MasterPageFile="~/Master Page/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Project_Lab_PSD.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
    <h1>Profile</h1>

    <div>
        <asp:Label ID="usernaneLbl" runat="server" Text="Usernane"></asp:Label>
        <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
        <asp:DropDownList ID="genderList" runat="server">
            <asp:ListItem Selected="True"></asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
    </div>


     <div>
        <asp:Label ID="dobLbl" runat="server" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="dobTxt" runat="server"></asp:TextBox>
    </div>

    <div style="color: red">
        <asp:Label ID="error" runat="server" Text=""></asp:Label>
    </div>

    <asp:Button ID="updateBtn" runat="server" Text="Update Profile" OnClick="updateBtn_Click" />
    <asp:Button ID="resetPassBtn" runat="server" Text="Reset Password" OnClick="resetPassBtn_Click" />



</asp:Content>
