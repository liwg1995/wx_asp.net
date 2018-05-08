using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class correctingtb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.correcting correcting = new Business.correcting();
                Repeater1.DataSource = correcting.Get(string.Format(" and userid ='{0}'",(string)Session["UserId"]));
                Repeater1.DataBind();
                correcting = null;
            }
        }
    }
}