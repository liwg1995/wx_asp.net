using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest
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
                Session["UserName"] = us.UserName;
                Session["UserId"] = TextBox1.Text;
                Session["UserClass"] = us.UserClass;
                if (us.UserType == "老师")
                {
                    Response.Redirect("ter/index.html");
                }
                else if (us.UserType == "管理员")
                {
                    Response.Redirect("admin/index.html");
                }

            }
            else
            {
                lblInfo.InnerHtml = us.ErrMsg;
            }
        }
    }
}