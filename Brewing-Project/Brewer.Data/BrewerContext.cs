using Brewer.Data.Maps;
using Brewer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewer.Data
{
    public class BrewerContext : DbContext
    {
        public BrewerContext() : base("Brewer")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BrewerContext>());
        }
        public DbSet<Grain> Grains { get; set; }
        public DbSet<Hop> Hops { get; set; }
        public DbSet<MiscAddition> MiscAdditions { get; set; }
        public DbSet<Yeast> Yeasts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GrainMap());
            modelBuilder.Configurations.Add(new HopMap());
            modelBuilder.Configurations.Add(new MiscAdditionMap());
            modelBuilder.Configurations.Add(new YeastMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
