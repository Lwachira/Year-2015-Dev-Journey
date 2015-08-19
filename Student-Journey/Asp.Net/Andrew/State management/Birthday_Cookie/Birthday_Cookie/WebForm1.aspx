<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Birthday_Cookie.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="calBirthDay" runat="server" OnSelectionChanged="calBirthDay_SelectionChanged"></asp:Calendar>
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="Label" BorderStyle="Solid" BorderWidth="1px"></asp:Label>
            <br />
            &nbsp
            &nbsp
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>