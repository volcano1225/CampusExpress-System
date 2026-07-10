using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Model
{
    public class ExpressPackage
    {
        public int PackageId { get; set; }
        public string ExpressNo { get; set; }
        public int CateId { get; set; }
        public int ShelfId { get; set; }
        public int ReceiverStuId { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }
        public decimal PackageWeight { get; set; }
        public string PackageSize { get; set; }
        public decimal Price { get; set; }
        public DateTime ArriveTime { get; set; }
        public DateTime DeadLine { get; set; }
        public int IsPickUp { get; set; }
        public DateTime PickUpTime { get; set; }
        public int OverDay { get; set; }
        public decimal FineMoney { get; set; }
        public string PackageDesc { get; set; }
        public string PackageImg { get; set; }
        public int Status { get; set; }
    }
}
