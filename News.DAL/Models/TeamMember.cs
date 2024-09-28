using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DAL.Models
{
    public class TeamMember : BaseEntity
    {
        public string Name {get;set; }
        public string JopTitle {get;set; }
        public string? Image {get;set; }

    }
}
