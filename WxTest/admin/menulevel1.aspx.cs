using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class menulevel1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.menulevel1 menulevel1 = new Business.menulevel1();
                    Business.menulevel1Data[] menulevel1data = menulevel1.Select(Request.QueryString["id"]);

                    menuname.Text = menulevel1data[0].menuname;
                    nums.Text = menulevel1data[0].nums;


                    menulevel1 = null;
                    menulevel1data = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.menulevel1 menulevel1 = new Business.menulevel1();
            Business.menulevel1Data menulevel1data = new Business.menulevel1Data();

            menulevel1data.menuname = menuname.Text;
            menulevel1data.nums = nums.Text;


            if (Request.QueryString["id"] != null)
            {
                menulevel1data.Id = Request.QueryString["id"];
                menulevel1.Modify(menulevel1data);
            }
            else
            {
                menulevel1.Insert(menulevel1data);
            }

            Response.Redirect("menulevel1tb.aspx");

            menulevel1 = null;
            menulevel1data = null;
        }
    }
}