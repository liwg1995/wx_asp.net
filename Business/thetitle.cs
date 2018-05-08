using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class thetitleData
    {
        private string m_Id;
        private string m_hwid;
        private string m_thetitle;
        private string m_memos;

        public string Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        public string hwid
        {
            get { return this.m_hwid; }
            set { this.m_hwid = value; }
        }
        public string thetitle
        {
            get { return this.m_thetitle; }
            set { this.m_thetitle = value; }
        }
        public string memos
        {
            get { return this.m_memos; }
            set { this.m_memos = value; }
        }
    }
    public class thetitle
    {
        public bool Insert(thetitleData datthetitle)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into thetitle (hwid,thetitle,memos)  values (@hwid,@thetitle,@memos) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@hwid", datthetitle.hwid);
                objDB.Command.Parameters.AddWithValue("@thetitle", datthetitle.thetitle);
                objDB.Command.Parameters.AddWithValue("@memos", datthetitle.memos);
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
        public bool Modify(thetitleData datthetitle)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update thetitle set hwid=@hwid,thetitle=@thetitle,memos=@memos where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@hwid", datthetitle.hwid);
                objDB.Command.Parameters.AddWithValue("@thetitle", datthetitle.thetitle);
                objDB.Command.Parameters.AddWithValue("@memos", datthetitle.memos);
                objDB.Command.Parameters.AddWithValue("@Id", datthetitle.Id);
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
                string strSql = "delete from thetitle where Id=" + Id + "";
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

        public thetitleData[] Select(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            thetitleData[] datthetitle = new thetitleData[1];
            string sql = "select * from thetitle where Id= " + Id + " ";
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datthetitle = new thetitleData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datthetitle[i] = new thetitleData();
                            datthetitle[i].hwid = ds.Tables[0].Rows[i]["hwid"].ToString();
                            datthetitle[i].thetitle = ds.Tables[0].Rows[i]["thetitle"].ToString();
                            datthetitle[i].memos = ds.Tables[0].Rows[i]["memos"].ToString();
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
            return datthetitle;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from thetitle where 1 = 1 ";
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
            string sql = "select count (1)  from thetitlewhere id > 0";
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
                sql = "select top " + pagesize + " * from thetitle where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from thetitle where id not in (select top " + (pageindex - 1) * pagesize + " id from thetitle order by id desc) " + casestr + " order by id desc";
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
