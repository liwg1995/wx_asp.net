<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regsis.aspx.cs" Inherits="WxTest.weixin.regsis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="gb2312">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="keywords" content="leanote,leanote.com">
    <meta name="description" content="leanote, Not Just A Notepad!">
    <meta name="author" content="leanote">
    <title>注册</title>
    <link href="css/bootstrap-min.css" rel="stylesheet">
    <link href="css/index.css?t=2016" rel="stylesheet">
    <style>
        html, body {
            height: 100%;
        }
    </style>
</head>
<body id="boxBody">

    <section id="box" class="animated fadeInUp">
        <div>
            <h1 id="logo"></h1>
            <div id="boxForm">
                <div id="boxHeader">注册</div>
                <form id="form1" runat="server">
                    <div class="alert alert-danger" id="loginMsg"></div>
                    <input id="from" type="hidden" value="" />
                    <div class="form-group">
                        <label class="control-label">账号</label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label class="control-label">密码</label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label class="control-label">确认密码</label>
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label class="control-label">姓名</label>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div id="captchaContainer">
                    </div>
                    <div class="clearfix">
                        <asp:Button ID="Button1" runat="server" Text="注册" CssClass="btn btn-success" OnClick="Button1_Click" /><span id="lblInfo" runat="server" style="color: Red; font-size: 12px;"></span>
                    </div>
                    <div class="line line-dashed"></div>

                </form>
            </div>
        </div>
    </section>

    <script>
        $(function () {
            var needCaptcha = "";

            if (needCaptcha) {
                $("#captchaContainer").html($("#tCaptcha").html());
            }

            $("#email").focus();
            if ($("#email").val()) {
                $("#pwd").focus();
            }
            function showMsg(msg, id) {
                $("#loginMsg").html(msg).show();
                if (id) {
                    $("#" + id).focus();
                }
            }
            function hideMsg() {
                $("#loginMsg").hide();
            }
            $("#loginBtn").click(function (e) {
                e.preventDefault();
                var email = $("#email").val();
                var pwd = $("#pwd").val();
                var captcha = $("#captcha").val()
                if (!email) {
                    showMsg("input username", "email");
                    return;
                }
                if (!pwd) {
                    showMsg("Password is required", "pwd");
                    return;
                } else {
                    if (pwd.length < 6) {
                        showMsg("Wrong password", "pwd");
                        return;
                    }
                }
                if (needCaptcha && !captcha) {
                    showMsg("Captcha is required", "captcha");
                    return;
                }

                $("#loginBtn").html("Sign in...").addClass("disabled");



                document.cookie = "LEANOTE_SESSION=; expires=" + (new Date(0).toUTCString()) + ';domain=leanote.com; path=/';

                document.cookie = "LEANOTE_SESSION=; expires=" + (new Date(0).toUTCString());

                $.post("/doLogin", { email: email, pwd: pwd, captcha: $("#captcha").val() }, function (e) {
                    $("#loginBtn").html("Sign in").removeClass("disabled");
                    if (e.Ok) {
                        $("#loginBtn").html("login success...");
                        var from = $("#from").val() || "/note";
                        location.href = from;
                    } else {
                        if (e.Item && $.trim($("#captchaContainer").text()) == "") {
                            $("#captchaContainer").html($("#tCaptcha").html());
                            needCaptcha = true
                        }

                        showMsg(e.Msg);
                    }
                });
            });


            $(".btn-third").click(function (e) {
                e.preventDefault();
                $(this).button("loading");
                var id = $(this).attr('id');
                location.href = '/oauth/url?t=' + id;
            });
        });
    </script>

</body>
</html>
