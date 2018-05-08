using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.users users = new Business.users();
                    Business.usersData[] usersdata = users.Select(Request.QueryString["id"]);

                    userid.Text = usersdata[0].userid;
                    userpwrd.Text = usersdata[0].userpwrd;
                    username.Text = usersdata[0].username;
                    DropDownList1.SelectedValue = usersdata[0].usertype;
                    userclass.Text = usersdata[0].userclass;

                    users = null;
                    usersdata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.users users = new Business.users();
            Business.usersData usersdata = new Business.usersData();

            usersdata.userid = userid.Text;
            usersdata.userpwrd = userpwrd.Text;
            usersdata.username = username.Text;
            usersdata.usertype = DropDownList1.SelectedValue;
            usersdata.userclass = userclass.Text;

            if (Request.QueryString["id"] != null)
            {
                usersdata.Id = Request.QueryString["id"];
                users.Modify(usersdata);
            }
            else
            {
                users.Insert(usersdata);
            }

            Response.Redirect("userstb.aspx");

            users = null;
            usersdata = null;
        }
    }
}