<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Prac_02.Index" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Chart ID="failingChart" runat="server">

                <Series>
                    <asp:Series ChartType="Pie">
                        <Points>
                            <asp:DataPoint AxisLabel="Assignment 1" YValues="65" IsValueShownAsLabel="true" />
                            <asp:DataPoint AxisLabel="Test 1" YValues="57" IsValueShownAsLabel="true" />
                            <asp:DataPoint AxisLabel="Test 2" YValues="50" IsValueShownAsLabel="true" />
                        </Points>
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="chartArea">
                    </asp:ChartArea>
                </ChartAreas>
                <Legends>
                    <asp:Legend Name="charLegend" Title="Test Marks"></asp:Legend>
                </Legends>
                <Titles>
                    <asp:Title Name="chartTitle" Text="Failing Grades" Font="Arial"></asp:Title>
                </Titles>
            </asp:Chart>
        </div>

    </form>
</body>
</html>
