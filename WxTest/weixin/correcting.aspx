<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="correcting.aspx.cs" Inherits="WxTest.weixin.correcting" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">


        <div class="simplebox">
            <h1 class="titleh">单元测试填写</h1>
            <div class="content">

                <form id="form12" name="form1" method="post" action="">

                    <div class="form-line">
                        <label class="st-label">单元测试</label>
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </div>

                    <div class="form-line">
                        <label class="st-label">名字</label>
                        <input type="text" name="textfield" id="username" style="width: 50%;" runat="server" />
                    </div>

                    <div class="form-line">
                        <label class="st-label">学号</label>
                        <input type="text" name="textfield" id="userid" style="width: 50%;" runat="server" />
                    </div>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class="form-line">
                                <label class="st-label"><%#Eval("id")%>.<asp:Label ID="Label1" runat="server" Text='<%#Eval("thetitle")%>'></asp:Label></label>
                                <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Style="width: 50%;"></asp:TextBox>

                            </div>

                        </ItemTemplate>
                    </asp:Repeater>



                    <div class="form-line">
                        <asp:Button ID="Button1" runat="server" Text="提 交" CssClass="submit-button" OnClick="Button1_Click" />

                    </div>

                </form>

            </div>
        </div>


        <div class="clear"></div>
    </div>
</asp:Content>
