using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class menulevel2Data
    {
        private string m_Id;
        private string m_level1id;
        private string m_menutype;
        private string m_menuname;
        private string m_menuurl;
        private string m_nums;

        public string Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        public string level1id
        {
            get { return this.m_level1id; }
            set { this.m_level1id = value; }
        }
        public string menutype
        {
            get { return this.m_menutype; }
            set { this.m_menutype = value; }
        }
        public string menuname
        {
            get { return this.m_menuname; }
            set { this.m_menuname = value; }
        }
        public string menuurl
        {
            get { return this.m_menuurl; }
            set { this.m_menuurl = value; }
        }
        public string nums
        {
            get { return this.m_nums; }
            set { this.m_nums = value; }
        }
    }
    public class menulevel2
    {
        public bool Insert(menulevel2Data datmenulevel2)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into menulevel2 (level1id,menutype,menuname,menuurl,nums)  values (@level1id,@menutype,@menuname,@menuurl,@nums) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@level1id", datmenulevel2.level1id);
                objDB.Command.Parameters.AddWithValue("@menutype", datmenulevel2.menutype);
                objDB.Command.Parameters.AddWithValue("@menuname", datmenulevel2.menuname);
                objDB.Command.Parameters.AddWithValue("@menuurl", datmenulevel2.menuurl);
                objDB.Command.Parameters.AddWithValue("@nums", datmenulevel2.nums);
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
        public bool Modify(menulevel2Data datmenulevel2)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update menulevel2 set level1id=@level1id,menutype=@menutype,menuname=@menuname,menuurl=@menuurl,nums=@nums where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@level1id", datmenulevel2.level1id);
                objDB.Command.Parameters.AddWithValue("@menutype", datmenulevel2.menutype);
                objDB.Command.Parameters.AddWithValue("@menuname", datmenulevel2.menuname);
                objDB.Command.Parameters.AddWithValue("@menuurl", datmenulevel2.menuurl);
                objDB.Command.Parameters.AddWithValue("@nums", datmenulevel2.nums);
                objDB.Command.Parameters.AddWithValue("@Id", datmenulevel2.Id);
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
                string strSql = "delete from menulevel2 where Id=" + Id + "";
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

        public menulevel2Data[] Select(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            menulevel2Data[] datmenulevel2 = new menulevel2Data[1];
            string sql = "select * from menulevel2 where Id= " + Id + " ";
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datmenulevel2 = new menulevel2Data[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datmenulevel2[i] = new menulevel2Data();
                            datmenulevel2[i].level1id = ds.Tables[0].Rows[i]["level1id"].ToString();
                            datmenulevel2[i].menutype = ds.Tables[0].Rows[i]["menutype"].ToString();
                            datmenulevel2[i].menuname = ds.Tables[0].Rows[i]["menuname"].ToString();
                            datmenulevel2[i].menuurl = ds.Tables[0].Rows[i]["menuurl"].ToString();
                            datmenulevel2[i].nums = ds.Tables[0].Rows[i]["nums"].ToString();
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
            return datmenulevel2;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from menulevel2 where 1 = 1 ";
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
            string sql = "select count (1)  from menulevel2where id > 0";
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
                sql = "select top " + pagesize + " * from menulevel2 where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from menulevel2 where id not in (select top " + (pageindex - 1) * pagesize + " id from menulevel2 order by id desc) " + casestr + " order by id desc";
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
