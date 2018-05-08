using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class bbsData
    {
        private string m_Id;
        private string m_userid;
        private string m_thetime;
        private string m_memos;

        public string Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        public string userid
        {
            get { return this.m_userid; }
            set { this.m_userid = value; }
        }
        public string thetime
        {
            get { return this.m_thetime; }
            set { this.m_thetime = value; }
        }
        public string memos
        {
            get { return this.m_memos; }
            set { this.m_memos = value; }
        }
    }
    public class bbs
    {
        public bool Insert(bbsData datbbs)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into bbs (userid,thetime,memos)  values (@userid,@thetime,@memos) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@userid", datbbs.userid);
                objDB.Command.Parameters.AddWithValue("@thetime", datbbs.thetime);
                objDB.Command.Parameters.AddWithValue("@memos", datbbs.memos);
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
        public bool Modify(bbsData datbbs)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update bbs set userid=@userid,thetime=@thetime,memos=@memos where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@userid", datbbs.userid);
                objDB.Command.Parameters.AddWithValue("@thetime", datbbs.thetime);
                objDB.Command.Parameters.AddWithValue("@memos", datbbs.memos);
                objDB.Command.Parameters.AddWithValue("@Id", datbbs.Id);
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
                string strSql = "delete from bbs where Id=" + Id + "";
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

        public bbsData[] Select(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            bbsData[] datbbs = new bbsData[1];
            string sql = "select * from bbs where 1= 1  ";
            sql += casestr;
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datbbs = new bbsData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datbbs[i] = new bbsData();
                            datbbs[i].userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datbbs[i].thetime = ds.Tables[0].Rows[i]["thetime"].ToString();
                            datbbs[i].memos = ds.Tables[0].Rows[i]["memos"].ToString();
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
            return datbbs;
        }
        public bbsData SelectData(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            bbsData datbbs = new bbsData();
            string sql = "select * from bbs where 1= 1  ";
            sql += casestr;
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        for (int i = 0; i < nRow; i++)
                        {
                            datbbs.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datbbs.thetime = ds.Tables[0].Rows[i]["thetime"].ToString();
                            datbbs.memos = ds.Tables[0].Rows[i]["memos"].ToString();
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
            return datbbs;
        }
        public bbsData[] Put(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            bbsData[] datbbs = new bbsData[1];
            string sql = "select * from bbs where 1 = 1 ";
            sql += casestr;
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datbbs = new bbsData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datbbs[i] = new bbsData();
                            datbbs[i].userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datbbs[i].thetime = ds.Tables[0].Rows[i]["thetime"].ToString();
                            datbbs[i].memos = ds.Tables[0].Rows[i]["memos"].ToString();
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
            return datbbs;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from bbs where 1 = 1 ";
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
            string sql = "select count (1)  from bbs where id > 0";
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
                sql = "select top " + pagesize + " * from bbs where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from bbs where id not in (select top " + (pageindex - 1) * pagesize + " id from bbs order by id desc) " + casestr + " order by id desc";
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
