using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class informations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                Business.informations article = new Business.informations();
                Business.informationsData[] articledata = article.Select(string.Format(" and id ='{0}'", Request.QueryString["id"]));

                lbtit.Text = articledata[0].thetit;
                lbcon.Text = articledata[0].memos;

                article = null;
                articledata = null;
            }
        }
    }
}