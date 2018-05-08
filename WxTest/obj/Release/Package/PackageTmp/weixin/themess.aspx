<%@ Page Title="" Language="C#" MasterPageFile="~/weixin/main.Master" AutoEventWireup="true" CodeBehind="themess.aspx.cs" Inherits="WxTest.weixin.themess" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page">


        <div class="simplebox">
            <h1 class="titleh">留言反馈</h1>
            <div class="content">

                <form id="form12" name="form1" method="post" action="">

                    <div class="form-line">
                        <label class="st-label">学号</label>
                        <input type="text" name="textfield" id="userid" style="width: 50%;" runat="server" />
                    </div>

                    <div class="form-line">
                        <label class="st-label">留言反馈</label>

                        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Style="width: 50%;"></asp:TextBox>
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
