using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class bbs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.bbs bbs = new Business.bbs();
                Repeater1.DataSource = bbs.Get("");
                Repeater1.DataBind();
                bbs = null;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                Business.bbs bbs = new Business.bbs();
                Business.bbsData bbsdata = new Business.bbsData();

                bbsdata.userid = (string)Session["UserId"];
                bbsdata.thetime = DateTime.Now.ToString();
                bbsdata.memos = comment.Value.Trim();

                bbs.Insert(bbsdata);

                comment.Value = "";
                Repeater1.DataSource = bbs.Get("");
                Repeater1.DataBind();

            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}