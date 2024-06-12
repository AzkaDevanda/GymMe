<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project_Lab_PSD.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <h1>Login</h1>

        <div>
            <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:CheckBox ID="rememberMe" runat="server" Text="Remember Me" />
        </div>

        <div style="color: red">
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
        </div>
        


    </form>
</body>
</html>
