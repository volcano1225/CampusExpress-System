using System.Data;
using Express.Model;
using Express.DAL;

namespace Express.BLL
{
    public class AdminInfoBLL
    {
        AdminInfoDAL dal = new AdminInfoDAL();
        public DataTable GetList(string keyword) { return dal.GetAll(keyword); }
        public bool Add(AdminInfo a) { return dal.Add(a); }
        public bool Update(AdminInfo a) { return dal.Update(a); }
        public bool Delete(int id) { return dal.Delete(id); }
        public bool ResetPassword(int id, string pwd) { return dal.ResetPwd(id, pwd); }
        public DataTable Login(string user, string pwd) { return dal.GetByLogin(user, pwd); }
    }
}
