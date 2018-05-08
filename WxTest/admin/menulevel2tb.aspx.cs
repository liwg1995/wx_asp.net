using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class menulevel2tb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.menulevel2 menulevel2 = new Business.menulevel2();
                Repeater1.DataSource = menulevel2.Get("");
                Repeater1.DataBind();
                menulevel2 = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.menulevel2 menulevel2 = new Business.menulevel2();
            menulevel2.Delete(Id);
            Repeater1.DataSource = menulevel2.Get("");
            Repeater1.DataBind();
            menulevel2 = null;
        }
    }
}