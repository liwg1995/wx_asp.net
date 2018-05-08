using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Business
{
    public class articleData
    {
        private string m_Id;
        private string m_thumb_media_id;
        private string m_author;
        private string m_title;
        private string m_content_source_url;
        private string m_content;
        private string m_digest;
        private string m_show_cover_pic;

        public string Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        public string thumb_media_id
        {
            get { return this.m_thumb_media_id; }
            set { this.m_thumb_media_id = value; }
        }
        public string author
        {
            get { return this.m_author; }
            set { this.m_author = value; }
        }
        public string title
        {
            get { return this.m_title; }
            set { this.m_title = value; }
        }
        public string content_source_url
        {
            get { return this.m_content_source_url; }
            set { this.m_content_source_url = value; }
        }
        public string content
        {
            get { return this.m_content; }
            set { this.m_content = value; }
        }
        public string digest
        {
            get { return this.m_digest; }
            set { this.m_digest = value; }
        }
        public string show_cover_pic
        {
            get { return this.m_show_cover_pic; }
            set { this.m_show_cover_pic = value; }
        }
    }
    public class article
    {
        public bool Insert(articleData datarticle)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = " insert into article (thumb_media_id,author,title,content_source_url,content,digest,show_cover_pic)  values (@thumb_media_id,@author,@title,@content_source_url,@content,@digest,@show_cover_pic) ";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@thumb_media_id", datarticle.thumb_media_id);
                objDB.Command.Parameters.AddWithValue("@author", datarticle.author);
                objDB.Command.Parameters.AddWithValue("@title", datarticle.title);
                objDB.Command.Parameters.AddWithValue("@content_source_url", datarticle.content_source_url);
                objDB.Command.Parameters.AddWithValue("@content", datarticle.content);
                objDB.Command.Parameters.AddWithValue("@digest", datarticle.digest);
                objDB.Command.Parameters.AddWithValue("@show_cover_pic", datarticle.show_cover_pic);
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
        public bool Modify(articleData datarticle)
        {
            int iRel = -1;
            bool bRel = false;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            try
            {
                objDB.OpenConnection();
                string strSql = "update article set thumb_media_id=@thumb_media_id,author=@author,title=@title,content_source_url=@content_source_url,content=@content,digest=@digest,show_cover_pic=@show_cover_pic where Id = @Id";
                objDB.Command.CommandType = System.Data.CommandType.Text;
                objDB.Command.CommandText = strSql;
                objDB.Command.Parameters.AddWithValue("@thumb_media_id", datarticle.thumb_media_id);
                objDB.Command.Parameters.AddWithValue("@author", datarticle.author);
                objDB.Command.Parameters.AddWithValue("@title", datarticle.title);
                objDB.Command.Parameters.AddWithValue("@content_source_url", datarticle.content_source_url);
                objDB.Command.Parameters.AddWithValue("@content", datarticle.content);
                objDB.Command.Parameters.AddWithValue("@digest", datarticle.digest);
                objDB.Command.Parameters.AddWithValue("@show_cover_pic", datarticle.show_cover_pic);
                objDB.Command.Parameters.AddWithValue("@Id", datarticle.Id);
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
                string strSql = "delete from article where Id=" + Id + "";
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

        public articleData[] Select(string Id)
        {
            int iRel = -1;
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            articleData[] datarticle = new articleData[1];
            string sql = "select * from article where Id= " + Id + " ";
            try
            {
                objDB.OpenConnection();
                DataSet ds = objDB.QueryData(sql, "departmentinfo");
                if (ds.Tables.Count > 0)
                {
                    long nRow = ds.Tables[0].Rows.Count;
                    if (nRow > 0)
                    {
                        datarticle = new articleData[nRow];
                        for (int i = 0; i < nRow; i++)
                        {
                            datarticle[i] = new articleData();
                            datarticle[i].thumb_media_id = ds.Tables[0].Rows[i]["thumb_media_id"].ToString();
                            datarticle[i].author = ds.Tables[0].Rows[i]["author"].ToString();
                            datarticle[i].title = ds.Tables[0].Rows[i]["title"].ToString();
                            datarticle[i].content_source_url = ds.Tables[0].Rows[i]["content_source_url"].ToString();
                            datarticle[i].content = ds.Tables[0].Rows[i]["content"].ToString();
                            datarticle[i].digest = ds.Tables[0].Rows[i]["digest"].ToString();
                            datarticle[i].show_cover_pic = ds.Tables[0].Rows[i]["show_cover_pic"].ToString();
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
            return datarticle;
        }
        public DataTable Get(string casestr)
        {
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from article where 1 = 1 ";
            sql += casestr;
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");
            objDB.CloseConnection();
            objDB.Dispose();
            objDB = null;
            return dt;
        }

        public List<articleData> GetList(string casestr)
        {
            List<articleData> listdata = new List<articleData>();
            DataTable dt = new DataTable();
            DataAccess.CommonDB objDB = new DataAccess.CommonDB();
            string sql = "select * from article where 1 = 1 ";
            sql += casestr;
            objDB.OpenConnection();
            dt = objDB.QueryDataTable(sql, "tabname");

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow tempRow in dt.Rows)
                {
                    articleData hd = new articleData();
                    hd.Id = tempRow["Id"].ToString().Trim();
                    hd.title = tempRow["title"].ToString().Trim();
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
            string sql = "select count (1)  from articlewhere id > 0";
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
                sql = "select top " + pagesize + " * from article where id > 0 " + casestr + " order by id desc";
            }
            else
            {
                sql = "select top " + pagesize + " * from article where id not in (select top " + (pageindex - 1) * pagesize + " id from article order by id desc) " + casestr + " order by id desc";
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
