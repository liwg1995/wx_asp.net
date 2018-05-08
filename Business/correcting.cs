using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class correctingData
    {
        private string m_Id;
        private string m_hwtit;
        private string m_userid;
        private string m_ctime;
        private string m_ccon;
        private string m_ter;
        private string m_cdate;
        private string m_scores;
        private string m_messages;

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
        public string userid
        {
            get { return this.m_userid; }
            set { this.m_userid = value; }
        }
        public string ctime
        {
            get { return this.m_ctime; }
            set { this.m_ctime = value; }
        }
        public string ccon
        {
            get { return this.m_ccon; }
            set { this.m_ccon = value; }
        }
        public string ter
        {
            get { return this.m_ter; }
            set { this.m_ter = value; }
        }
        public string cdate
        {
            get { return this.m_cdate; }
            set { this.m_cdate = value; }
        }
        public string scores
        {
            get { return this.m_scores; }
            set { this.m_scores = value; }
        }
        public string messages
        {
            get { return this.m_messages; }
            set { this.m_messages = value; }
        }
    }
    public class correcting
    {
        public bool Insert(correctingData datcorrecting)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into correcting (hwtit,userid,ctime,ccon,ter,cdate,scores,messages)  values (@hwtit,@userid,@ctime,@ccon,@ter,@cdate,@scores,@messages) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@hwtit", datcorrecting.hwtit);
                objDB.Command.Parameters.AddWithValue("@userid", datcorrecting.userid);
                objDB.Command.Parameters.AddWithValue("@ctime", datcorrecting.ctime);
                objDB.Command.Parameters.AddWithValue("@ccon", datcorrecting.ccon);
                objDB.Command.Parameters.AddWithValue("@ter", datcorrecting.ter);
                objDB.Command.Parameters.AddWithValue("@cdate", datcorrecting.cdate);
                objDB.Command.Parameters.AddWithValue("@scores", datcorrecting.scores);
                objDB.Command.Parameters.AddWithValue("@messages", datcorrecting.messages);
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
        public bool Modify(correctingData datcorrecting)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update correcting set hwtit=@hwtit,userid=@userid,ctime=@ctime,ccon=@ccon,ter=@ter,cdate=@cdate,scores=@scores,messages=@messages where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@hwtit", datcorrecting.hwtit);
                objDB.Command.Parameters.AddWithValue("@userid", datcorrecting.userid);
                objDB.Command.Parameters.AddWithValue("@ctime", datcorrecting.ctime);
                objDB.Command.Parameters.AddWithValue("@ccon", datcorrecting.ccon);
                objDB.Command.Parameters.AddWithValue("@ter", datcorrecting.ter);
                objDB.Command.Parameters.AddWithValue("@cdate", datcorrecting.cdate);
                objDB.Command.Parameters.AddWithValue("@scores", datcorrecting.scores);
                objDB.Command.Parameters.AddWithValue("@messages", datcorrecting.messages);
                objDB.Command.Parameters.AddWithValue("@Id", datcorrecting.Id);
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
                string strSql = "delete from correcting where Id=" + Id + "";
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

        public bool Update(string Id, string scores, string messages)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update correcting set scores='" + scores + "',messages='" + messages + "' where Id=" + Id + "";
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

        public correctingData[] Select(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            correctingData[] datcorrecting = new correctingData[1];
            string sql = "select * from correcting where Id= " + Id + " ";
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datcorrecting = new correctingData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datcorrecting[i] = new correctingData();
                            datcorrecting[i].hwtit = ds.Tables[0].Rows[i]["hwtit"].ToString();
                            datcorrecting[i].userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datcorrecting[i].ctime = ds.Tables[0].Rows[i]["ctime"].ToString();
                            datcorrecting[i].ccon = ds.Tables[0].Rows[i]["ccon"].ToString();
                            datcorrecting[i].ter = ds.Tables[0].Rows[i]["ter"].ToString();
                            datcorrecting[i].cdate = ds.Tables[0].Rows[i]["cdate"].ToString();
                            datcorrecting[i].scores = ds.Tables[0].Rows[i]["scores"].ToString();
                            datcorrecting[i].messages = ds.Tables[0].Rows[i]["messages"].ToString();
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
            return datcorrecting;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from correcting where 1 = 1 ";
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
            string sql = "select count (1)  from correctingwhere id > 0";
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
                sql = "select top " + pagesize + " * from correcting where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from correcting where id not in (select top " + (pageindex - 1) * pagesize + " id from correcting order by id desc) " + casestr + " order by id desc";
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
