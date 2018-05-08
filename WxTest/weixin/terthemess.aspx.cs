using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class terthemess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Response.Write("<script>alert('请填写你的回复！')</script>");
            }
            else
            {
                Business.themess themess = new Business.themess();
                themess.Update(Request.QueryString["id"],TextBox1.Text);
                Response.Redirect("terthemesstb.aspx");


            }
        }
    }
}