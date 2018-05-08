<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="themesstb.aspx.cs" Inherits="WxTest.weixin.themesstb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">
        <div class="simplebox">
            <h1 class="titleh">在线答疑</h1>
            <div class="content">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="get-photo">
                            问题：<%#Eval("messcon")%>
                            <br />
                            回答：<%#Eval("replys")%>
                            <div class="clear">
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
