using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class userstb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.users users = new Business.users();
                Repeater1.DataSource = users.Get("");
                Repeater1.DataBind();
                users = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.users users = new Business.users();
            users.Delete(Id);
            Repeater1.DataSource = users.Get("");
            Repeater1.DataBind();
            users = null;
        }
    }
}