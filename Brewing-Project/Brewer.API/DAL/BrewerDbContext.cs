using Brewer.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Brewer.API.DAL
{
    public class BrewerDbContext : DbContext
    {
        public BrewerDbContext() : base("Brewer.API")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new BrewerAPIInitializer());
            Database.Log = message => Trace.WriteLine(message);
        }
        public DbSet<Grain> Grains { get; set; }
        public DbSet<Hop> Hops { get; set; }
        public DbSet<MiscAddition> MiscAdditions { get; set; }
        public DbSet<Yeast> Yeasts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grain>().HasKey(x => x.Id).Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Hop>().HasKey(x => x.Id).Property(x => x.Id)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<MiscAddition>().HasKey(x => x.Id).Property(x => x.Id)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Yeast>().HasKey(x => x.Id).Property(x => x.Id)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}