using System;
using System.Data;
using System.Data.SqlClient;
using Express.Model;

namespace Express.DAL
{
    public class ExpressPackageDAL
    {
        public DataTable GetAll(string keyword)
        {
            string sql = @"SELECT p.*, c.CateName, s.ShelfName 
                           FROM ExpressPackage p
                           LEFT JOIN ExpressCategory c ON p.CateId = c.CateId
                           LEFT JOIN ShelfInfo s ON p.ShelfId = s.ShelfId
                           WHERE 1=1";
            SqlParameter[] paras = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                sql += " AND (p.ExpressNo LIKE @key OR p.ReceiverName LIKE @key OR p.ReceiverPhone LIKE @key)";
                paras = new SqlParameter[] { new SqlParameter("@key", "%" + keyword + "%") };
            }
            sql += " ORDER BY p.ArriveTime DESC";
            return DBHelper.ExecuteQuery(sql, paras);
        }

        public bool Add(ExpressPackage p)
        {
            string sql = @"INSERT INTO ExpressPackage(ExpressNo, CateId, ShelfId, ReceiverStuId, ReceiverName, ReceiverPhone,
                            SenderName, SenderPhone, PackageWeight, PackageSize, Price, ArriveTime, DeadLine, Status)
                            VALUES(@no,@c,@sh,@rs,@rn,@rp,@sn,@sp,@w,@sz,@pr,GETDATE(),DATEADD(day,3,GETDATE()),@st)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@no", p.ExpressNo),
                new SqlParameter("@c", p.CateId),
                new SqlParameter("@sh", p.ShelfId),
                new SqlParameter("@rs", p.ReceiverStuId),
                new SqlParameter("@rn", p.ReceiverName),
                new SqlParameter("@rp", p.ReceiverPhone),
                new SqlParameter("@sn", p.SenderName),
                new SqlParameter("@sp", p.SenderPhone),
                new SqlParameter("@w", p.PackageWeight),
                new SqlParameter("@sz", p.PackageSize),
                new SqlParameter("@pr", p.Price),
                new SqlParameter("@st", p.Status)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        public bool Update(ExpressPackage p)
        {
            string sql = @"UPDATE ExpressPackage SET ExpressNo=@no, CateId=@c, ShelfId=@sh,
                            ReceiverName=@rn, ReceiverPhone=@rp, SenderName=@sn,
                            PackageWeight=@w, PackageSize=@sz, Status=@st
                            WHERE PackageId=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@no", p.ExpressNo),
                new SqlParameter("@c", p.CateId),
                new SqlParameter("@sh", p.ShelfId),
                new SqlParameter("@rn", p.ReceiverName),
                new SqlParameter("@rp", p.ReceiverPhone),
                new SqlParameter("@sn", p.SenderName),
                new SqlParameter("@w", p.PackageWeight),
                new SqlParameter("@sz", p.PackageSize),
                new SqlParameter("@st", p.Status),
                new SqlParameter("@id", p.PackageId)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        public bool Delete(int packageId)
        {
            string sql = "DELETE FROM ExpressPackage WHERE PackageId=@id";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@id", packageId) };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }

        public bool Pickup(int packageId)
        {
            string sql = "UPDATE ExpressPackage SET IsPickUp=1, PickUpTime=GETDATE(), Status=2 WHERE PackageId=@id";
            return DBHelper.ExecuteNonQuery(sql, new SqlParameter("@id", packageId)) > 0;
        }

        public bool UpdateFine(int packageId, decimal fine)
        {
            string sql = "UPDATE ExpressPackage SET FineMoney=@fine, Status=3 WHERE PackageId=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
        new SqlParameter("@fine", fine),
        new SqlParameter("@id", packageId)
            };
            return DBHelper.ExecuteNonQuery(sql, paras) > 0;
        }
        // 新增寄件包裹，返回自增ID
        public int AddPackage(ExpressPackage p)
        {
            string sql = @"INSERT INTO ExpressPackage(ExpressNo, CateId, ReceiverName, ReceiverPhone, 
                    PackageWeight, PackageSize, Price, SenderName, SenderPhone, Status)
                    VALUES(@no, @cate, @rName, @rPhone, @weight, @size, @price, @sName, @sPhone, 5);
                    SELECT SCOPE_IDENTITY();";
            SqlParameter[] paras = new SqlParameter[]
            {
        new SqlParameter("@no", p.ExpressNo),
        new SqlParameter("@cate", p.CateId),
        new SqlParameter("@rName", p.ReceiverName),
        new SqlParameter("@rPhone", p.ReceiverPhone),
        new SqlParameter("@weight", p.PackageWeight),
        new SqlParameter("@size", p.PackageSize),
        new SqlParameter("@price", p.Price),
        new SqlParameter("@sName", p.SenderName),
        new SqlParameter("@sPhone", p.SenderPhone)
            };
            object result = DBHelper.ExecuteScalar(sql, paras);
            return Convert.ToInt32(result);
        }
    }
}
