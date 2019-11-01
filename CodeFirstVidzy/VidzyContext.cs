using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstVidzy.EntityConfiguration;

namespace CodeFirstVidzy
{
    public class VidzyContext :DbContext
    {
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        public VidzyContext() : base("name=VidzyCodeFirst")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoEntityConfiguration());
            modelBuilder.Configurations.Add(new GenreEntityConfiguration());
        }
    }
}
