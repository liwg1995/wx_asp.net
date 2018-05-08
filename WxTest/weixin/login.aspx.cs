using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Business.users us = new Business.users();
            bool b = us.Login(TextBox1.Text, TextBox2.Text);
            if (b)
            {
                Session["UserId"] = TextBox1.Text;
                Session["UserName"] = us.UserName;
                Session["UserType"] = us.UserType;

                Response.Redirect("userinfo.aspx");

            }
            else
            {
                lblInfo.InnerHtml = us.ErrMsg;
            }
        }
    }


}