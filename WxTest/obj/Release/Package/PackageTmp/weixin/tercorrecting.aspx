<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="tercorrecting.aspx.cs" Inherits="WxTest.weixin.tercorrecting"  EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">


        <div class="simplebox">
            <h1 class="titleh">作业批改</h1>
            <div class="content">

                <form id="form12" name="form1" method="post" action="">

                    <div class="form-line">
                        <label class="st-label">学号</label>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </div>

                    <div class="form-line">
                        <label class="st-label">时间</label>
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </div>

                    <div class="form-line">
                        <label class="st-label">作业内容</label>
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </div>

                    <div class="form-line">
                        <label class="st-label">成绩</label>
                        <input type="text" name="textfield" id="Text2" style="width: 20%;" runat="server" />
                    </div>

                    <div class="form-line">
                        <label class="st-label">评语</label>
                        <input type="text" name="textfield" id="Text3" style="width: 50%;" runat="server" />
                    </div>
                    <div class="form-line">
                        <asp:Button ID="Button1" runat="server" Text="提 交" CssClass="submit-button" OnClick="Button1_Click" />

                    </div>

                </form>

            </div>
        </div>


        <div class="clear"></div>
    </div>
</asp:Content>
