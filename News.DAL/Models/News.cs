using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DAL.Models
{
    public class Newses : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Date{ get; set; }
        public string  Image{ get; set; }
        public string Topic { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
