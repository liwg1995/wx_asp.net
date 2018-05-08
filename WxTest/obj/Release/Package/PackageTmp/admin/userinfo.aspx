<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userinfo.aspx.cs" Inherits="WxTest.admin.userinfo" %>

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
                        <td class="left_td">是否关注：
                        </td>
                        <td>
                            <asp:TextBox ID="subscribe" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">帐号：
                        </td>
                        <td>
                            <asp:TextBox ID="openid" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">昵称：
                        </td>
                        <td>
                            <asp:TextBox ID="nickname" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">性别：
                        </td>
                        <td>
                            <asp:TextBox ID="sex" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">语言：
                        </td>
                        <td>
                            <asp:TextBox ID="language" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">城市：
                        </td>
                        <td>
                            <asp:TextBox ID="city" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">省份：
                        </td>
                        <td>
                            <asp:TextBox ID="province" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">国家：
                        </td>
                        <td>
                            <asp:TextBox ID="country" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">图像：
                        </td>
                        <td>
                            <asp:TextBox ID="headimgurl" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">关注时间：
                        </td>
                        <td>
                            <asp:TextBox ID="subscribe_time" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">小组：
                        </td>
                        <td>
                            <asp:TextBox ID="unionid" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">备注：
                        </td>
                        <td>
                            <asp:TextBox ID="remark" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">特权：
                        </td>
                        <td>
                            <asp:TextBox ID="privilege" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>


                    <tr>
                        <td>&nbsp;
                        </td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="保   存" CssClass="btn" OnClick="BtnOk_Click" />
                            &nbsp;
                            <asp:Button ID="Button2" runat="server" Text="会员导入" CssClass="btn" OnClick="BtnYes_Click" />
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>

    </form>
</body>
</html>
