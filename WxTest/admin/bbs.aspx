﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bbs.aspx.cs" Inherits="WxTest.admin.bbs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>后台管理</title>
    <link href="../css/base.css" rel="stylesheet" type="text/css" />
    <link href="../css/sub.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="content">
        <table class="niunantab">
            <tbody>
                <tr>
                    <td class="left_td">
                        用户：
                    </td>
                    <td>
                        <asp:TextBox ID="userid" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        时间：
                    </td>
                    <td>
                        <asp:TextBox ID="thetime" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        内容：
                    </td>
                    <td>
                        <asp:TextBox ID="memos" runat="server" CssClass="inputtext" Width="500px" TextMode="MultiLine" Height="50"></asp:TextBox>
                    </td>
                </tr>
               

                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="保   存" CssClass="btn" OnClick="BtnOk_Click" />
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
         
    </form>
</body>
</html>
