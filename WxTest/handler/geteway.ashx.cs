using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WxApi;
using WxApi.SendEntity;
using WxApi.UserManager;

namespace WxTest.handler
{
    /// <summary>
    /// geteway 的摘要说明
    /// </summary>
    public class geteway : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";


            string pAction = context.Request.Form["pAction"].ToString();

            //json解析
            //System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            //var s = js.Deserialize<System.Collections.Generic.List<Item>>(context.Request.Form["pRequest"].ToString());


            switch (pAction)
            {
                case "sendtext": //文本
                    sendtext(context.Request.Form["text"].ToString(), context.Request.Form["openid"].ToString());
                    context.Response.Write("success");
                    break;
                case "sendarticle": //图文
                    sendarticle(context.Request.Form["text"].ToString(), context.Request.Form["openid"].ToString());
                    context.Response.Write("success");
                    break;
                case "sendmaterial": //音频 视频 图片
                    sendmaterial(context.Request.Form["text"].ToString(), context.Request.Form["openid"].ToString());
                    context.Response.Write("success");
                    break;
                default:
                    context.Response.Write(string.Format("找不到名为：{0}的action处理方法.", pAction));
                    break;

            }
        }

        public class Item
        {
            public int key
            {
                get;
                set;
            }
            public int values
            {
                get;
                set;
            }
        }

        public void sendtext(string text, string openid)
        {
            string[] str = openid.Split('|');
            var ss = GroupSend.SendTextByOpenID(text, AccessTokenBox.GetTokenValue(), str);
        }

        public void sendarticle(string text, string openid)
        {
            string[] str = openid.Split('|');
            Business.article article = new Business.article();
            Business.articleData[] articledata = article.Select(text);
            string imgfile = "../uploads/" + articledata[0].thumb_media_id;
            var img = MaterialLib.Add(HttpContext.Current.Server.MapPath(imgfile), AccessTokenBox.GetTokenValue(), MaterialType.image);
            var ret = GroupSend.UpLoadNew(new List<Article> {
                new Article
                {
                title =articledata[0].title,
                author=articledata[0].author,
                content=articledata[0].content,
                content_source_url="https://www.baidu.com/",
                digest=articledata[0].digest,
                show_cover_pic=1,
                thumb_media_id=img.media_id
                }
            }, AccessTokenBox.GetTokenValue());

            var ss = WxApi.GroupSend.SendArticleByOpenID(ret.media_id, AccessTokenBox.GetTokenValue(), str);
        }

        public void sendmaterial(string text, string openid)
        {
            string[] str = openid.Split('|');
            Business.material material = new Business.material();
            Business.materialData[] materialdata = material.Select(text);
            string imgfile = "../uploads/" + materialdata[0].materialfile;


            switch (materialdata[0].materialtype)
            {
                case ("1"):
                    var voice = MaterialLib.Add(HttpContext.Current.Server.MapPath(imgfile), AccessTokenBox.GetTokenValue(), MaterialType.voice);
                    var voiceret = GroupSend.SendVoiceByOpenID(voice.media_id, AccessTokenBox.GetTokenValue(), str);
                    break;
                case ("2"):
                    var image = MaterialLib.Add(HttpContext.Current.Server.MapPath(imgfile), AccessTokenBox.GetTokenValue(), MaterialType.image);
                    var imageret = GroupSend.SendImgByOpenID(image.media_id, AccessTokenBox.GetTokenValue(), str);
                    break;
                case ("3"):
                    var video = MaterialLib.Add(HttpContext.Current.Server.MapPath(imgfile), AccessTokenBox.GetTokenValue(), MaterialType.video);
                    var videoret = GroupSend.SendVideoByOpenID(video.media_id, AccessTokenBox.GetTokenValue(), str);
                    break;
                default: break;
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}