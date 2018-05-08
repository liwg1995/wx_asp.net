<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="correctingtb.aspx.cs" Inherits="WxTest.weixin.correctingtb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">
        <div class="simplebox">
            <h1 class="titleh">我的单元测试</h1>
            <div class="content">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="get-photo">
                            <%#Eval("hwtit")%>
                            <br />
                            <%#Eval("ctime")%> <br />
                            单元测试：<br /> <%#Eval("ccon")%><br />
                            成绩： <%#Eval("scores")%><br />
                            留言:
                            <%#Eval("messages")%>
                            <div class="clear">
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
