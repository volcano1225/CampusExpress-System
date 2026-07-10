using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Model
{
    public class ShelfInfo
    {
        public int ShelfId { get; set; }
        public string ShelfName { get; set; }
        public int LayerCount { get; set; }
        public int MaxCapacity { get; set; }
        public int RemainSpace { get; set; }
        public string Remark { get; set; }
    }
}
