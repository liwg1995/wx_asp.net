using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class themesstb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.themess themess = new Business.themess();
                Repeater1.DataSource = themess.Get("");
                Repeater1.DataBind();
                themess = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.themess themess = new Business.themess();
            themess.Delete(Id);
            Repeater1.DataSource = themess.Get("");
            Repeater1.DataBind();
            themess = null;
        }
    }
}