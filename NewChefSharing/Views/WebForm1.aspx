<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NewChefSharing.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Button ID="Button1" runat="server" Text="Button" />
        
    </form>
    <script>
        $(<%# Button1.ClientID%>).click(function () {

    </script>
</body>
</html>
