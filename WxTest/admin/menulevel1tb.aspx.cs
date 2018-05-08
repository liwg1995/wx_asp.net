using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WxTest.admin
{
    public partial class menulevel1tb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Business.menulevel1 menulevel1 = new Business.menulevel1();
                Repeater1.DataSource = menulevel1.Get("");
                Repeater1.DataBind();
                menulevel1 = null;
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Id = e.CommandName;
            Business.menulevel1 menulevel1 = new Business.menulevel1();
            menulevel1.Delete(Id);
            Repeater1.DataSource = menulevel1.Get("");
            Repeater1.DataBind();
            menulevel1 = null;
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            //自定义菜单token的获取 是用 下面的两个参数 获取的 不能直接用 公众平台的token 
            //string to = GetData("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=wx86d0a43958d1f3f0&secret=595a9428931445577959ccf898f6fc16");
            string to = GetData(string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}",
                System.Web.Configuration.WebConfigurationManager.AppSettings["appID"],
                System.Web.Configuration.WebConfigurationManager.AppSettings["appsecret"]));
            //本人不喜欢 后台 json的操作 直接截取就可以了 得到的就是 token 或者 自己 获取 json的token
            to = to.Substring(17, to.Length - 37);
            Business.createmenu createmenu = new Business.createmenu();
            string i = GetPage("https://api.weixin.qq.com/cgi-bin/menu/create?access_token=" + to, createmenu.getmenu());
        }


        private string GetData(string url)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            myRequest.Method = "GET";
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            return content;
        }

        public string GetPage(string posturl, string postData)
        {
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Encoding encoding = Encoding.UTF8;
            byte[] data = encoding.GetBytes(postData);
            // 准备请求...
            try
            {
                // 设置参数
                request = WebRequest.Create(posturl) as HttpWebRequest;
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                outstream = request.GetRequestStream();
                outstream.Write(data, 0, data.Length);
                outstream.Close();
                //发送请求并获取相应回应数据
                response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                instream = response.GetResponseStream();
                sr = new StreamReader(instream, encoding);
                //返回结果网页（html）代码
                string content = sr.ReadToEnd();
                string err = string.Empty;
                return content;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return string.Empty;
            }
        }
    }
}