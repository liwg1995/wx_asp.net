using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class messgae : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.messgae messgae = new Business.messgae();
                    Business.messgaeData[] messgaedata = messgae.Select(Request.QueryString["id"]);

                    messtit.Text = messgaedata[0].messtit;
                    messtime.Text = messgaedata[0].messtime;
                    messcon.Text = messgaedata[0].messcon;


                    messgae = null;
                    messgaedata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.messgae messgae = new Business.messgae();
            Business.messgaeData messgaedata = new Business.messgaeData();

            messgaedata.messtit = messtit.Text;
            messgaedata.messtime = messtime.Text;
            messgaedata.messcon = messcon.Text;


            if (Request.QueryString["id"] != null)
            {
                messgaedata.Id = Request.QueryString["id"];
                messgae.Modify(messgaedata);
            }
            else
            {
                messgae.Insert(messgaedata);
            }

            Response.Redirect("messgaetb.aspx");

            messgae = null;
            messgaedata = null;
        }
    }
}