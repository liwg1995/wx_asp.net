using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class tercorrecting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.correcting correcting = new Business.correcting();
                    Business.correctingData[] correctingdata = correcting.Select(Request.QueryString["id"]);

                    Label1.Text = correctingdata[0].userid;
                    Label2.Text = correctingdata[0].ctime;
                    Label3.Text = correctingdata[0].ccon;

                    correcting = null;
                    correctingdata = null;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Business.correcting correcting = new Business.correcting();

            correcting.Update(Request.QueryString["id"],Text2.Value,Text3.Value);
            Response.Redirect("tercorrectingtb.aspx");

            correcting = null;
  
        }
    }
}