<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_1__Validation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div spellcheck="True">

            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            User&#39;s Name
        <asp:RequiredFieldValidator ID="valUserName" runat="server" ControlToValidate="txtUserName" ErrorMessage="User Name not found" ForeColor="Red" ValidateRequestMode="Enabled" Display="Dynamic">*</asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            User&#39;s Age
        <asp:RangeValidator ID="valRange" runat="server" ControlToValidate="txtAge" ErrorMessage="Enter a user age" ForeColor="Red" MaximumValue="120" MinimumValue="1" Type="Integer">*</asp:RangeValidator>
            <br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            User&#39;s Email
        <asp:RegularExpressionValidator ID="valExpression" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter an email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            <br />
            <asp:TextBox ID="txtUserWeight" runat="server"></asp:TextBox>
            User&#39;s Weight
        <asp:CustomValidator ID="valCustom" runat="server" ControlToValidate="txtUserWeight" ErrorMessage="Enter a proper weight" ForeColor="Red" ClientValidationFunction="customVal" OnServerValidate="valCustom_ServerValidate">*</asp:CustomValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Page Error's" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>

    <script>
        function customVal(objSource, objArgs) {

            try {
                if (int.Parse(objArgs.Value) > 0) {
                    objArgs.IsValid = true;

                }
                else {
                    objArgs.IsValid = false;
                }
            }
            catch (Exception) {
                objArgs.IsValid = false;
            }

        }
    </script>
</body>
</html>