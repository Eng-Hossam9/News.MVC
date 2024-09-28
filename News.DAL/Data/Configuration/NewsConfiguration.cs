using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using News.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DAL.Data.Configuration
{
    public class NewsConfiguration : IEntityTypeConfiguration<Newses>
    {
        public void Configure(EntityTypeBuilder<Newses> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n=>n.Id).UseIdentityColumn(1,1);
            builder.HasOne(n=>n.Category).WithMany(c=>c.Newses).HasForeignKey(n=>n.CategoryId);
        }
    }
}
