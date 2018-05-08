using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.weixin
{
    public partial class userinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if ((string)Session["UserId"] != null)
                {
                    Business.users stu = new Business.users();
                    Business.usersData[] studata = stu.Put(string.Format(" and userid ='{0}'", (string)Session["UserId"]));

                    Label1.Text = studata[0].userid;
                    Label2.Text = studata[0].userpwrd;
                    Label3.Text = studata[0].username;
                    Label4.Text = studata[0].usertype;


                    stu = null;
                    studata = null;
                }
                else
                {
                    Response.Redirect("login.aspx");
                }
            }
        }
    }
}