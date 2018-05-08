<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="homework.aspx.cs" Inherits="WxTest.weixin.homework" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="searchbox" style="display: block;">
        <input type="text" name="textfield" id="textfield" class="txtbox" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="查找" OnClick="BtnOk_Click" />
    </div>
    <div class="page">
        <div class="simplebox">
            <h1 class="titleh"><asp:Label ID="Label1" runat="server" Text=""></asp:Label></h1>
            
            <div class="content">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="get-photo">
                            <a href="correcting.aspx?id=<%#Eval("id")%>&hwtit=<%#Eval("hwtit")%>">
                                <%#Eval("hwtit")%>  </a>
                            <br />

                            <%#Eval("hwtime")%> 老师： <%#Eval("hwer")%><br />
                            要求:
                            <%#Eval("press")%>
                            <div class="clear">
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
