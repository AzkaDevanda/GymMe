<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Project_Lab_PSD.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Register Page</h1>

            <div>
                <asp:Label ID="usernameLbl" runat="server" Text="Usernmae"></asp:Label>
                <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
                <asp:DropDownList ID="genderList" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div>
               <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
               <asp:TextBox ID="passwrodTxt" runat="server"></asp:TextBox>
            </div>

            <div>
               <asp:Label ID="cfPasswordLbl" runat="server" Text="Confirm Password"></asp:Label>
               <asp:TextBox ID="cfPasswordTxt" runat="server"></asp:TextBox>
            </div>

            <div>
               <asp:Label ID="dobLbl" runat="server" Text="Date of Birth"></asp:Label>
               <asp:TextBox ID="dobTxt" runat="server"></asp:TextBox>
            </div>

            <div style="color: red">
                <asp:Label ID="error" runat="server" Text=""></asp:Label>
            </div>

            <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />

            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
            
        </div>
    </form>
</body>
</html>
