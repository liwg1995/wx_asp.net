using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class messgaetb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.messgae messgae = new Business.messgae();
                Repeater1.DataSource = messgae.Get("");
                Repeater1.DataBind();
                messgae = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.messgae messgae = new Business.messgae();
            messgae.Delete(Id);
            Repeater1.DataSource = messgae.Get("");
            Repeater1.DataBind();
            messgae = null;
        }
    }
}