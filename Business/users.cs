using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class usersData
    {
        private string m_Id;
        private string m_userid;
        private string m_userpwrd;
        private string m_username;
        private string m_usertype;
        private string m_userclass;

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
        public string userpwrd
        {
            get { return this.m_userpwrd; }
            set { this.m_userpwrd = value; }
        }
        public string username
        {
            get { return this.m_username; }
            set { this.m_username = value; }
        }
        public string usertype
        {
            get { return this.m_usertype; }
            set { this.m_usertype = value; }
        }
        public string userclass
        {
            get { return this.m_userclass; }
            set { this.m_userclass = value; }
        }
    }
    public class users
    {
        public static string file = "";
        private string m_UserType;
        private string m_ErrMsg;
        private string m_UserName;
        private string m_UserClass;
        public static string pic = "";

        public string UserType
        {
            get { return this.m_UserType; }
            set { this.m_UserType = value; }
        }
        public string ErrMsg
        {
            get { return this.m_ErrMsg; }
            set { this.m_ErrMsg = value; }
        }
        public string UserName
        {
            get { return this.m_UserName; }
            set { this.m_UserName = value; }
        }
        public string UserClass
        {
            get { return this.m_UserClass; }
            set { this.m_UserClass = value; }
        }

        public bool Login(string userid, string userpwrd)
        {
            bool flag = false;
            string strSql = "SELECT * FROM Users WHERE (userid = '" + userid + "')";
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            DataTable dt = objDB.QueryDataTable(strSql, "Users");
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow tempRow in dt.Rows)
                {
                    if (tempRow["userpwrd"].ToString().Trim().Equals(userpwrd))
                    {
                        this.UserType = tempRow["UserType"].ToString().Trim();
                        this.UserName = tempRow["UserName"].ToString().Trim();
                        this.UserClass = tempRow["UserClass"].ToString().Trim();

                        flag = true;
                    }
                    else
                    {
                        this.ErrMsg = "密码不正确。";
                    }
                }
            }
            else
            {
                this.ErrMsg = "用户名不存在。";
            }
            dt = null;
            return flag;
        }
        public bool Insert(usersData datusers)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into users (userid,userpwrd,username,usertype,userclass)  values (@userid,@userpwrd,@username,@usertype,@userclass) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@userid", datusers.userid);
                objDB.Command.Parameters.AddWithValue("@userpwrd", datusers.userpwrd);
                objDB.Command.Parameters.AddWithValue("@username", datusers.username);
                objDB.Command.Parameters.AddWithValue("@usertype", datusers.usertype);
                objDB.Command.Parameters.AddWithValue("@userclass", datusers.userclass);
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
        public bool Modify(usersData datusers)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update users set userid=@userid,userpwrd=@userpwrd,username=@username,usertype=@usertype,userclass=@userclass where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@userid", datusers.userid);
                objDB.Command.Parameters.AddWithValue("@userpwrd", datusers.userpwrd);
                objDB.Command.Parameters.AddWithValue("@username", datusers.username);
                objDB.Command.Parameters.AddWithValue("@usertype", datusers.usertype);
                objDB.Command.Parameters.AddWithValue("@userclass", datusers.userclass);
                objDB.Command.Parameters.AddWithValue("@Id", datusers.Id);
                iRel = objDB.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { iRel = -1; }
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            bRel = (iRel.Equals(1) ? true : false); return bRel;
        }

        public bool Update(string userid, string userpwrd)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update users set userpwrd ='" + userpwrd + "' where userid='" + userid + "'";
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
                string strSql = "delete from users where Id=" + Id + "";
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

        public usersData[] Select(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            usersData[] datusers = new usersData[1];
            string sql = "select * from users where Id= " + Id + " ";
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datusers = new usersData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datusers[i] = new usersData();
                            datusers[i].userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datusers[i].userpwrd = ds.Tables[0].Rows[i]["userpwrd"].ToString();
                            datusers[i].username = ds.Tables[0].Rows[i]["username"].ToString();
                            datusers[i].usertype = ds.Tables[0].Rows[i]["usertype"].ToString();
                            datusers[i].userclass = ds.Tables[0].Rows[i]["userclass"].ToString();
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
            return datusers;
        }

        public usersData[] Put(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            usersData[] datusers = new usersData[1];
            string sql = "select * from users where 1 = 1 ";
            sql += Id;
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datusers = new usersData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datusers[i] = new usersData();
                            datusers[i].userid = ds.Tables[0].Rows[i]["userid"].ToString();
                            datusers[i].userpwrd = ds.Tables[0].Rows[i]["userpwrd"].ToString();
                            datusers[i].username = ds.Tables[0].Rows[i]["username"].ToString();
                            datusers[i].usertype = ds.Tables[0].Rows[i]["usertype"].ToString();
                            datusers[i].userclass = ds.Tables[0].Rows[i]["userclass"].ToString();
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
            return datusers;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from users where 1 = 1 ";
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
            string sql = "select count (1)  from userswhere id > 0";
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
                sql = "select top " + pagesize + " * from users where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from users where id not in (select top " + (pageindex - 1) * pagesize + " id from users order by id desc) " + casestr + " order by id desc";
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
