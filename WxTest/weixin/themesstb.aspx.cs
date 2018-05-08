using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class themesstb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if ((string)Session["UserId"] != null)
                {
                    Business.themess themess = new Business.themess();
                    Repeater1.DataSource = themess.Get(string.Format(" and userid ='{0}'", (string)Session["UserId"]));
                    Repeater1.DataBind();
                    themess = null;
                }
                else
                {
                    Response.Redirect("login.aspx");
                }

            }
        }
    }
}