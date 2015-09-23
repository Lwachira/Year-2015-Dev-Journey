<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Prac01.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Message:
            <asp:TextBox runat="server" ID="txtMessage" />
            <asp:RadioButtonList runat="server" ID="rdImage">
                <asp:ListItem Text="image1" />
                <asp:ListItem Text="image2" />
                <asp:ListItem Text="image3" />
            </asp:RadioButtonList>

            <asp:Button Text="text" runat="server" />
            <br />
            <asp:Image ImageUrl="~/ImageGenerator.ascx" runat="server" />
        </div>
    </form>
</body>
</html>
