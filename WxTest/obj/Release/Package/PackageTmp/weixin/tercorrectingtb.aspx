<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="tercorrectingtb.aspx.cs" Inherits="WxTest.weixin.tercorrectingtb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">
        <div class="simplebox">
            <h1 class="titleh">我的作业</h1>
            <div class="content">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="get-photo">
                            <%#Eval("hwtit")%>
                            <br />
                            <%#Eval("ctime")%>
                            <br />
                            学号：<%#Eval("userid")%>
                            <span style="float:right;"><a href="tercorrecting.aspx?id=<%#Eval("id")%>">批改</a></span>
                            <br />
                            <div class="clear">
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
