<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="stu.aspx.cs" Inherits="WxTest.weixin.stu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">

        <div class="simplebox">
            <h1 class="titleh">学生信息</h1>
            <div class="content">

                <!-- start statistics -->
                <ul class="statistics">
                    <li>学号
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
                    <li>专业
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label5" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    <li>年级
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label6" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    <li>班级
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label7" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                    <li>联系方式
                        <p>
                            <span class="green"><b>
                                <asp:Label ID="Label8" runat="server" Text=""></asp:Label></b> </span>
                        </p>
                    </li>
                </ul>
                <!-- end statistics -->

            </div>
        </div>




        <div class="clear"></div>
    </div>
</asp:Content>
