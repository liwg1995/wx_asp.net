using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class userinfoData
    {
        private string m_Id;
        private string m_subscribe;
        private string m_openid;
        private string m_nickname;
        private string m_sex;
        private string m_language;
        private string m_city;
        private string m_province;
        private string m_country;
        private string m_headimgurl;
        private string m_subscribe_time;
        private string m_unionid;
        private string m_remark;
        private string m_privilege;

        public string Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        public string subscribe
        {
            get { return this.m_subscribe; }
            set { this.m_subscribe = value; }
        }
        public string openid
        {
            get { return this.m_openid; }
            set { this.m_openid = value; }
        }
        public string nickname
        {
            get { return this.m_nickname; }
            set { this.m_nickname = value; }
        }
        public string sex
        {
            get { return this.m_sex; }
            set { this.m_sex = value; }
        }
        public string language
        {
            get { return this.m_language; }
            set { this.m_language = value; }
        }
        public string city
        {
            get { return this.m_city; }
            set { this.m_city = value; }
        }
        public string province
        {
            get { return this.m_province; }
            set { this.m_province = value; }
        }
        public string country
        {
            get { return this.m_country; }
            set { this.m_country = value; }
        }
        public string headimgurl
        {
            get { return this.m_headimgurl; }
            set { this.m_headimgurl = value; }
        }
        public string subscribe_time
        {
            get { return this.m_subscribe_time; }
            set { this.m_subscribe_time = value; }
        }
        public string unionid
        {
            get { return this.m_unionid; }
            set { this.m_unionid = value; }
        }
        public string remark
        {
            get { return this.m_remark; }
            set { this.m_remark = value; }
        }
        public string privilege
        {
            get { return this.m_privilege; }
            set { this.m_privilege = value; }
        }
    }
    public class userinfo
    {
        public bool Insert(userinfoData datuserinfo)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into userinfo (subscribe,openid,nickname,sex,language,city,province,country,headimgurl,subscribe_time,unionid,remark,privilege)  values (@subscribe,@openid,@nickname,@sex,@language,@city,@province,@country,@headimgurl,@subscribe_time,@unionid,@remark,@privilege) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@subscribe", datuserinfo.subscribe);
                objDB.Command.Parameters.AddWithValue("@openid", datuserinfo.openid);
                objDB.Command.Parameters.AddWithValue("@nickname", datuserinfo.nickname);
                objDB.Command.Parameters.AddWithValue("@sex", datuserinfo.sex);
                objDB.Command.Parameters.AddWithValue("@language", datuserinfo.language);
                objDB.Command.Parameters.AddWithValue("@city", datuserinfo.city);
                objDB.Command.Parameters.AddWithValue("@province", datuserinfo.province);
                objDB.Command.Parameters.AddWithValue("@country", datuserinfo.country);
                objDB.Command.Parameters.AddWithValue("@headimgurl", datuserinfo.headimgurl);
                objDB.Command.Parameters.AddWithValue("@subscribe_time", datuserinfo.subscribe_time);
                objDB.Command.Parameters.AddWithValue("@unionid", datuserinfo.unionid);
                objDB.Command.Parameters.AddWithValue("@remark", datuserinfo.remark);
                objDB.Command.Parameters.AddWithValue("@privilege", datuserinfo.privilege);
                iRel = objDB.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                iRel = -1;
            }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            bRel = (iRel.Equals(1) ? true : false);
            return bRel;
        }
        public bool Modify(userinfoData datuserinfo)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update userinfo set subscribe=@subscribe,openid=@openid,nickname=@nickname,sex=@sex,language=@language,city=@city,province=@province,country=@country,headimgurl=@headimgurl,subscribe_time=@subscribe_time,unionid=@unionid,remark=@remark,privilege=@privilege where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@subscribe", datuserinfo.subscribe);
                objDB.Command.Parameters.AddWithValue("@openid", datuserinfo.openid);
                objDB.Command.Parameters.AddWithValue("@nickname", datuserinfo.nickname);
                objDB.Command.Parameters.AddWithValue("@sex", datuserinfo.sex);
                objDB.Command.Parameters.AddWithValue("@language", datuserinfo.language);
                objDB.Command.Parameters.AddWithValue("@city", datuserinfo.city);
                objDB.Command.Parameters.AddWithValue("@province", datuserinfo.province);
                objDB.Command.Parameters.AddWithValue("@country", datuserinfo.country);
                objDB.Command.Parameters.AddWithValue("@headimgurl", datuserinfo.headimgurl);
                objDB.Command.Parameters.AddWithValue("@subscribe_time", datuserinfo.subscribe_time);
                objDB.Command.Parameters.AddWithValue("@unionid", datuserinfo.unionid);
                objDB.Command.Parameters.AddWithValue("@remark", datuserinfo.remark);
                objDB.Command.Parameters.AddWithValue("@privilege", datuserinfo.privilege);
                objDB.Command.Parameters.AddWithValue("@Id", datuserinfo.Id);
                iRel = objDB.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { iRel = -1; }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            bRel = (iRel.Equals(1) ? true : false); return bRel;
        }
        public bool Delete(string Id)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "delete from userinfo where Id=" + Id + "";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                iRel = objDB.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                iRel = -1;
            }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            bRel = (iRel.Equals(1) ? true : false);
            return bRel;
        }

        public bool DeleteByCase(string strcase)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "delete from userinfo where 1 = 1";
                strSql += strcase;
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                iRel = objDB.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                iRel = -1;
            }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            bRel = (iRel.Equals(1) ? true : false);
            return bRel;
        }

        public userinfoData[] Select(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            userinfoData[] datuserinfo = new userinfoData[1];
            string sql = "select * from userinfo where Id= " + Id + " ";
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datuserinfo = new userinfoData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datuserinfo[i] = new userinfoData();
                            datuserinfo[i].subscribe = ds.Tables[0].Rows[i]["subscribe"].ToString();
                            datuserinfo[i].openid = ds.Tables[0].Rows[i]["openid"].ToString();
                            datuserinfo[i].nickname = ds.Tables[0].Rows[i]["nickname"].ToString();
                            datuserinfo[i].sex = ds.Tables[0].Rows[i]["sex"].ToString();
                            datuserinfo[i].language = ds.Tables[0].Rows[i]["language"].ToString();
                            datuserinfo[i].city = ds.Tables[0].Rows[i]["city"].ToString();
                            datuserinfo[i].province = ds.Tables[0].Rows[i]["province"].ToString();
                            datuserinfo[i].country = ds.Tables[0].Rows[i]["country"].ToString();
                            datuserinfo[i].headimgurl = ds.Tables[0].Rows[i]["headimgurl"].ToString();
                            datuserinfo[i].subscribe_time = ds.Tables[0].Rows[i]["subscribe_time"].ToString();
                            datuserinfo[i].unionid = ds.Tables[0].Rows[i]["unionid"].ToString();
                            datuserinfo[i].remark = ds.Tables[0].Rows[i]["remark"].ToString();
                            datuserinfo[i].privilege = ds.Tables[0].Rows[i]["privilege"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                iRel = -1;
            }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return datuserinfo;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from userinfo where 1 = 1 ";
            sql += casestr;
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return dt;
        }
        public int CalcCountSearch(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select count (1)  from userinfowhere id > 0";
            sql += casestr;
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return (dt == null) ? 0 : int.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable SelectAllFenyeSearch(int pagesize, int pageindex, string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "";
            if ((pageindex - 1) * pagesize == 0)
            {
                sql = "select top " + pagesize + " * from userinfo where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from userinfo where id not in (select top " + (pageindex - 1) * pagesize + " id from userinfo order by id desc) " + casestr + " order by id desc";
            }
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return dt;
        }
    }
}
