using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DAL.Models
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public IEnumerable<Newses>? Newses { get; set; }

    }
}
