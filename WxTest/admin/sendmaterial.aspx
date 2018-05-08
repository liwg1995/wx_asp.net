<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sendmaterial.aspx.cs" Inherits="WxTest.admin.sendmaterial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>会员管理</title>
    <link href="../css/base.css" rel="stylesheet" type="text/css" />
    <link href="../css/sub.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript">
        //删除上传图片，文件夹里面也需要删除
        $(document).ready(function () {
            $("#send-btn").click(function () {
                var openid = "";
                $("input[name='checkbox']:checkbox:checked").each(function () {
                    openid += $(this).val() + "|";
                })

                $.ajax({
                    type: "post",
                    //dataType:"Text",       
                    url: "../handler/geteway.ashx",
                    data: { "pAction": "sendmaterial", "text": $("#Select1").val(), "openid": openid },
                    dataType: "json",
                    beforeSend: function () {
                        //$("#div_load").visible = true;  
                        $("#messcon").val("");
                    },
                    success: function (msg) {
                        alert(msg);
                    }
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="content">
            <div class="tb1">
                <table class="niunantab">
                    <tbody>
                        <tr>
                            <td class="left_td">标题：
                            </td>
                            <td>
                                <select id="Select1" runat="server">
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;
                            </td>
                            <td>
                                <input id="send-btn" type="button" value="发送" class="btn" />
                            </td>
                        </tr>
                    </tbody>
                </table>
                <table class="niunantab">
                    <tbody>
                        <tr>
                            <th style="font-family: 微软雅黑;">选择
                            </th>
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
                            </th>
                            <th style="font-family: 微软雅黑;">关注时间
                            </th>
                            <th style="font-family: 微软雅黑;">小组
                            </th>
                            <th style="font-family: 微软雅黑;">备注
                            </th>
                            <th style="font-family: 微软雅黑;">特权
                            </th>

                        </tr>
                        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                            <ItemTemplate>
                                <tr>
                                    <td style="font-family: 微软雅黑;">
                                        <input type="checkbox" name="checkbox" value="<%#Eval("openid")%>">
                                    </td>
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
