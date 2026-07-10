using System;
using System.Data;
using System.Data.SqlClient;
using Express.Model;

namespace Express.DAL
{
    public class SendRecordDAL
    {
        public DataTable GetAll(string keyword)
        {
            string sql = "SELECT * FROM SendRecord WHERE 1=1";
            SqlParameter[] paras = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += " AND SendAddress LIKE @key";
                paras = new SqlParameter[] { new SqlParameter("@key", "%" + keyword + "%") };
            }
            sql += " ORDER BY SendTime DESC";
            return DBHelper.ExecuteQuery(sql, paras);
        }

        public bool Add(SendRecord sr)
        {
            string sql = @"INSERT INTO SendRecord(StuId, PackageId, SendAddress, TotalFee, PayWay, IsPay)
                    VALUES(@stu, @pkg, @addr, @fee, @pay, @isPay)";
            SqlParameter[] paras = new SqlParameter[]
            {
        new SqlParameter("@stu", sr.StuId),
        new SqlParameter("@pkg", sr.PackageId),
        new SqlParameter("@addr", sr.SendAddress),
        new SqlParameter("@fee", sr.TotalFee),
        new SqlParameter("@pay", sr.PayWay),
        new SqlParameter("@isPay", sr.IsPay)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        public bool UpdatePay(int recId)
        {
            string sql = "UPDATE SendRecord SET IsPay=1 WHERE RecId=@id";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@id", recId) };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }
    }
}