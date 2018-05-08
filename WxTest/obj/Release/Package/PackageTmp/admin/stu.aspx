<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stu.aspx.cs" Inherits="WxTest.admin.stu" %>

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
                        学号：
                    </td>
                    <td>
                        <asp:TextBox ID="userid" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        姓名：
                    </td>
                    <td>
                        <asp:TextBox ID="username" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        年龄：
                    </td>
                    <td>
                        <asp:TextBox ID="userage" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        性别：
                    </td>
                    <td>
                        <asp:TextBox ID="usersex" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        专业：
                    </td>
                    <td>
                        <asp:TextBox ID="userzx" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        年级：
                    </td>
                    <td>
                        <asp:TextBox ID="userclass" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        班级：
                    </td>
                    <td>
                        <asp:TextBox ID="usergrade" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        联系方式：
                    </td>
                    <td>
                        <asp:TextBox ID="usertel" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
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
