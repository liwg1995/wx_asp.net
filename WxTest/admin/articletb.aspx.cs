using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class articletb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.article article = new Business.article();
                Repeater1.DataSource = article.Get("");
                Repeater1.DataBind();
                article = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.article article = new Business.article();
            article.Delete(Id);
            Repeater1.DataSource = article.Get("");
            Repeater1.DataBind();
            article = null;
        }
    }
}