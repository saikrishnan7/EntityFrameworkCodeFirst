using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstVidzy.EntityConfiguration
{
    public class VideoEntityConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoEntityConfiguration()
        {
            Property(v => v.Name)
                .IsRequired();

            HasRequired(v => v.Genre)
                .WithMany(g => g.Videos)
                .HasForeignKey(c => c.GenreId)
                .WillCascadeOnDelete(false);

            Property(v => v.Classification)
                .HasColumnType("tinyint");

            HasMany(v => v.Tags)
                .WithMany(t => t.Videos)
                .Map(m =>
                {
                    m.ToTable("VideoTags");
                    m.MapLeftKey("VideoId");
                    m.MapRightKey("TagId");
                });
        }
    }
}
