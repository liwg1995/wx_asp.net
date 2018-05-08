using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class themess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.themess themess = new Business.themess();
                    Business.themessData[] themessdata = themess.Select(Request.QueryString["id"]);

                    userid.Text = themessdata[0].userid;
                    messtime.Text = themessdata[0].messtime;
                    messcon.Text = themessdata[0].messcon;
                    ter.Text = themessdata[0].ter;
                    replys.Text = themessdata[0].replys;


                    themess = null;
                    themessdata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.themess themess = new Business.themess();
            Business.themessData themessdata = new Business.themessData();

            themessdata.userid = userid.Text;
            themessdata.messtime = messtime.Text;
            themessdata.messcon = messcon.Text;
            themessdata.ter = ter.Text;
            themessdata.replys = replys.Text;


            if (Request.QueryString["id"] != null)
            {
                themessdata.Id = Request.QueryString["id"];
                themess.Modify(themessdata);
            }
            else
            {
                themess.Insert(themessdata);
            }

            Response.Redirect("themesstb.aspx");

            themess = null;
            themessdata = null;
        }
    }
}