<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homeworktb.aspx.cs" Inherits="WxTest.admin.homeworktb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>作业管理</title>
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
                            <th style="font-family: 微软雅黑;">标题
                            </th>
                            <th style="font-family: 微软雅黑;">时间
                            </th>
                            <th style="font-family: 微软雅黑;">发布人
                            </th>
                            <th style="font-family: 微软雅黑;">说明
                            </th>

                            <th style="width: 160px; font-family: 微软雅黑;">操作
                            </th>
                        </tr>
                        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                            <ItemTemplate>
                                <tr>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("hwtit")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("hwtime")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("hwer")%>
                                    </td>
                                    <td style="font-family: 微软雅黑;">
                                        <%#Eval("press")%>
                                    </td>

                                    <td style="font-family: 微软雅黑;">
                                        <a href="thetitle.aspx?hwid=<%#Eval("id")%>">添加题目</a>
                                        <a href='homework.aspx?id=<%#Eval("Id")%>' style="font-family: 微软雅黑;">修改</a>
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

