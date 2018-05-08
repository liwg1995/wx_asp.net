using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class informationstb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lbtype.Text = Request.QueryString["type"];
                Business.informations article = new Business.informations();
                if (Request.QueryString["type"] != null)
                {
                    Repeater1.DataSource = article.Get(string.Format(" and thetype ='{0}'", Request.QueryString["type"]));
                }
                else
                {
                    Repeater1.DataSource = article.Get("");
                }
                Repeater1.DataBind();
                article = null;
            }
        }
    }
}