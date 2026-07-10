using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Model
{
    public class SendRecord
    {
        public int RecId { get; set; }
        public int StuId { get; set; }
        public int PackageId { get; set; }
        public DateTime SendTime { get; set; }
        public string SendAddress { get; set; }
        public decimal TotalFee { get; set; }
        public int PayWay { get; set; }
        public int IsPay { get; set; }
    }
}
