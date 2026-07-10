using System.Data;
using System.Data.SqlClient;

namespace Express.DAL
{
    public class DBHelper
    {
        private static string connStr = "server=.;database=ExpressManager;uid=sa;pwd=admin/123456;";



        // 查询，返回DataTable（绑定DataGridView用）
        public static DataTable ExecuteQuery(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                if (paras != null) da.SelectCommand.Parameters.AddRange(paras);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 增删改，返回受影响行数（>0表示成功）
        public static int ExecuteNonQuery(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (paras != null) cmd.Parameters.AddRange(paras);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // 聚合查询，返回首行首列（查Count、Sum等）
        public static object ExecuteScalar(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (paras != null) cmd.Parameters.AddRange(paras);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}