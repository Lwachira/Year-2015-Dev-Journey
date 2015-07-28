<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Web_Controls.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Build your own message</h2>
            <asp:Table ID="tblColor" runat="server">
                <asp:TableRow>
                    <asp:TableCell ID="cellColor">
                        Background-color :
                <asp:DropDownList TextMode="MultiLine" ID="txtBckColor" runat="server">
                    <asp:ListItem Text="Red" />
                    <asp:ListItem Text="Blue" />
                    <asp:ListItem Text="Green" />
                    <asp:ListItem Text="Yellow" />
                    <asp:ListItem Text="Orange" />

                </asp:DropDownList>

                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow>

                    <asp:TableCell ID="cellBorder">
                        <br />
                        Border Type:                       
                        <br />

                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="rdoOne" ViewStateMode="Inherit" />
                        <br />
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="rdoOne" />
                        <br />

                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="rdoOne" />
                        <br />



                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>

        </div>
    </form>
</body>
</html>
