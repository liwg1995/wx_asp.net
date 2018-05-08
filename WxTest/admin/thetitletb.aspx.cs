using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class thetitletb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.thetitle thetitle = new Business.thetitle();
                Repeater1.DataSource = thetitle.Get("");
                Repeater1.DataBind();
                thetitle = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.thetitle thetitle = new Business.thetitle();
            thetitle.Delete(Id);
            Repeater1.DataSource = thetitle.Get("");
            Repeater1.DataBind();
            thetitle = null;
        }
    }
}