<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:DropDownList ID="DDLFootball" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="SubmitBtn" runat="server" Text="Button" OnClick="SubmitBtn_Click" />
            <asp:RadioButton ID="RadioButton1" runat="server" />
        </p>
    </form>
</body>
</html>
