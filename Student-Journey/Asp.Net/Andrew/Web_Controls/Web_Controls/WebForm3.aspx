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
            <asp:Table ID="Table1" runat="server">

                <asp:TableRow>
                    <asp:TableCell>Background Color:</asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="lstColor" runat="server" OnSelectedIndexChanged="lstColor_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Text="Red" Value="Red" />
                            <asp:ListItem Text="Blue" Value="Blue" />
                            <asp:ListItem Text="Yellow" Value="Yellow" />
                            <asp:ListItem Text="Green" Value="Green" />
                            <asp:ListItem Text="Orange" Value="Orange" />

                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell RowSpan="3" ID="myCell" BackColor="Tomato" Width="330px">
                        <asp:Label ID="lblMessage" runat="server" Text="Default Message" Font-Size="20px"></asp:Label>
                    </asp:TableCell>

                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Border Type:</asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButton ID="rdoOne" GroupName="myRdo" Text="None" runat="server" />
                        <br />
                        <asp:RadioButton ID="rdoTwo" GroupName="myRdo" Text="Solid" runat="server" />
                        <br />

                        <asp:RadioButton ID="rdoThree" GroupName="myRdo" Text="Ridge" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Message:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtText" runat="server" Height="100px" Width="150px" TextMode="MultiLine"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Font size:</asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="btnIncrease" runat="server" Text="Increase" OnClick="btnIncrease_Click" />&nbsp;<asp:Button ID="btnDecrease" runat="server" Text="Decrease" OnClick="btnDecrease_Click" />
                    </asp:TableCell>

                </asp:TableRow>

            </asp:Table>
        </div>
    </form>
</body>
</html>
