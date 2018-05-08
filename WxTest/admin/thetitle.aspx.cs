using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class thetitle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["hwid"] != null)
                {
                    hwid.Text = Request.QueryString["hwid"];
                }
                if (Request.QueryString["id"] != null)
                {
                    Business.thetitle thetitle = new Business.thetitle();
                    Business.thetitleData[] thetitledata = thetitle.Select(Request.QueryString["id"]);

                    hwid.Text = thetitledata[0].hwid;
                    thetitles.Text = thetitledata[0].thetitle;
                    memos.Text = thetitledata[0].memos;


                    thetitle = null;
                    thetitledata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.thetitle thetitle = new Business.thetitle();
            Business.thetitleData thetitledata = new Business.thetitleData();

            thetitledata.hwid = hwid.Text;
            thetitledata.thetitle = thetitles.Text;
            thetitledata.memos = memos.Text;


            if (Request.QueryString["id"] != null)
            {
                thetitledata.Id = Request.QueryString["id"];
                thetitle.Modify(thetitledata);
            }
            else
            {
                thetitle.Insert(thetitledata);
            }

            Response.Redirect("thetitletb.aspx");

            thetitle = null;
            thetitledata = null;
        }
    }
}