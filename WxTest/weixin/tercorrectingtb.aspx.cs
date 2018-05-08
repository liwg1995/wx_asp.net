using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class tercorrectingtb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if ((string)Session["UserType"] == "老师")
                {
                    Business.correcting correcting = new Business.correcting();
                    Repeater1.DataSource = correcting.Get("");
                    Repeater1.DataBind();
                    correcting = null;
                }
                else
                {
                    Response.Redirect("login.aspx");
                }

            }
        }
    }
}