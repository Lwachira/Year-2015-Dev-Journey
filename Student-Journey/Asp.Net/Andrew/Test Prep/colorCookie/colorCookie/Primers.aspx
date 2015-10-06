<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Primers.aspx.cs" Inherits="colorCookie.Primers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        #lblMessage {
            text-align: center;
        }

        .auto-style1 {
            color: blue;
        }

        .auto-style2 {
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="text" ID="lblMessage" runat="server" Width="194px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
        </div>
        <br />
        <asp:Button Text="Next" runat="server" CssClass="auto-style1" Width="81px" ID="btnNext" OnClick="btnNext_Click" />
        &nbsp;
        &nbsp;
        <asp:Button Text="Prev" runat="server" CssClass="auto-style2" Width="81px" ID="btnPrev" OnClick="btnPrev_Click" />
    </form>
</body>
</html>