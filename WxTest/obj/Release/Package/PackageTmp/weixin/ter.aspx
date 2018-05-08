<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="ter.aspx.cs" Inherits="WxTest.weixin.ter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">

        <div class="simplebox">
            <h1 class="titleh">老师信息</h1>
            <div class="content">

                <!-- start statistics -->
                <ul class="statistics">
                    <li>编号 
                      <p>
                          <span class="green"><b>
                              <asp:Label ID="Label1" runat="server" Text=""></asp:Label></b> </span>
                      </p>
                    </li>
                    <li>姓名
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label2" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    <li>年龄
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label3" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    <li>性别
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label4" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    <li>职称
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label5" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    <li>院系
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label6" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    <li>联系方式
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label7" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    
                </ul>
                <!-- end statistics -->

            </div>
        </div>




        <div class="clear"></div>
    </div>
</asp:Content>
