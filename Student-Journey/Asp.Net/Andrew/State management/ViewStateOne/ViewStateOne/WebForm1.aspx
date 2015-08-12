<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewStateOne.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="align-self; margin-left: 40px;">
            <asp:Button CssClass=" btn btn-danger" ID="btnIncrement" runat="server" Text="Increment" OnClick="btnIncrement_Click" />
            <br />
            <asp:Label ID="lblCounter" runat="server" Text="Counter"></asp:Label>
        </div>
    </form>

    <script src="Scripts/jquery-2.1.4.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</body>
</html>
