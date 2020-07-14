<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SecretLibrary.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h2>Members Insert</h2>
    <p>&nbsp;</p>
    <p>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name:  "></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblLastName" runat="server" Text="Last Name:  "></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblNationalID" runat="server" Text="National ID:  "></asp:Label>
        <asp:TextBox ID="txtNationalID" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblFathersName" runat="server" Text="Fathers Name:  "></asp:Label>
        <asp:TextBox ID="txtFathersName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblGender" runat="server" Text="Gender:  "></asp:Label>
        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblBirthDate" runat="server" Text="Birth Date:  "></asp:Label>
        <asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblPhoneNo" runat="server" Text="Phone No:  "></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblAddress" runat="server" Text="Address:  "></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblEmail" runat="server" Text="Email:  "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
    </p>
    </asp:Content>
