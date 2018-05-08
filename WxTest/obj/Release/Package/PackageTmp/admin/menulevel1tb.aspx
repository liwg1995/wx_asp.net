<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menulevel1tb.aspx.cs" Inherits="WxTest.admin.menulevel1tb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>一级菜单管理</title>
    <link href="../css/base.css" rel="stylesheet" type="text/css" />
    <link href="../css/sub.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="content">
        <div class="tb1">
            <table class="niunantab">
                <tbody>
                    <tr>
                        <td>
                         <asp:Button ID="Button1" runat="server" Text="发  布" CssClass="btn" OnClick="BtnOk_Click" />
                        </td>
                        <td>
                            
                        </td>
                    </tr>
                </tbody>
            </table>
            <table class="niunantab">
                <tbody>
                    <tr>
                        <th style="font-family: 微软雅黑;">
                            名称
                        </th>
                        <th style="font-family: 微软雅黑;">
                            序号
                        </th>
                        <th style="width: 160px; font-family: 微软雅黑;">
                            操作
                        </th>
                    </tr>
                    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td style="font-family: 微软雅黑;">
                                    <%#Eval("menuname")%>
                                </td>
                                <td style="font-family: 微软雅黑;">
                                    <%#Eval("nums")%>
                                </td>
                                <td style="font-family: 微软雅黑;">
                                    <a href='menulevel2.aspx?level1id=<%#Eval("Id")%>' style="font-family: 微软雅黑;">添加二级菜单</a>
                                    <a href='menulevel1.aspx?id=<%#Eval("Id")%>' style="font-family: 微软雅黑;">修改</a>
                                    <asp:LinkButton Style="padding-left: 5px; padding-right: 5px" ID="LinkButton1" runat="server"
                                        CommandName='<%#Eval("id")%>' CommandArgument="1" OnClientClick="return confirm('确认要删除该信息吗？');"><span style="font-family:微软雅黑;">删除</span></asp:LinkButton>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
    </form>
</body>
</html>