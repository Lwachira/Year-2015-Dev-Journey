﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Prac_01.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }

        .auto-style2 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Message:
            <asp:TextBox runat="server" ID="txtMessage" />

            <br />

            <br />
            Images:
           <asp:RadioButtonList ID="rdoImage" runat="server">
               <asp:ListItem Value="smiley" Text="Image 01" />
               <asp:ListItem Value="sad" Text="Image 02" />
               <asp:ListItem Value="angry" Text="Image 03" />
           </asp:RadioButtonList>
            <br />
            <br />
            <asp:Button Text="Submit" ID="btnSubmit" runat="server" Width="96px" CssClass="auto-style1" OnClick="btnSubmit_Click" />
            <br />
            <br />

            <asp:Image ImageUrl="~/ImageGenerator.aspx" runat="server" ID="imgPic" CssClass="auto-style2" Visible="False" />
        </div>
    </form>
</body>
</html>