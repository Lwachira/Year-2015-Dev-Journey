<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prac_2_Query_String.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: relative;
            z-index: 1;
            left: 44px;
            top: 15px;
            width: 134px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            First Name&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPage" runat="server" CssClass="auto-style1" Text="Next page" OnClick="btnPage_Click" />
            <br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            Last Name<br />
        </div>
    </form>
</body>
</html>