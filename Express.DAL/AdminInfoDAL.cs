using System;
using System.Data;
using System.Data.SqlClient;
using Express.Model;

namespace Express.DAL
{
    public class AdminInfoDAL
    {
        // 查全部 + 模糊查询
        public DataTable GetAll(string keyword)
        {
            string sql = "SELECT * FROM AdminInfo WHERE 1=1";
            SqlParameter[] paras = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += " AND (RealName LIKE @key OR AdminName LIKE @key OR Phone LIKE @key)";
                paras = new SqlParameter[] { new SqlParameter("@key", "%" + keyword + "%") };
            }
            return DBHelper.ExecuteQuery(sql, paras);
        }

        // 根据账号密码查（登录用）
        public DataTable GetByLogin(string adminName, string pwd)
        {
            string sql = "SELECT * FROM AdminInfo WHERE AdminName=@u AND Pwd=@p";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@u", adminName),
                new SqlParameter("@p", pwd)
            };
            return DBHelper.ExecuteQuery(sql, paras);
        }

        // 新增
        public bool Add(AdminInfo a)
        {
            string sql = @"INSERT INTO AdminInfo(AdminName,Pwd,RealName,Phone)
                            VALUES(@u,@p,@n,@ph)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@u", a.AdminName),
                new SqlParameter("@p", a.Pwd),
                new SqlParameter("@n", a.RealName),
                new SqlParameter("@ph", a.Phone)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        // 修改
        public bool Update(AdminInfo a)
        {
            string sql = @"UPDATE AdminInfo SET RealName=@n,Phone=@ph WHERE AdminId=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@n", a.RealName),
                new SqlParameter("@ph", a.Phone),
                new SqlParameter("@id", a.AdminId)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        // 删除
        public bool Delete(int adminId)
        {
            string sql = "DELETE FROM AdminInfo WHERE AdminId=@id";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@id", adminId) };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        // 重置密码
        public bool ResetPwd(int adminId, string newPwd)
        {
            string sql = "UPDATE AdminInfo SET Pwd=@p WHERE AdminId=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@p", newPwd),
                new SqlParameter("@id", adminId)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }
    }
}
