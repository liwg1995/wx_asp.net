using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class materialtb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.material material = new Business.material();
                Repeater1.DataSource = material.Get(string.Format(" and materialtype = '{0}'", Request.QueryString["type"]));
                Repeater1.DataBind();
                material = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.material material = new Business.material();
            material.Delete(Id);
            Repeater1.DataSource = material.Get(string.Format(" and materialtype = '{0}'", Request.QueryString["type"]));
            Repeater1.DataBind();
            material = null;
        }
    }
}