using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class sendmaterial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.material material = new Business.material();
                ArrayList ar = new ArrayList();
                List<Business.materialData> hdlist = material.GetList(string.Format(" and materialtype ='{0}'", Request.QueryString["type"]));
                for (int i = 0; i < hdlist.Count; i++)
                {
                    ListItem item = new ListItem(hdlist[i].materialtit, hdlist[i].Id);
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