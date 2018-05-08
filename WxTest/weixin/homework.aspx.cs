using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class homework : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["UserId"] != null)
                {
                    Label1.Text = Request.QueryString["type"];
                    Business.homework books = new Business.homework();
                    Repeater1.DataSource = books.Get(string.Format(" and userclass ='{0}'", Request.QueryString["type"]));
                    Repeater1.DataBind();
                    books = null;
                }
                else
                {
                    Response.Redirect("login.aspx");
                }

            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.homework books = new Business.homework();
            Repeater1.DataSource = books.Get(string.Format(" and hwtit like '%{0}%' ", textfield.Value, (string)Session["UserClass"]));
            Repeater1.DataBind();
            books = null;
        }
    }
}