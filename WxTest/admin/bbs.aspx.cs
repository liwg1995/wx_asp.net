using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class bbs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.bbs bbs = new Business.bbs();
                    Business.bbsData[] bbsdata = bbs.Select(string.Format(" and id ={0}", Request.QueryString["id"]));

                    userid.Text = bbsdata[0].userid;
                    thetime.Text = bbsdata[0].thetime;
                    memos.Text = bbsdata[0].memos;


                    bbs = null;
                    bbsdata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.bbs bbs = new Business.bbs();
            Business.bbsData bbsdata = new Business.bbsData();

            bbsdata.userid = userid.Text;
            bbsdata.thetime = thetime.Text;
            bbsdata.memos = memos.Text;


            if (Request.QueryString["id"] != null)
            {
                bbsdata.Id = Request.QueryString["id"];
                bbs.Modify(bbsdata);
            }
            else
            {
                bbs.Insert(bbsdata);
            }

            Response.Redirect("bbstb.aspx");

            bbs = null;
            bbsdata = null;
        }
    }
}