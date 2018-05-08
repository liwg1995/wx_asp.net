using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class correctingtb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.correcting correcting = new Business.correcting();
                Repeater1.DataSource = correcting.Get("");
                Repeater1.DataBind();
                correcting = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.correcting correcting = new Business.correcting();
            correcting.Delete(Id);
            Repeater1.DataSource = correcting.Get("");
            Repeater1.DataBind();
            correcting = null;
        }
    }
}