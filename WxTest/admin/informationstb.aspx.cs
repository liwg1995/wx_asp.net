using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class informationstb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.informations informations = new Business.informations();
                Repeater1.DataSource = informations.Get("");
                Repeater1.DataBind();
                informations = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.informations informations = new Business.informations();
            informations.Delete(Id);
            Repeater1.DataSource = informations.Get("");
            Repeater1.DataBind();
            informations = null;
        }
    }
}