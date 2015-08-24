<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Validation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            A number (1 to 10):
            <asp:TextBox ID="txtValidated" runat="server" />
            <%-- <asp:RangeValidator ID="RangeValidator" runat="server"
                ErrorMessage="This Number Is Not In The Range"
                ControlToValidate="txtValidated"
                MaximumValue="10" MinimumValue="1"
                ForeColor="Red" Font-Bold="true"
                Type="Integer" />--%>

            <asp:ValidationSummary ID="Errors" ForeColor="Red" runat="server" />
            <br />
            <br />

            Not validated:
            <asp:TextBox ID="txtNotValidated" runat="server" /><br />
            <br />
            <asp:Button ID="cmdOk" runat="server" Text="OK" OnClick="cmdOk_Click" />
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server"
                EnableViewState="False" />
        </div>
    </form>

    <script src="Scripts/jquery-2.1.4.min.js"></script>
</body>
</html>