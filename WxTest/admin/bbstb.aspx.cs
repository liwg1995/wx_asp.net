using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class bbstb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.bbs bbs = new Business.bbs();
                Repeater1.DataSource = bbs.Get("");
                Repeater1.DataBind();
                bbs = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.bbs bbs = new Business.bbs();
            bbs.Delete(Id);
            Repeater1.DataSource = bbs.Get("");
            Repeater1.DataBind();
            bbs = null;
        }
    }
}