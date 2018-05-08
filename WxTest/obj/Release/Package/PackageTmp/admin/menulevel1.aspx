<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menulevel1.aspx.cs" Inherits="WxTest.admin.menulevel1" %>

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
                        名称：
                    </td>
                    <td>
                        <asp:TextBox ID="menuname" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="left_td">
                        序号：
                    </td>
                    <td>
                        <asp:TextBox ID="nums" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
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
