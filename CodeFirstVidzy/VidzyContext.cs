﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstVidzy
{
    public class VidzyContext :DbContext
    {
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        public VidzyContext() : base("name=VidzyCodeFirst")
        {

        }
    }
}
