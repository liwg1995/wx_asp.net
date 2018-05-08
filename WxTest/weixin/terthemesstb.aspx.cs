using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class terthemesstb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if ((string)Session["UserType"] == "老师")
                {
                    if ((string)Session["UserId"] != null)
                    {
                        Business.themess themess = new Business.themess();
                        Repeater1.DataSource = themess.Get("");
                        Repeater1.DataBind();
                        themess = null;
                    }
                    else
                    {
                        Response.Redirect("login.aspx");
                    }
                }
                else
                {
                    Response.Redirect("login.aspx");
                }


            }
        }
    }
}