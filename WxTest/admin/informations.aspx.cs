using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class informations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    Business.informations informations = new Business.informations();
                    Business.informationsData[] informationsdata = informations.Select(string.Format(" and id ={0}", Request.QueryString["id"]));

                    thetit.Text = informationsdata[0].thetit;
                    DropDownList1.SelectedValue = informationsdata[0].thetype;
                    //thetime.Text = informationsdata[0].thetime;
                    userid.Text = informationsdata[0].userid;
                    memos.Text = informationsdata[0].memos;
                    userclass.Text = informationsdata[0].userclass;


                    informations = null;
                    informationsdata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.informations informations = new Business.informations();
            Business.informationsData informationsdata = new Business.informationsData();

            informationsdata.thetit = thetit.Text;
            informationsdata.thetype = DropDownList1.SelectedValue;
            informationsdata.thetime = DateTime.Now.ToString();
            informationsdata.userid = userid.Text;
            informationsdata.memos = memos.Text;
            informationsdata.userclass = userclass.Text;


            if (Request.QueryString["id"] != null)
            {
                informationsdata.Id = Request.QueryString["id"];
                informations.Modify(informationsdata);
            }
            else
            {
                informations.Insert(informationsdata);
            }

            Response.Redirect("informationstb.aspx");

            informations = null;
            informationsdata = null;
        }
    }
}