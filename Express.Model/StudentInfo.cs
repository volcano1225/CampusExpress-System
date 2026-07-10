using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Model
{
    public class StudentInfo
    {
        public int StuId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }
        public string ClassName { get; set; }
        public string DormAddress { get; set; }
        public DateTime RegisterTime { get; set; }
        public int MaxSendNum { get; set; }
        public int Status { get; set; }  // 0冻结 1正常
    }
}
