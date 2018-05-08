using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class material : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.material material = new Business.material();
                    Business.materialData[] materialdata = material.Select(Request.QueryString["id"]);

                    //materialtype.Text = materialdata[0].materialtype;
                    materialtit.Text = materialdata[0].materialtit;
                    Business.users.file = materialdata[0].materialfile;
                    //materialtime.Text = materialdata[0].materialtime;


                    material = null;
                    materialdata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.material material = new Business.material();
            Business.materialData materialdata = new Business.materialData();

            materialdata.materialtype = Request.QueryString["type"];
            materialdata.materialtit = materialtit.Text;
            materialdata.materialfile = Business.users.file;
            materialdata.materialtime = DateTime.Now.ToString();


            if (Request.QueryString["id"] != null)
            {
                materialdata.Id = Request.QueryString["id"];
                material.Modify(materialdata);
            }
            else
            {
                material.Insert(materialdata);
            }
            string urlstr = "materialtb.aspx?type=" + Request.QueryString["type"];
            Response.Redirect(urlstr);

            material = null;
            materialdata = null;
        }
    }
}