using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Model
{
    public class AdminInfo
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string Pwd { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
