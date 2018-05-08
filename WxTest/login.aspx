<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WxTest.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>欢迎登录后台管理系统</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />

    <script language="JavaScript" src="js/jquery.js"></script>

    <script src="js/cloud.js" type="text/javascript"></script>

    <script language="javascript">
	$(function(){
    $('.loginbox').css({'position':'absolute','left':($(window).width()-692)/2});
	$(window).resize(function(){  
    $('.loginbox').css({'position':'absolute','left':($(window).width()-692)/2});
    })  
});  
    </script>

</head>
<body style="background-color: #1c77ac; background-image: url(images/light.png);
    background-repeat: no-repeat; background-position: center top; overflow: hidden;">
    <form id="form1" runat="server">
    <div id="mainBody">
        <div id="cloud1" class="cloud">
        </div>
        <div id="cloud2" class="cloud">
        </div>
    </div>
    <div class="logintop">
        <span>欢迎登录后台管理界面</span>
        <ul>
           
        </ul>
    </div>
    <div class="loginbody">
        <span class="systemlogo"></span>
        <div class="loginbox">
            <ul>
                <li>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="loginuser"></asp:TextBox>
                </li>
                <li>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="loginuser" TextMode="Password"></asp:TextBox></li>
                <li>
                    <asp:Button ID="Button1" runat="server" Text="登录" cssclass="loginbtn" OnClick="Button1_Click" /><span id="lblInfo" runat="server" style="color:Red;font-size:12px;"></span>
                    
                </li>
            </ul>
        </div>
    </div>
    </form>
</body>
</html>
