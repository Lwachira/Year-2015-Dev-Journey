<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="WebCalculator.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calculator</h2>
            <asp:Label ID="lblMessage" runat="server" Text=" " BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="35px" Width="254px"></asp:Label>
            <asp:Table ID="Table1" runat="server" Width="444px">

                <asp:TableRow>
                    <asp:TableCell>Action:</asp:TableCell>

                    <asp:TableCell>
                        <asp:RadioButtonList ID="rdoListMath" runat="server">
                            <asp:ListItem Selected="True" Text="Add" />
                            <asp:ListItem Text="Subtract" />
                            <asp:ListItem Text="Multiply" />
                            <asp:ListItem Text="Divide" />
                        </asp:RadioButtonList>
                    </asp:TableCell>


                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        First Number: 
                        <br />
                        <br />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txtNum1"></asp:TextBox>
                        <br />
                        <br />

                    </asp:TableCell>
                </asp:TableRow>

                      <asp:TableRow>
                    <asp:TableCell>
                        Second Number: 
                        <br />
                        <br />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="txtNum2"></asp:TextBox>
                        <br />
                        <br />

                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                            <asp:Button ID="txtCal" runat="server"  Text="Calculate"  OnClick="txtCal_Click"/>
                    </asp:TableCell>
                </asp:TableRow>

            </asp:Table>

        </div>
    </form>
</body>
</html>
