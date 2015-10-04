<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ErrorHandeling.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            border: 1px solid black;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Calculator</h1>

            <asp:Label Text=" " runat="server" CssClass="auto-style1" Width="320px" Height="25px" ID="lblMesage" />
            <br />
            <br />
            Action:
            <asp:RadioButtonList runat="server" CssClass="auto-style2" ID="rdMath">
                <asp:ListItem Text="Add" />
                <asp:ListItem Text="Subtract" />
                <asp:ListItem Text="Multiply" />
                <asp:ListItem Text="Divide" />
            </asp:RadioButtonList>
            <br />
            First Number:
            &nbsp;
            &nbsp;
            &nbsp;
            &nbsp;

            &nbsp;
            <asp:TextBox runat="server" ID="txtFirstNum" />
            <br />
            Second Number:
             &nbsp;
            &nbsp;
            &nbsp;
            <asp:TextBox runat="server" ID="txtSecondNum" />
            <br />
            <br />
            <asp:Button Text="Calculate" runat="server" ID="btnCalculate" OnClick="btnCalculate_Click" />
            &nbsp
            <asp:Button Text="Clear" runat="server" ID="btnClear" />
        </div>
    </form>
</body>
</html>