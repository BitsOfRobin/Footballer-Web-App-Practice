<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayFootball.aspx.cs" Inherits="WebApplication4.DisplayFootball" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:TextBox ID="TxtBoxFootballer" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        
            
            <asp:Label ID="LBLfootball" runat="server"  Font-Size="Large"></asp:Label>
        
        </div>
   
    </form>
</body>
</html>
