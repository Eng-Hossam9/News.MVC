using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DAL.Models
{
    public class ContactUS:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Massage { get; set; }
        public string Subject { get; set; }

    }
}
