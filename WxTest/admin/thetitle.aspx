<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="thetitle.aspx.cs" Inherits="WxTest.admin.thetitle" %>

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
                        单元测试编号：
                    </td>
                    <td>
                        <asp:TextBox ID="hwid" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        题目：
                    </td>
                    <td>
                        <asp:TextBox ID="thetitles" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        备注：
                    </td>
                    <td>
                        <asp:TextBox ID="memos" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
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
