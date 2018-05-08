using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class homework : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.homework homework = new Business.homework();
                    Business.homeworkData[] homeworkdata = homework.Select(Request.QueryString["id"]);

                    hwtit.Text = homeworkdata[0].hwtit;
                    hwtime.Text = homeworkdata[0].hwtime;
                    hwer.Text = homeworkdata[0].hwer;
                    press.Text = homeworkdata[0].press;
                    DropDownList1.SelectedValue = homeworkdata[0].userclass;

                    homework = null;
                    homeworkdata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.homework homework = new Business.homework();
            Business.homeworkData homeworkdata = new Business.homeworkData();

            homeworkdata.hwtit = hwtit.Text;
            homeworkdata.hwtime = hwtime.Text;
            homeworkdata.hwer = hwer.Text;
            homeworkdata.press = press.Text;
            homeworkdata.userclass = DropDownList1.SelectedValue;

            if (Request.QueryString["id"] != null)
            {
                homeworkdata.Id = Request.QueryString["id"];
                homework.Modify(homeworkdata);
            }
            else
            {
                homework.Insert(homeworkdata);
            }

            Response.Redirect("homeworktb.aspx");

            homework = null;
            homeworkdata = null;
        }
    }
}