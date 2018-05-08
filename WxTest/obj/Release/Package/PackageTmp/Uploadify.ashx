<%@ WebHandler Language="C#" Class="Uploadify" %>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.Security;
using System.Configuration;


public class Uploadify : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {


        context.Response.ContentType = "text/plain";
        context.Response.Charset = "utf-8";

        HttpPostedFile file = context.Request.Files["Filedata"];
        string uploadPath = HttpContext.Current.Server.MapPath(@context.Request["folder"]) + "\\";

        if (file != null)
        {
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }
            file.SaveAs(uploadPath + file.FileName);
            //下面这句代码缺少的话，上传成功后上传队列的显示不会自动消失
            context.Response.Write("上传成功!");
            //这边调用一个函数,只需要将文件的实际地址传进去就可以了
            Business.users.file = file.FileName;
            //Business.JY.JYPicUrl = file.FileName;
        }
        else
        {
            context.Response.Write("0");
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

