<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Birthday_Cookie.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="calBirthDay" runat="server" OnSelectionChanged="calBirthDay_SelectionChanged" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="Label" BorderStyle="Solid" BorderWidth="1px"></asp:Label>
            &nbsp;Future Value<br />
            &nbsp
            &nbsp
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add/Update" OnClick="btnAdd_Click" />
            <br />
            <asp:Label ID="lblCookie" runat="server" Text="Label"></asp:Label>
&nbsp;Cookie Curret Value</div>
    </form>
</body>
</html>