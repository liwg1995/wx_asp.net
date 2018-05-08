using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class menulevel2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["level1id"] != null)
                {
                    level1id.Text = Request.QueryString["level1id"];
                }
                if (Request.QueryString["id"] != null)
                {
                    Business.menulevel2 menulevel2 = new Business.menulevel2();
                    Business.menulevel2Data[] menulevel2data = menulevel2.Select(Request.QueryString["id"]);

                    level1id.Text = menulevel2data[0].level1id;
                    menutype.Text = menulevel2data[0].menutype;
                    menuname.Text = menulevel2data[0].menuname;
                    menuurl.Text = menulevel2data[0].menuurl;
                    nums.Text = menulevel2data[0].nums;


                    menulevel2 = null;
                    menulevel2data = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.menulevel2 menulevel2 = new Business.menulevel2();
            Business.menulevel2Data menulevel2data = new Business.menulevel2Data();

            menulevel2data.level1id = level1id.Text;
            menulevel2data.menutype = menutype.Text;
            menulevel2data.menuname = menuname.Text;
            menulevel2data.menuurl = menuurl.Text;
            menulevel2data.nums = nums.Text;


            if (Request.QueryString["id"] != null)
            {
                menulevel2data.Id = Request.QueryString["id"];
                menulevel2.Modify(menulevel2data);
            }
            else
            {
                menulevel2.Insert(menulevel2data);
            }

            Response.Redirect("menulevel2tb.aspx");

            menulevel2 = null;
            menulevel2data = null;
        }
    }
}