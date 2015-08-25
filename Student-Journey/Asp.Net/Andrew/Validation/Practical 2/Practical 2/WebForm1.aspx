<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtInterest" ErrorMessage="Name Needed" ForeColor="Red">*</asp:RequiredFieldValidator>
            <br />
            Deposit:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDeposit" runat="server" Height="22px" Width="128px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtDeposit" ErrorMessage="Deposit Range 1000 - 50000" ForeColor="Red" MaximumValue="50000" MinimumValue="1000" Type="Integer">*</asp:RangeValidator>
            <br />
            Years :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtYear" runat="server" Height="22px" Width="128px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtYear" ErrorMessage="Years Range 1 - 30" ForeColor="Red" MaximumValue="30" MinimumValue="1" Type="Integer">*</asp:RangeValidator>
            <br />
            Interest:
        <asp:TextBox ID="txtInterest" runat="server"></asp:TextBox>
            %
            <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtInterest" ErrorMessage="Interest Range 1 - 100" ForeColor="Red" MaximumValue="100" MinimumValue="1" Type="Double">*</asp:RangeValidator>
            <br />
            <br />
            <asp:Button ID="btnCalc" runat="server" Text="Calculate" OnClick="btnCalc_Click" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Errors" />
            <br />
        </div>
    </form>
</body>
</html>