using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class themessData
    {
        private string m_Id;
        private string m_userid;
        private string m_messtime;
        private string m_messcon;
        private string m_ter;
        private string m_replys;

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
        public string ter
        {
            get { return this.m_ter; }
            set { this.m_ter = value; }
        }
        public string replys
        {
            get { return this.m_replys; }
            set { this.m_replys = value; }
        }
    }
    public class themess
    {
        public bool Insert(themessData datthemess)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into themess (userid,messtime,messcon,ter,replys)  values (@userid,@messtime,@messcon,@ter,@replys) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@userid", datthemess.userid);
                objDB.Command.Parameters.AddWithValue("@messtime", datthemess.messtime);
                objDB.Command.Parameters.AddWithValue("@messcon", datthemess.messcon);
                objDB.Command.Parameters.AddWithValue("@ter", datthemess.ter);
                objDB.Command.Parameters.AddWithValue("@replys", datthemess.replys);
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
        public bool Modify(themessData datthemess)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update themess set userid=@userid,messtime=@messtime,messcon=@messcon,ter=@ter,replys=@replys where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@userid", datthemess.userid);
                objDB.Command.Parameters.AddWithValue("@messtime", datthemess.messtime);
                objDB.Command.Parameters.AddWithValue("@messcon", datthemess.messcon);
                objDB.Command.Parameters.AddWithValue("@ter", datthemess.ter);
                objDB.Command.Parameters.AddWithValue("@replys", datthemess.replys);
                objDB.Command.Parameters.AddWithValue("@Id", datthemess.Id);
                iRel = objDB.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { iRel = -1; }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            bRel = (iRel.Equals(1) ? true : false); return bRel;
        }

        public bool Update(string Id, string replys)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update themess set replys='" + replys + "' where Id=" + Id + "";
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
        public bool Delete(string Id)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "delete from themess where Id=" + Id + "";
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

        public themessData[] Select(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            themessData[] datthemess = new themessData[1];
            string sql = "select * from themess where Id= " + Id + " ";
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datthemess = new themessData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datthemess[i] = new themessData();
                            datthemess[i].userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datthemess[i].messtime = ds.Tables[0].Rows[i]["messtime"].ToString();
                            datthemess[i].messcon = ds.Tables[0].Rows[i]["messcon"].ToString();
                            datthemess[i].ter = ds.Tables[0].Rows[i]["ter"].ToString();
                            datthemess[i].replys = ds.Tables[0].Rows[i]["replys"].ToString();
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
            return datthemess;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from themess where 1 = 1 ";
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
            string sql = "select count (1)  from themesswhere id > 0";
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
                sql = "select top " + pagesize + " * from themess where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from themess where id not in (select top " + (pageindex - 1) * pagesize + " id from themess order by id desc) " + casestr + " order by id desc";
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
