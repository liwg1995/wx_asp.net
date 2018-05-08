using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class homeworktb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.homework homework = new Business.homework();
                Repeater1.DataSource = homework.Get("");
                Repeater1.DataBind();
                homework = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.homework homework = new Business.homework();
            homework.Delete(Id);
            Repeater1.DataSource = homework.Get("");
            Repeater1.DataBind();
            homework = null;
        }
    }
}