using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express.Model
{
    public class SystemNotice
    {
        public int NoticeId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CreateAdminId { get; set; }
        public DateTime CreateTime { get; set; }
        public int IsShow { get; set; }
    }
}
