<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrimerCookies.aspx.cs" Inherits="colorCookie.PrimerCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #lblMessage {
            text-align: center;
        }

        .auto-style1 {
            color: #863a04;
        }

        .auto-style2 {
            color: #00ff21;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label Text="text" ID="lblMessage" runat="server" Width="194px" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <br />
            <asp:Button Text="Next" runat="server" CssClass="auto-style1" Width="81px" ID="btnNext" OnClick="btnNext_Click" />
            &nbsp;
        &nbsp;
        <asp:Button Text="Prev" runat="server" CssClass="auto-style2" Width="81px" ID="btnPrev" OnClick="btnPrev_Click" />
        </div>
    </form>
</body>
</html>