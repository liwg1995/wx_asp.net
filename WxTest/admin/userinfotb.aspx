<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userinfotb.aspx.cs" Inherits="WxTest.admin.userinfotb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>会员管理</title>
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
                            <th style="font-family: 微软雅黑;">图像
                            </th>
                            <th style="font-family: 微软雅黑;">昵称
                            </th>
                            <th style="font-family: 微软雅黑;">是否关注
                            </th>
                            <th style="font-family: 微软雅黑;">帐号
                            </th>

                            <th style="font-family: 微软雅黑;">性别
                            </th>
                            <th style="font-family: 微软雅黑;">语言
                            </th>
                            <th style="font-family: 微软雅黑;">城市
                            </th>
                            <th style="font-family: 微软雅黑;">省份
                            </th>
                            <th style="font-family: 微软雅黑;">国家
                            </th>tb
                            <th style="font-family: 微软雅黑;">关注时间
                            </th>
                            <th style="font-family: 微软雅黑;">小组
                            </th>
                            <th style="font-family: 微软雅黑;">备注
                            </th>
                            <th style="font-family: 微软雅黑;">特权
                            </th>

                            <th style="width: 160px; font-family: 微软雅黑;">操作
                            </th>
                        </tr>
                        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                            <ItemTemplate>
                                <tr>
                                    <td style="font-family: 微软雅黑;">
                                        <img src="<%#Eval("headimgurl")%>" width="80" height="80" />
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("nickname")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("subscribe")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("openid")%>
                                    </td>

                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("sex")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("language")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("city")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("province")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("country")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("subscribe_time")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("unionid")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("remark")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("privilege")%>
                                    </td>

                                    <td style="font-family: 微软雅黑;">
                                        <a href='userinfo.aspx?id=<%#Eval("Id")%>' style="font-family: 微软雅黑;">修改</a>
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
