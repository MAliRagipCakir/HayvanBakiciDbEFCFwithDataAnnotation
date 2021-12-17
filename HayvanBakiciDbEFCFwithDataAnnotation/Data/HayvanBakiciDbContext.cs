using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakiciDbEFCFwithDataAnnotation.Data
{
    public class HayvanBakiciDbContext : DbContext
    {
        public HayvanBakiciDbContext() : base("name=BenimBaglantim")
        {

        }

        public DbSet<Hayvan> Hayvanlar { get; set; }
        public DbSet<Bakici> Bakicilar { get; set; }
        public DbSet<Yiyecek> Yiyecekler { get; set; }
    }
}
