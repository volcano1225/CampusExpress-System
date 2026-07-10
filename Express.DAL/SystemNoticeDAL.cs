using System.Data;
using System.Data.SqlClient;
using Express.Model;

namespace Express.DAL
{
    public class SystemNoticeDAL
    {
        public DataTable GetAll(string keyword)
        {
            string sql = "SELECT * FROM SystemNotice WHERE 1=1";
            SqlParameter[] paras = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += " AND Title LIKE @key";
                paras = new SqlParameter[] { new SqlParameter("@key", "%" + keyword + "%") };
            }
            sql += " ORDER BY CreateTime DESC";
            return DBHelper.ExecuteQuery(sql, paras);
        }

        public DataTable GetShowList()
        {
            string sql = "SELECT * FROM SystemNotice WHERE IsShow=1 ORDER BY CreateTime DESC";
            return DBHelper.ExecuteQuery(sql);
        }

        public bool Add(SystemNotice n)
        {
            string sql = "INSERT INTO SystemNotice(Title,Content,CreateAdminId,IsShow) VALUES(@t,@c,@a,@s)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@t", n.Title),
                new SqlParameter("@c", n.Content),
                new SqlParameter("@a", n.CreateAdminId),
                new SqlParameter("@s", n.IsShow)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        public bool Update(SystemNotice n)
        {
            string sql = "UPDATE SystemNotice SET Title=@t,Content=@c,IsShow=@s WHERE NoticeId=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@t", n.Title),
                new SqlParameter("@c", n.Content),
                new SqlParameter("@s", n.IsShow),
                new SqlParameter("@id", n.NoticeId)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        public bool Delete(int noticeId)
        {
            string sql = "DELETE FROM SystemNotice WHERE NoticeId=@id";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@id", noticeId) };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }
    }
}

