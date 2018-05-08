using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxApi;
using WxApi.SendEntity;
using WxApi.UserManager;

namespace WxTest
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            //var a = MaterialLib.Add(MapPath("0.jpg"), accessToken, MaterialType.image);
            //var ss = CustomerServices.KfSession("003@jkcy2014618", "oxb7QsvLzXJTK6nBI9A8nz38gWxM", "vip客户，请认真对待。", KfSessionType.create, accessToken);
            //var ret = CustomerServices.SendText("odx9DwhEd_C6ptDGUElEJl90ltXU", "你好啊", accessToken);
            //var arts = new List<CustomArticle>();
            //arts.Add(new CustomArticle
            //{
            //    description = "我的是一个图文消息",
            //    picurl = "http://mmbiz.qpic.cn/mmbiz/1ZibzCT1rHibOY2ELeQs9gUicBAmmugnMdXiapiaHqS0femKqGRj7S1rEy1wWExuEmsZO5uvOawr3vKvuuMboL2Q4Ag/0",
            //    title = "aa",
            //    url = "https://www.baidu.com/"
            //});

            //var accessToken = AccessTokenBox.GetTokenValue("wx3da37e397ad59389", "a3d722a43ce7072c7524846047662da6");
            //CustomArticle ca = new CustomArticle();
            //ca.title = "图文测试";
            //ca.url = "http://mmbiz.qpic.cn/mmbiz/1ZibzCT1rHibOY2ELeQs9gUicBAmmugnMdXiapiaHqS0femKqGRj7S1rEy1wWExuEmsZO5uvOawr3vKvuuMboL2Q4Ag/0";
            //ca.picurl = "https://www.baidu.com/";
            //ca.description = "测试描述";
            //var ret = CustomerServices.SendArticle("odx9DwhEd_C6ptDGUElEJl90ltXU", ca, accessToken);
            ////var ts = CustomerServices.SendArticleNoPic("odx9DwhEd_C6ptDGUElEJl90ltXU", "1", "2", "https://www.baidu.com/", accessToken);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //var accessToken = AccessTokenBox.GetTokenValue("wx3da37e397ad59389", "a3d722a43ce7072c7524846047662da6");
            ////CustomArticle ca = new CustomArticle();
            ////ca.title = "图文测试";
            ////ca.url = "http://mmbiz.qpic.cn/mmbiz/1ZibzCT1rHibOY2ELeQs9gUicBAmmugnMdXiapiaHqS0femKqGRj7S1rEy1wWExuEmsZO5uvOawr3vKvuuMboL2Q4Ag/0";
            ////ca.picurl = "https://www.baidu.com/";
            ////ca.description = "测试描述";
            ////var ret = CustomerServices.SendArticle("odx9DwhEd_C6ptDGUElEJl90ltXU", ca, accessToken);
            //var trr = GroupSend.SendArticleByGroup("78WMNV0pE8VeJGM7Yr1Y2lR-kw8P8sjH6kDKWF6aSdZEnQPTxdE9B3_UK8dlTmIR", accessToken, true, "");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //var accessToken = AccessTokenBox.GetTokenValue("wx3da37e397ad59389", "a3d722a43ce7072c7524846047662da6");
            //var img = MaterialLib.Add(MapPath("wx.jpg"), accessToken, MaterialType.image);
            //var ret = GroupSend.UpLoadNew(new List<Article> {
            //    new Article
            //    {
            //    title ="sads",
            //    author="asd",
            //    content="asd",
            //    content_source_url="https://www.baidu.com/",
            //    digest="asd",
            //    show_cover_pic=1,
            //    thumb_media_id=img.media_id
            //    }
            //}, accessToken);

            //var ss = WxApi.GroupSend.SendArticleByOpenID(ret.media_id, accessToken, "odx9DwhEd_C6ptDGUElEJl90ltXU");
            //var trr = GroupSend.SendArticleByGroup(ret.media_id, accessToken, true, "");

            //var mp3 = MaterialLib.Add(MapPath("ww.mp4"), accessToken, MaterialType.video);
            //var ret = GroupSend.UpLoadVideo(mp3.media_id, "a", "s", accessToken);
            //var trr = GroupSend.SendVideoByOpenID(ret.media_id, accessToken, "odx9DwhEd_C6ptDGUElEJl90ltXU");

            //var ret = BaseUser.GetUserList(accessToken,"");

            //var reet = BaseUser.GetUserInfo(ret.data.openid[0], accessToken);
        }
    }
}