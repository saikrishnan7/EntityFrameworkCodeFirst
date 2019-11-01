using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstVidzy.EntityConfiguration
{
    public class GenreEntityConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreEntityConfiguration()
        {
            Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
