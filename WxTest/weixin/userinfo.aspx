<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="userinfo.aspx.cs" Inherits="WxTest.weixin.userinfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">
        <div class="simplebox">
            <h1 class="titleh">用户信息</h1>
            <div class="content">

                <!-- start statistics -->
                <ul class="statistics">
                    <li>账号
                      <p>
                          <span class="green"><b>
                              <asp:Label ID="Label1" runat="server" Text=""></asp:Label></b> </span>
                      </p>
                    </li>
                    <li>密码
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label2" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    <li>姓名
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label3" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    <li>级别
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label4" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                </ul>
                <!-- end statistics -->

            </div>
        </div>
        <div class="clear"></div>
    </div>
</asp:Content>
