using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class correcting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                username.Value = (string)Session["UserName"];
                userid.Value = (string)Session["UserId"];
                Label2.Text = Request.QueryString["hwtit"];
                Business.thetitle thetitle = new Business.thetitle();
                Repeater1.DataSource = thetitle.Get(string.Format(" and hwid ='{0}'",Request.QueryString["id"]));
                Repeater1.DataBind();
                thetitle = null;
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
                Business.correcting correcting = new Business.correcting();
                Business.correctingData correctingdata = new Business.correctingData();

                string ccon = "";

                foreach (RepeaterItem ri in Repeater1.Items)
                {
                    Label key = (Label)ri.FindControl("Label1");
                    TextBox value = (TextBox)ri.FindControl("TextBox1");
                    ccon += "题目：" + key.Text + "<br/>答案：" + value.Text + "<br/>";
                }

                correctingdata.hwtit = Label2.Text;
                correctingdata.userid = userid.Value;
                correctingdata.ctime = DateTime.Now.ToString();
                correctingdata.ccon = ccon;
                correctingdata.ter = "";
                correctingdata.cdate = "";
                correctingdata.scores = "";
                correctingdata.messages = "";
                correcting.Insert(correctingdata);

                Response.Redirect("correctingtb.aspx");
            }
          
        }
    }
}