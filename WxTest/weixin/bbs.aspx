<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bbs.aspx.cs" Inherits="WxTest.weixin.bbs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, minimum-scale=1.0, maximum-scale=1.0" />
    <title>微群</title>
    <link rel="stylesheet" type="text/css" href="css/_style.css" />
    <link rel="stylesheet" type="text/css" href="css/_mobile.css" />
    <link rel="stylesheet" type="text/css" href="css/primary-red.css" />
    <script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
    <!--[if lt IE 9]>
      <link rel="stylesheet" href="css/IE.css" />
      <script src="http//html5shiv.googlecode.com/svn/trunk/html5.js"></script>
      <![endif]-->
    <!--[if lte IE 8]>
      <script type="text/javascript" src="js/IE.js"></script>
      <![endif]-->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <style>
        body
        {
            font-family: Microsoft Yahei;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section id="content-container" class="clearfix">
            <div id="main-wrap" class="clearfix">
                <div class="page_content blog_page_content">
                    <div id="post-1">
                        <article class="preview blog-main-preview">
                            <p class="tt-comment-count">微群</p>
                            <div id="blog-comment-outer-wrap">
                                <ol class="comment-ol" id="post-comments">
                                    <asp:Repeater ID="Repeater1" runat="server">
                                        <ItemTemplate>
                                            <li class="comment even thread-even depth-1" id="li-comment-<%#Eval("id")%>">
                                                <div class="comment-wrap">
                                                    <div class="comment-content" id="comment-8">
                                                        <div class="comment-gravatar">
                                                            <img src="img/one_1.gif" class="avatar avatar-60 photo" height="60" width="60" />
                                                        </div>
                                                        <div class="comment-text">
                                                            <span class="comment-author"><a href="#" rel="external nofollow" class="url"><%#Eval("userid")%></a></span>
                                                            <span class="comment-date"><%#Eval("thetime")%></span>
                                                            <p><%#Eval("memos")%></p>
                                                        </div>
                                                    </div>
                                                </div>
                                            </li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ol>
                                <div id="respond">
                                    <h3 class="comment-title">留言</h3>
                                    <div class="comment-cancel"><a rel="nofollow" id="cancel-comment-reply-link" href="/Sterling/truethemes-premium-wordpress#respond" style="display: none;">Click here to cancel reply.</a></div>

                                    <p>
                                        <label for="url">请输入您的留言</label>
                                    </p>
                                    <p>
                                        <textarea name="comment" id="comment" cols="58" rows="10" tabindex="4" runat="server"></textarea>
                                    </p>
                                    <p>
                                        <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click"></asp:Button>
                                    </p>
                                </div>
                            </div>
                        </article>
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
