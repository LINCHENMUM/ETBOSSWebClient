﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ETBOSSWebClient.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Get customer name using WCF" OnClick="Button1_Click" /><br /><br />
            <asp:Label ID="Label1" runat="server" Font-Bold="true" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>