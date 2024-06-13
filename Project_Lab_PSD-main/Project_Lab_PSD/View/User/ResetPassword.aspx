<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="Project_Lab_PSD.View.User.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Reset Password</h1>

        <div>
            <asp:Label ID="oldPasswordLbl" runat="server" Text="Old Password"></asp:Label>
            <asp:TextBox ID="oldPassTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="newPasswordLbl" runat="server" Text="New Password"></asp:Label>
            <asp:TextBox ID="newPasswordTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
        </div>
       

        <asp:Button ID="resetPassBtn" runat="server" Text="Reset Password" OnClick="resetPassBtn_Click" />

    </form>
</body>
</html>
