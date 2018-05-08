using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class sendarticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.article article = new Business.article();
                ArrayList ar = new ArrayList();
                List<Business.articleData> hdlist = article.GetList("");
                for (int i = 0; i < hdlist.Count; i++)
                {
                    ListItem item = new ListItem(hdlist[i].title, hdlist[i].Id);
                    Select1.Items.Add(item);
                }

                Business.userinfo userinfo = new Business.userinfo();
                Repeater1.DataSource = userinfo.Get("");
                Repeater1.DataBind();
                userinfo = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.userinfo userinfo = new Business.userinfo();
            userinfo.Delete(Id);
            Repeater1.DataSource = userinfo.Get("");
            Repeater1.DataBind();
            userinfo = null;
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        { 
        
        }
    }
}