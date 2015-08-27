<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Wizard.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Wizard ID="Wizard1" runat="server" DisplaySideBar="False" ActiveStepIndex="0" BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em">
                <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Left" />
                <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
                <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
                <StepStyle BorderWidth="0px" ForeColor="#5D7B9D" />
                <WizardSteps>
                    <asp:WizardStep runat="server" Title="Step 1: Ad-Rotator">

                        <h1 style="font-family: Arial, Helvetica, sans-serif; text-decoration: underline; text-align: center">Favorite Website</h1>
                        &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" BorderStyle="Solid" BorderWidth="1" BorderColor="Black" Target="_blank" />
                        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile1.xml"></asp:XmlDataSource>
                    </asp:WizardStep>

                    <asp:WizardStep runat="server" Title="Step 2 - Data Collection">
                        <h1 style="font-family: Arial, Helvetica, sans-serif; text-decoration: underline; text-align: center">Name & Surname & Birthday</h1>
                        Name:
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        Surname:
                        <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="lblDate" runat="server" Text="Please Select a birthdate in 2015"></asp:Label>
                        <br />
                        <br />

                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnDayRender="Calendar1_DayRender" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>
                        <br />

                        <br />
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </form>
</body>
</html>