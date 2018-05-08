<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="correcting.aspx.cs" Inherits="WxTest.admin.correcting" ValidateRequest="false" %>

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
                        <td class="left_td">题目：
                        </td>
                        <td>
                            <asp:TextBox ID="hwtit" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">学号：
                        </td>
                        <td>
                            <asp:TextBox ID="userid" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">时间：
                        </td>
                        <td>
                            <asp:TextBox ID="ctime" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">单元测试内容：
                        </td>
                        <td>
                            <asp:TextBox ID="ccon" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">批复老师：
                        </td>
                        <td>
                            <asp:TextBox ID="ter" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">批复时间：
                        </td>
                        <td>
                            <asp:TextBox ID="cdate" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">成绩：
                        </td>
                        <td>
                            <asp:TextBox ID="scores" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">评语：
                        </td>
                        <td>
                            <asp:TextBox ID="messages" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>


                    <tr>
                        <td>&nbsp;
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
