using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class messgaeData
    {
        private string m_Id;
        private string m_messtit;
        private string m_messtime;
        private string m_messcon;

        public string Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        public string messtit
        {
            get { return this.m_messtit; }
            set { this.m_messtit = value; }
        }
        public string messtime
        {
            get { return this.m_messtime; }
            set { this.m_messtime = value; }
        }
        public string messcon
        {
            get { return this.m_messcon; }
            set { this.m_messcon = value; }
        }
    }
    public class messgae
    {
        public bool Insert(messgaeData datmessgae)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into messgae (messtit,messtime,messcon)  values (@messtit,@messtime,@messcon) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@messtit", datmessgae.messtit);
                objDB.Command.Parameters.AddWithValue("@messtime", datmessgae.messtime);
                objDB.Command.Parameters.AddWithValue("@messcon", datmessgae.messcon);
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
        public bool Modify(messgaeData datmessgae)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update messgae set messtit=@messtit,messtime=@messtime,messcon=@messcon where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@messtit", datmessgae.messtit);
                objDB.Command.Parameters.AddWithValue("@messtime", datmessgae.messtime);
                objDB.Command.Parameters.AddWithValue("@messcon", datmessgae.messcon);
                objDB.Command.Parameters.AddWithValue("@Id", datmessgae.Id);
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
                string strSql = "delete from messgae where Id=" + Id + "";
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

        public messgaeData[] Select(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            messgaeData[] datmessgae = new messgaeData[1];
            string sql = "select * from messgae where Id= " + Id + " ";
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datmessgae = new messgaeData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datmessgae[i] = new messgaeData();
                            datmessgae[i].messtit = ds.Tables[0].Rows[i]["messtit"].ToString();
                            datmessgae[i].messtime = ds.Tables[0].Rows[i]["messtime"].ToString();
                            datmessgae[i].messcon = ds.Tables[0].Rows[i]["messcon"].ToString();
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
            return datmessgae;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from messgae where 1 = 1 ";
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
            string sql = "select count (1)  from messgaewhere id > 0";
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
                sql = "select top " + pagesize + " * from messgae where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from messgae where id not in (select top " + (pageindex - 1) * pagesize + " id from messgae order by id desc) " + casestr + " order by id desc";
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
