using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Data;

namespace Business
{
    public class getbutton
    {
        public List<memu> button { get; set; }
    }

    public class memu
    {
        public string name { get; set; }
        public List<sub_button> sub_button { get; set; }
    }

    public class sub_button
    {
        public string type { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class createmenu
    {
        public string getmenu()
        {
            List<memu> menu_list = new List<memu>();
            DataTable dt = new DataTable();
            DataTable dtlevel2 = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from menulevel1 order by nums ";

            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            if (dt != null && dt.Rows.Count > 0)
            {
                //现在把所有符合条件的 都放到一个LIST里面 然后在这个LIST里面进行操作
                foreach (DataRow tempRow in dt.Rows)
                {
                    //查找二级菜单
                    List<sub_button> sub_button_list = new List<sub_button>();
                    sql = "select * from menulevel2 where level1id ='" + tempRow["id"].ToString() + "' order by nums ";
                    dtlevel2 = objDB.QueryDataTable(sql, "tabname");
                    if (dtlevel2 != null && dtlevel2.Rows.Count > 0)
                    {
                        foreach (DataRow tempRowlevel2 in dtlevel2.Rows)
                        {
                            sub_button sub_buttondata = new sub_button();
                            sub_buttondata.type = tempRowlevel2["menutype"].ToString().Trim();
                            sub_buttondata.name = tempRowlevel2["menuname"].ToString().Trim();
                            sub_buttondata.url = tempRowlevel2["menuurl"].ToString().Trim();
                            sub_button_list.Add(sub_buttondata);
                        }
                    }
                    memu tmpmemu = new memu();
                    tmpmemu.name = tempRow["menuname"].ToString();
                    tmpmemu.sub_button = sub_button_list;
                    menu_list.Add(tmpmemu);
                }
            }

            dt = null;
            dtlevel2 = null;

            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;


            //建立三级菜单
            //string name = "公告";
            //sub_button btn = new sub_button();
            //btn.type = "1";
            //btn.name = "2";
            //btn.url = "3";

            //sub_button btn1 = new sub_button();
            //btn1.type = "1";
            //btn1.name = "2";
            //btn1.url = "3";

            //List<sub_button> sub_button = new List<sub_button>() { btn, btn1 };

            ////建立二级菜单
            ////建立物件，塞资料
            //memu memu = new memu()
            //{
            //    name = name,
            //    sub_button = sub_button
            //};

            ////建立一级菜单
            //List<memu> memulist = new List<memu>() { memu };

            getbutton getbutton = new getbutton()
            {
                button = menu_list
            };

            //物件序列化
            string strJson = JsonConvert.SerializeObject(getbutton, Formatting.Indented);
            //输出结果
            //Response.Write(strJson);
            return strJson;
        }
    }
}
