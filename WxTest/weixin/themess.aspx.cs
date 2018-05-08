using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class themess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                userid.Value = (string)Session["UserId"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (userid.Value == "")
            {
                Response.Write("<script>alert('请填写你的学号姓名！')</script>");
            }
            else
            {
                Business.themess themess = new Business.themess();
                Business.themessData themessdata = new Business.themessData();

                themessdata.userid = userid.Value;
                themessdata.messtime = DateTime.Now.ToString();
                themessdata.messcon = TextBox1.Text;
                themessdata.ter = "";
                themessdata.replys = "";


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
}