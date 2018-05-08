<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stutb.aspx.cs" Inherits="WxTest.admin.stutb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>学生管理</title>
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
                        <th style="font-family: 微软雅黑;">
                            学号
                        </th>
                        <th style="font-family: 微软雅黑;">
                            姓名
                        </th>
                        <th style="font-family: 微软雅黑;">
                            年龄
                        </th>
                        <th style="font-family: 微软雅黑;">
                            性别
                        </th>
                        <th style="font-family: 微软雅黑;">
                            专业
                        </th>
                        <th style="font-family: 微软雅黑;">
                            年级
                        </th>
                        <th style="font-family: 微软雅黑;">
                            班级
                        </th>
                        <th style="font-family: 微软雅黑;">
                            联系方式
                        </th>
                        
                        <th style="width: 160px; font-family: 微软雅黑;">
                            操作
                        </th>
                    </tr>
                    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td style="font-family: 微软雅黑;">
                                    <%#Eval("userid")%>
                                </td>
                                <td style="font-family: 微软雅黑;">
                                    <%#Eval("username")%>
                                </td>
                                <td style="font-family: 微软雅黑;">
                                    <%#Eval("userage")%>
                                </td>
                                <td style="font-family: 微软雅黑;">
                                    <%#Eval("usersex")%>
                                </td>
                                <td style="font-family: 微软雅黑;">
                                    <%#Eval("userzx")%>
                                </td>
                                <td style="font-family: 微软雅黑;">
                                    <%#Eval("userclass")%>
                                </td>
                                <td style="font-family: 微软雅黑;">
                                    <%#Eval("usergrade")%>
                                </td>
                                <td style="font-family: 微软雅黑;">
                                    <%#Eval("usertel")%>
                                </td>
                                
                                <td style="font-family: 微软雅黑;">
                                    <a href='stu.aspx?id=<%#Eval("Id")%>' style="font-family: 微软雅黑;">修改</a>
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