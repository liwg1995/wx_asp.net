using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class correcting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.correcting correcting = new Business.correcting();
                    Business.correctingData[] correctingdata = correcting.Select(Request.QueryString["id"]);

                    hwtit.Text = correctingdata[0].hwtit;
                    userid.Text = correctingdata[0].userid;
                    ctime.Text = correctingdata[0].ctime;
                    ccon.Text = correctingdata[0].ccon;
                    ter.Text = correctingdata[0].ter;
                    cdate.Text = correctingdata[0].cdate;
                    scores.Text = correctingdata[0].scores;
                    messages.Text = correctingdata[0].messages;


                    correcting = null;
                    correctingdata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.correcting correcting = new Business.correcting();
            Business.correctingData correctingdata = new Business.correctingData();

            correctingdata.hwtit = hwtit.Text;
            correctingdata.userid = userid.Text;
            correctingdata.ctime = ctime.Text;
            correctingdata.ccon = ccon.Text;
            correctingdata.ter = ter.Text;
            correctingdata.cdate = cdate.Text;
            correctingdata.scores = scores.Text;
            correctingdata.messages = messages.Text;


            if (Request.QueryString["id"] != null)
            {
                correctingdata.Id = Request.QueryString["id"];
                correcting.Modify(correctingdata);
            }
            else
            {
                correcting.Insert(correctingdata);
            }

            Response.Redirect("correctingtb.aspx");

            correcting = null;
            correctingdata = null;
        }
    }
}