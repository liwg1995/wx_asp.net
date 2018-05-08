using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class materialData
    {
        private string m_Id;
        private string m_materialtype;
        private string m_materialtit;
        private string m_materialfile;
        private string m_materialtime;

        public string Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        public string materialtype
        {
            get { return this.m_materialtype; }
            set { this.m_materialtype = value; }
        }
        public string materialtit
        {
            get { return this.m_materialtit; }
            set { this.m_materialtit = value; }
        }
        public string materialfile
        {
            get { return this.m_materialfile; }
            set { this.m_materialfile = value; }
        }
        public string materialtime
        {
            get { return this.m_materialtime; }
            set { this.m_materialtime = value; }
        }
    }
    public class material
    {
        public bool Insert(materialData datmaterial)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into material (materialtype,materialtit,materialfile,materialtime)  values (@materialtype,@materialtit,@materialfile,@materialtime) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@materialtype", datmaterial.materialtype);
                objDB.Command.Parameters.AddWithValue("@materialtit", datmaterial.materialtit);
                objDB.Command.Parameters.AddWithValue("@materialfile", datmaterial.materialfile);
                objDB.Command.Parameters.AddWithValue("@materialtime", datmaterial.materialtime);
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
        public bool Modify(materialData datmaterial)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update material set materialtype=@materialtype,materialtit=@materialtit,materialfile=@materialfile,materialtime=@materialtime where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@materialtype", datmaterial.materialtype);
                objDB.Command.Parameters.AddWithValue("@materialtit", datmaterial.materialtit);
                objDB.Command.Parameters.AddWithValue("@materialfile", datmaterial.materialfile);
                objDB.Command.Parameters.AddWithValue("@materialtime", datmaterial.materialtime);
                objDB.Command.Parameters.AddWithValue("@Id", datmaterial.Id);
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
                string strSql = "delete from material where Id=" + Id + "";
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

        public materialData[] Select(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            materialData[] datmaterial = new materialData[1];
            string sql = "select * from material where Id= " + Id + " ";
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datmaterial = new materialData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datmaterial[i] = new materialData();
                            datmaterial[i].materialtype = ds.Tables[0].Rows[i]["materialtype"].ToString();
                            datmaterial[i].materialtit = ds.Tables[0].Rows[i]["materialtit"].ToString();
                            datmaterial[i].materialfile = ds.Tables[0].Rows[i]["materialfile"].ToString();
                            datmaterial[i].materialtime = ds.Tables[0].Rows[i]["materialtime"].ToString();
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
            return datmaterial;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from material where 1 = 1 ";
            sql += casestr;
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return dt;
        }

        public List<materialData> GetList(string casestr)
        {
            List<materialData> listdata = new List<materialData>();
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from material where 1 = 1 ";
            sql += casestr;
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow tempRow in dt.Rows)
                {
                    materialData hd = new materialData();
                    hd.Id = tempRow["Id"].ToString().Trim();
                    hd.materialtit = tempRow["materialtit"].ToString().Trim();
                    listdata.Add(hd);
                }
            }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return listdata;
        }

        public int CalcCountSearch(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select count (1)  from materialwhere id > 0";
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
                sql = "select top " + pagesize + " * from material where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from material where id not in (select top " + (pageindex - 1) * pagesize + " id from material order by id desc) " + casestr + " order by id desc";
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
