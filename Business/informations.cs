using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class informationsData
    {
        private string m_Id;
        private string m_thetit;
        private string m_thetype;
        private string m_thetime;
        private string m_userid;
        private string m_memos;
        private string m_userclass;

        public string Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        public string thetit
        {
            get { return this.m_thetit; }
            set { this.m_thetit = value; }
        }
        public string thetype
        {
            get { return this.m_thetype; }
            set { this.m_thetype = value; }
        }
        public string thetime
        {
            get { return this.m_thetime; }
            set { this.m_thetime = value; }
        }
        public string userid
        {
            get { return this.m_userid; }
            set { this.m_userid = value; }
        }
        public string memos
        {
            get { return this.m_memos; }
            set { this.m_memos = value; }
        }
        public string userclass
        {
            get { return this.m_userclass; }
            set { this.m_userclass = value; }
        }
    }
    public class informations
    {
        public bool Insert(informationsData datinformations)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into informations (thetit,thetype,thetime,userid,memos,userclass)  values (@thetit,@thetype,@thetime,@userid,@memos,@userclass) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@thetit", datinformations.thetit);
                objDB.Command.Parameters.AddWithValue("@thetype", datinformations.thetype);
                objDB.Command.Parameters.AddWithValue("@thetime", datinformations.thetime);
                objDB.Command.Parameters.AddWithValue("@userid", datinformations.userid);
                objDB.Command.Parameters.AddWithValue("@memos", datinformations.memos);
                objDB.Command.Parameters.AddWithValue("@userclass", datinformations.userclass);
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
        public bool Modify(informationsData datinformations)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update informations set thetit=@thetit,thetype=@thetype,thetime=@thetime,userid=@userid,memos=@memos,userclass=@userclass where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@thetit", datinformations.thetit);
                objDB.Command.Parameters.AddWithValue("@thetype", datinformations.thetype);
                objDB.Command.Parameters.AddWithValue("@thetime", datinformations.thetime);
                objDB.Command.Parameters.AddWithValue("@userid", datinformations.userid);
                objDB.Command.Parameters.AddWithValue("@memos", datinformations.memos);
                objDB.Command.Parameters.AddWithValue("@userclass", datinformations.userclass);
                objDB.Command.Parameters.AddWithValue("@Id", datinformations.Id);
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
                string strSql = "delete from informations where Id=" + Id + "";
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

        public informationsData[] Select(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            informationsData[] datinformations = new informationsData[1];
            string sql = "select * from informations where 1= 1  ";
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
                        datinformations = new informationsData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datinformations[i] = new informationsData();
                            datinformations[i].thetit = ds.Tables[0].Rows[i]["thetit"].ToString();
                            datinformations[i].thetype = ds.Tables[0].Rows[i]["thetype"].ToString();
                            datinformations[i].thetime = ds.Tables[0].Rows[i]["thetime"].ToString();
                            datinformations[i].userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datinformations[i].memos = ds.Tables[0].Rows[i]["memos"].ToString();
                            datinformations[i].userclass = ds.Tables[0].Rows[i]["userclass"].ToString();
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
            return datinformations;
        }
        public informationsData SelectData(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            informationsData datinformations = new informationsData();
            string sql = "select * from informations where 1= 1  ";
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
                            datinformations.thetit = ds.Tables[0].Rows[i]["thetit"].ToString();
                            datinformations.thetype = ds.Tables[0].Rows[i]["thetype"].ToString();
                            datinformations.thetime = ds.Tables[0].Rows[i]["thetime"].ToString();
                            datinformations.userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datinformations.memos = ds.Tables[0].Rows[i]["memos"].ToString();
                            datinformations.userclass = ds.Tables[0].Rows[i]["userclass"].ToString();
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
            return datinformations;
        }
        public informationsData[] Put(string casestr)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            informationsData[] datinformations = new informationsData[1];
            string sql = "select * from informations where 1 = 1 ";
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
                        datinformations = new informationsData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datinformations[i] = new informationsData();
                            datinformations[i].thetit = ds.Tables[0].Rows[i]["thetit"].ToString();
                            datinformations[i].thetype = ds.Tables[0].Rows[i]["thetype"].ToString();
                            datinformations[i].thetime = ds.Tables[0].Rows[i]["thetime"].ToString();
                            datinformations[i].userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datinformations[i].memos = ds.Tables[0].Rows[i]["memos"].ToString();
                            datinformations[i].userclass = ds.Tables[0].Rows[i]["userclass"].ToString();
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
            return datinformations;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from informations where 1 = 1 ";
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
            string sql = "select count (1)  from informations where id > 0";
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
                sql = "select top " + pagesize + " * from informations where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from informations where id not in (select top " + (pageindex - 1) * pagesize + " id from informations order by id desc) " + casestr + " order by id desc";
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
