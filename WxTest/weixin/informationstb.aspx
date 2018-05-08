<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="informationstb.aspx.cs" Inherits="WxTest.weixin.informationstb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">
        <!-- start list menu -->
        <div class="simplebox">
            <h1 class="titleh"><asp:Label ID="lbtype" runat="server" Text=""></asp:Label></h1>
            <ul class="list-menu">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <li><a href="informations.aspx?id=<%#Eval("id")%>"><b>
                            <%#Eval("thetit")%></b></a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
        <div class="clear">
        </div>
    </div>
</asp:Content>
