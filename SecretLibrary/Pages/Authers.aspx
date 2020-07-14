<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authers.aspx.cs" Inherits="SecretLibrary.Pages.Authers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
