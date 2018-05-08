using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class userinfotb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.userinfo userinfo = new Business.userinfo();
                Repeater1.DataSource = userinfo.Get("");
                Repeater1.DataBind();
                userinfo = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.userinfo userinfo = new Business.userinfo();
            userinfo.Delete(Id);
            Repeater1.DataSource = userinfo.Get("");
            Repeater1.DataBind();
            userinfo = null;
        }
    }
}