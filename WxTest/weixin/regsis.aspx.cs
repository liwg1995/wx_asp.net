using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class regsis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != TextBox3.Text)
            {
                lblInfo.InnerHtml = "两次密码不一致！";
            }
            else if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "")
            {

                lblInfo.InnerHtml = "请输入完整信息！";
            }
            else
            {
                Business.users users = new Business.users();
                Business.usersData usersdata = new Business.usersData();

                usersdata.userid = TextBox1.Text;
                usersdata.userpwrd = TextBox2.Text;
                usersdata.username = TextBox4.Text;
                usersdata.usertype = "学生";
                usersdata.userclass = "0";
                users.Insert(usersdata);

                Response.Redirect("login.aspx");

                users = null;
                usersdata = null;
            }

        }
    }


}