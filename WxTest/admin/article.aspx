<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="article.aspx.cs" Inherits="WxTest.admin.article" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>后台管理</title>
    <link href="../css/base.css" rel="stylesheet" type="text/css" />
    <link href="../css/sub.css" rel="stylesheet" type="text/css" />
    <script src="../kindeditor/kindeditor.js" type="text/javascript"></script>

    <script type="text/javascript">
        KE.show({
            id: 'txtcontent',
            imageUploadJson: '../../../handler/upload_json.ashx'
        });
    </script>

    <link href="../Uploadify/uploadify.css" rel="stylesheet" type="text/css" />

    <script src="../Uploadify/jquery-1.4.2.min.js" type="text/javascript"></script>

    <script src="../Uploadify/jquery.uploadify.v2.1.4.min.js" type="text/javascript"></script>

    <script src="../Uploadify/swfobject.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#uploadify').uploadify({
                'uploader': '../Uploadify/uploadify.swf',
                'script': '../Uploadify.ashx',
                'cancelImg': '../Uploadify/cancel.png',
                'folder': '../uploads',
                'auto': true,
                'buttonText': '',
                'multi': false,
                'buttonImg': '../Uploadify/browse.jpg',
                'fileSizeLimit': '200000000',
                'scriptData': { 'methed': 'uploadFile', 'arg1': 'value1' },
                'onComplete': function (event, queueID, file, serverData, data) {
                    //serverData为服务器端驳回的字符串值

                    document.getElementById("rel").innerHTML = document.getElementById("rel").innerHTML + "</br>" + serverData.toString() + "文件上传成功。";
                    //alert(file.name + "文件上传成功。");

                }
            });
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div id="content">
            <table class="niunantab">
                <tbody>
                    <tr>
                        <td class="left_td">封面：
                        </td>
                        <td>
                            <div id="fileQueue">
                            </div>
                            <input type="file" name="uploadify" id="uploadify" />
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">标题：
                        </td>
                        <td>
                            <asp:TextBox ID="title" runat="server" CssClass="inputtext" Width="500px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">作者：
                        </td>
                        <td>
                            <asp:TextBox ID="author" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <%--     <tr>
                        <td class="left_td">跳转链接：
                        </td>
                        <td>
                            <asp:TextBox ID="content_source_url" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>--%>
                    <tr>
                        <td class="left_td">内容：
                        </td>
                        <td>
                            <asp:TextBox ID="txtcontent" runat="server" CssClass="inputtext" Width="500px" Height="200" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_td">描述：
                        </td>
                        <td>
                            <asp:TextBox ID="digest" runat="server" CssClass="inputtext" Width="500px"></asp:TextBox>
                        </td>
                    </tr>
                    <%--  <tr>
                        <td class="left_td">是否封面：
                        </td>
                        <td>
                            <asp:TextBox ID="show_cover_pic" runat="server" CssClass="inputtext" Width="200px"></asp:TextBox>
                        </td>
                    </tr>--%>


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
