using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WxApi.UserManager;

namespace WxTest.admin
{
    public partial class userinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    Business.userinfo userinfo = new Business.userinfo();
                    Business.userinfoData[] userinfodata = userinfo.Select(Request.QueryString["id"]);

                    subscribe.Text = userinfodata[0].subscribe;
                    openid.Text = userinfodata[0].openid;
                    nickname.Text = userinfodata[0].nickname;
                    sex.Text = userinfodata[0].sex;
                    language.Text = userinfodata[0].language;
                    city.Text = userinfodata[0].city;
                    province.Text = userinfodata[0].province;
                    country.Text = userinfodata[0].country;
                    headimgurl.Text = userinfodata[0].headimgurl;
                    subscribe_time.Text = userinfodata[0].subscribe_time;
                    unionid.Text = userinfodata[0].unionid;
                    remark.Text = userinfodata[0].remark;
                    privilege.Text = userinfodata[0].privilege;


                    userinfo = null;
                    userinfodata = null;
                }
            }
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Business.userinfo userinfo = new Business.userinfo();
            Business.userinfoData userinfodata = new Business.userinfoData();

            userinfodata.subscribe = subscribe.Text;
            userinfodata.openid = openid.Text;
            userinfodata.nickname = nickname.Text;
            userinfodata.sex = sex.Text;
            userinfodata.language = language.Text;
            userinfodata.city = city.Text;
            userinfodata.province = province.Text;
            userinfodata.country = country.Text;
            userinfodata.headimgurl = headimgurl.Text;
            userinfodata.subscribe_time = subscribe_time.Text;
            userinfodata.unionid = unionid.Text;
            userinfodata.remark = remark.Text;
            userinfodata.privilege = privilege.Text;


            if (Request.QueryString["id"] != null)
            {
                userinfodata.Id = Request.QueryString["id"];
                userinfo.Modify(userinfodata);
            }
            else
            {
                userinfo.Insert(userinfodata);
            }

            Response.Redirect("userinfotb.aspx");

            userinfo = null;
            userinfodata = null;
        }

        protected void BtnYes_Click(object sender, EventArgs e)
        {
            Business.userinfo userinfo = new Business.userinfo();

            //清除用户列表
            userinfo.DeleteByCase("");

            var accessToken = AccessTokenBox.GetTokenValue();
            //获取用户列表
            var ret = BaseUser.GetUserList(accessToken, "");
            for (int i = 0; i < ret.data.openid.Count; i++)
            {
                var data = BaseUser.GetUserInfo(ret.data.openid[i], accessToken);

                Business.userinfoData userinfodata = new Business.userinfoData();
                userinfodata.subscribe = data.subscribe.ToString();
                userinfodata.openid = data.openid;
                userinfodata.nickname = data.nickname;
                userinfodata.sex = data.sex.ToString() == "1" ? "男" : "女";
                userinfodata.language = data.language;
                userinfodata.city = data.city;
                userinfodata.province = data.province;
                userinfodata.country = data.country;
                userinfodata.headimgurl = data.headimgurl;
                userinfodata.subscribe_time = data.subscribe_time.ToString();
                userinfodata.unionid = data.unionid == null ? "" : data.unionid;
                userinfodata.remark = data.remark;
                if (data.privilege == null)
                {
                    userinfodata.privilege = "";
                }
                else
                {
                    userinfodata.privilege = data.privilege.ToString();
                }
                userinfo.Insert(userinfodata);
            }
            //var reet = BaseUser.GetUserInfo(ret.data.openid[0], accessToken);
        }
    }
}