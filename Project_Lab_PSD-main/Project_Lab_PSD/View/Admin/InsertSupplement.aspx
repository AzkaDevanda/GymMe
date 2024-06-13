<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertSupplement.aspx.cs" Inherits="Project_Lab_PSD.View.Admin.InsertSupplemeny" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Supplement</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Insert New Supplement</h1>

        <div>
            <asp:Label ID="suppNameLbl" runat="server" Text="Supplement Name"></asp:Label>
            <asp:TextBox ID="suppNameTxt" runat="server"></asp:TextBox>
        </div>

         <div>
             <asp:Label ID="suppExpiryLbl" runat="server" Text="Supplement Expiry Date"></asp:Label>
            <asp:TextBox ID="suppExpiryTxt" runat="server"></asp:TextBox>
        </div>

         <div>
            <asp:Label ID="suppPriceLbl" runat="server" Text="Supplement Price"></asp:Label>
            <asp:TextBox ID="suppPriceTxt" runat="server"></asp:TextBox>
        </div>

         <div>
            <asp:Label ID="suppTypeLbl" runat="server" Text="Supplement Type Id"></asp:Label>
            <asp:DropDownList ID="suppTypeList" runat="server"></asp:DropDownList>           
        </div>

        <asp:Button ID="insertBtn" runat="server" Text="Insert Supplement" OnClick="insertBtn_Click" />


    </form>
</body>
</html>
