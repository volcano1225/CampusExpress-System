using System.Data;
using System.Data.SqlClient;
using Express.Model;

namespace Express.DAL
{
    public class ExpressCategoryDAL
    {
        public DataTable GetAll(string keyword)
        {
            string sql = "SELECT * FROM ExpressCategory WHERE 1=1";
            SqlParameter[] paras = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += " AND CateName LIKE @key";
                paras = new SqlParameter[] { new SqlParameter("@key", "%" + keyword + "%") };
            }
            return DBHelper.ExecuteQuery(sql, paras);
        }

        public bool Add(ExpressCategory c)
        {
            string sql = "INSERT INTO ExpressCategory(CateName,Remark) VALUES(@n,@r)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@n", c.CateName),
                new SqlParameter("@r", c.Remark)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        public bool Update(ExpressCategory c)
        {
            string sql = "UPDATE ExpressCategory SET CateName=@n,Remark=@r WHERE CateId=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@n", c.CateName),
                new SqlParameter("@r", c.Remark),
                new SqlParameter("@id", c.CateId)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        public bool Delete(int cateId)
        {
            string sql = "DELETE FROM ExpressCategory WHERE CateId=@id";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@id", cateId) };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }
    }
}
