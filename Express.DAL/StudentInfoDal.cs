using System;
using System.Data;
using System.Data.SqlClient;
using Express.Model;

namespace Express.DAL
{
    public class StudentInfoDAL
    {
        // 查全部 + 模糊查询
        public DataTable GetAll(string keyword)
        {
            string sql = "SELECT * FROM StudentInfo WHERE 1=1";
            SqlParameter[] paras = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += " AND (RealName LIKE @key OR UserName LIKE @key OR Phone LIKE @key)";
                paras = new SqlParameter[] { new SqlParameter("@key", "%" + keyword + "%") };
            }
            return DBHelper.ExecuteQuery(sql, paras);
        }

        // 根据账号密码查（登录用）
        public DataTable GetByLogin(string userName, string pwd)
        {
            string sql = "SELECT * FROM StudentInfo WHERE UserName=@u AND Password=@p AND Status=1";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@u", userName),
                new SqlParameter("@p", pwd)
            };
            return DBHelper.ExecuteQuery(sql, paras);
        }

        // 新增
        public bool Add(StudentInfo s)
        {
            string sql = @"INSERT INTO StudentInfo(UserName,Password,RealName,Phone,ClassName,DormAddress,Status)
                            VALUES(@u,@p,@n,@ph,@c,@d,1)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@u", s.UserName),
                new SqlParameter("@p", s.Password),
                new SqlParameter("@n", s.RealName),
                new SqlParameter("@ph", s.Phone),
                new SqlParameter("@c", s.ClassName),
                new SqlParameter("@d", s.DormAddress)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        // 修改
        public bool Update(StudentInfo s)
        {
            string sql = @"UPDATE StudentInfo SET RealName=@n,Phone=@ph,ClassName=@c,
                            DormAddress=@d,Status=@s WHERE StuId=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@n", s.RealName),
                new SqlParameter("@ph", s.Phone),
                new SqlParameter("@c", s.ClassName),
                new SqlParameter("@d", s.DormAddress),
                new SqlParameter("@s", s.Status),
                new SqlParameter("@id", s.StuId)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        // 删除
        public bool Delete(int stuId)
        {
            string sql = "DELETE FROM StudentInfo WHERE StuId=@id";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@id", stuId) };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        // 重置密码
        public bool ResetPwd(int stuId, string newPwd)
        {
            string sql = "UPDATE StudentInfo SET Password=@p WHERE StuId=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@p", newPwd),
                new SqlParameter("@id", stuId)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }
        public int GetSendLimit(int stuId)
        {
            string sql = "SELECT MaxSendNum FROM StudentInfo WHERE StuId=@id";
            object result = DBHelper.ExecuteScalar(sql, new SqlParameter("@id", stuId));
            return result == null ? 3 : Convert.ToInt32(result);
        }
    }
}