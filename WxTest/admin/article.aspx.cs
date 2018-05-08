using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class article : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.article article = new Business.article();
                    Business.articleData[] articledata = article.Select(Request.QueryString["id"]);

                    Business.users.file = articledata[0].thumb_media_id;
                    author.Text = articledata[0].author;
                    title.Text = articledata[0].title;
                    //content_source_url.Text = articledata[0].content_source_url;
                    txtcontent.Text = articledata[0].content;
                    digest.Text = articledata[0].digest;
                    //show_cover_pic.Text = articledata[0].show_cover_pic;


                    article = null;
                    articledata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.article article = new Business.article();
            Business.articleData articledata = new Business.articleData();

            articledata.thumb_media_id = Business.users.file;
            articledata.author = author.Text;
            articledata.title = title.Text;
            articledata.content_source_url = "";
            articledata.content = txtcontent.Text;
            articledata.digest = digest.Text;
            articledata.show_cover_pic = "";


            if (Request.QueryString["id"] != null)
            {
                articledata.Id = Request.QueryString["id"];
                article.Modify(articledata);
            }
            else
            {
                article.Insert(articledata);
            }

            Response.Redirect("articletb.aspx");

            article = null;
            articledata = null;
        }
    }
}