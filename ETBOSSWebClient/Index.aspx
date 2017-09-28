<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ETBOSSWebClient.Index" %>

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

        <div style="font-family:Arial">
            
            ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtID" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            Name<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            DOB&nbsp;
            <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="GetEmployee" runat="server" Text="Get Employee" OnClick="GetEmployee_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="SaveEmployee" runat="server" Text="Save Employee" OnClick="SaveEmployee_Click" />
            
        </div>
    </form>
</body>
</html>
