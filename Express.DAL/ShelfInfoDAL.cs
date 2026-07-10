using System.Data;
using System.Data.SqlClient;
using Express.Model;

namespace Express.DAL
{
    public class ShelfInfoDAL
    {
        public DataTable GetAll(string keyword)
        {
            string sql = "SELECT * FROM ShelfInfo WHERE 1=1";
            SqlParameter[] paras = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += " AND ShelfName LIKE @key";
                paras = new SqlParameter[] { new SqlParameter("@key", "%" + keyword + "%") };
            }
            return DBHelper.ExecuteQuery(sql, paras);
        }

        public bool Add(ShelfInfo sh)
        {
            string sql = "INSERT INTO ShelfInfo(ShelfName,LayerCount,MaxCapacity,RemainSpace,Remark) VALUES(@n,@l,@m,@r,@rm)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@n", sh.ShelfName),
                new SqlParameter("@l", sh.LayerCount),
                new SqlParameter("@m", sh.MaxCapacity),
                new SqlParameter("@r", sh.RemainSpace),
                new SqlParameter("@rm", sh.Remark)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        public bool Update(ShelfInfo sh)
        {
            string sql = "UPDATE ShelfInfo SET ShelfName=@n,LayerCount=@l,MaxCapacity=@m,RemainSpace=@r,Remark=@rm WHERE ShelfId=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@n", sh.ShelfName),
                new SqlParameter("@l", sh.LayerCount),
                new SqlParameter("@m", sh.MaxCapacity),
                new SqlParameter("@r", sh.RemainSpace),
                new SqlParameter("@rm", sh.Remark),
                new SqlParameter("@id", sh.ShelfId)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        public bool Delete(int shelfId)
        {
            string sql = "DELETE FROM ShelfInfo WHERE ShelfId=@id";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@id", shelfId) };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }
        public bool IncreaseRemainSpace(int shelfId)
        {
            string sql = "UPDATE ShelfInfo SET RemainSpace = RemainSpace + 1 WHERE ShelfId=@id";
            return DBHelper.ExecuteNonQuery(sql, new SqlParameter("@id", shelfId)) > 0;
        }
    }
}
