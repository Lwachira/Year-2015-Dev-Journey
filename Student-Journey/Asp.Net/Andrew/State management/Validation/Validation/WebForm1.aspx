<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Validation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" BorderStyle="Solid" BorderWidth="1px"></asp:RangeValidator>
    </div>
    </form>
</body>
</html>