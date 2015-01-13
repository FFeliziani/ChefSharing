<%@ Page Title="" Language="C#" MasterPageFile="~/ChefSharing.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ChefSharingFrontend.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnLogin" runat="server" Text="Button" OnClick="btnLogin_Click" /><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
</asp:Content>
