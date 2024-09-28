using News.BLL.InterFaces;
using News.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.BLL.Repositories
{
    public class TeamMemberRepository : GenaricRepository<TeamMember>, ITeamMemberRepository
    {
        public TeamMemberRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
