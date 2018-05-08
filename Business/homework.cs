using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class homeworkData
    {
        private string m_Id;
        private string m_hwtit;
        private string m_hwtime;
        private string m_hwer;
        private string m_press;
        private string m_userclass;

        public string Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        public string hwtit
        {
            get { return this.m_hwtit; }
            set { this.m_hwtit = value; }
        }
        public string hwtime
        {
            get { return this.m_hwtime; }
            set { this.m_hwtime = value; }
        }
        public string hwer
        {
            get { return this.m_hwer; }
            set { this.m_hwer = value; }
        }
        public string press
        {
            get { return this.m_press; }
            set { this.m_press = value; }
        }
        public string userclass
        {
            get { return this.m_userclass; }
            set { this.m_userclass = value; }
        }
    }
    public class homework
    {
        public bool Insert(homeworkData dathomework)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into homework (hwtit,hwtime,hwer,press,userclass)  values (@hwtit,@hwtime,@hwer,@press,@userclass) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@hwtit", dathomework.hwtit);
                objDB.Command.Parameters.AddWithValue("@hwtime", dathomework.hwtime);
                objDB.Command.Parameters.AddWithValue("@hwer", dathomework.hwer);
                objDB.Command.Parameters.AddWithValue("@press", dathomework.press);
                objDB.Command.Parameters.AddWithValue("@userclass", dathomework.userclass);
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
        public bool Modify(homeworkData dathomework)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update homework set hwtit=@hwtit,hwtime=@hwtime,hwer=@hwer,press=@press,userclass=@userclass where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@hwtit", dathomework.hwtit);
                objDB.Command.Parameters.AddWithValue("@hwtime", dathomework.hwtime);
                objDB.Command.Parameters.AddWithValue("@hwer", dathomework.hwer);
                objDB.Command.Parameters.AddWithValue("@press", dathomework.press);
                objDB.Command.Parameters.AddWithValue("@userclass", dathomework.userclass);
                objDB.Command.Parameters.AddWithValue("@Id", dathomework.Id);
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
                string strSql = "delete from homework where Id=" + Id + "";
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

        public homeworkData[] Select(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            homeworkData[] dathomework = new homeworkData[1];
            string sql = "select * from homework where Id= " + Id + " ";
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        dathomework = new homeworkData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            dathomework[i] = new homeworkData();
                            dathomework[i].hwtit = ds.Tables[0].Rows[i]["hwtit"].ToString();
                            dathomework[i].hwtime = ds.Tables[0].Rows[i]["hwtime"].ToString();
                            dathomework[i].hwer = ds.Tables[0].Rows[i]["hwer"].ToString();
                            dathomework[i].press = ds.Tables[0].Rows[i]["press"].ToString();
                            dathomework[i].userclass = ds.Tables[0].Rows[i]["userclass"].ToString();
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
            return dathomework;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from homework where 1 = 1 ";
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
            string sql = "select count (1)  from homeworkwhere id > 0";
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
                sql = "select top " + pagesize + " * from homework where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from homework where id not in (select top " + (pageindex - 1) * pagesize + " id from homework order by id desc) " + casestr + " order by id desc";
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
