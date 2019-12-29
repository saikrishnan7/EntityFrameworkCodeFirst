using System.Data.Entity.ModelConfiguration;

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
