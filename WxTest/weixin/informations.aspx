<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="informations.aspx.cs" Inherits="WxTest.weixin.informations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">
        <div class="simplebox">
            <h1 class="titleh">
                <asp:Label ID="lbtit" runat="server" Text="Label"></asp:Label>
            </h1>
            <div class="content">
                <asp:Label ID="lbcon" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
        <div class="clear">
        </div>
    </div>
</asp:Content>
