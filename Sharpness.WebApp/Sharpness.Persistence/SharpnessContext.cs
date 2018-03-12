using Sharpness.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpness.Persistence
{
    public class SharpnessContext: DbContext

    {
        public SharpnessContext() : base("SharpnessContext")
        { }

        public DbSet<Metric> Metrics { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Organ> Organs { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Stain> Stains { get; set; }
        public DbSet<Tissue> Tissues { get; set; }
        
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Report>()
                .HasRequired<Order>(o => o.Order)
                .WithMany(r=> r.Reports)
                .HasForeignKey<string>(o => o.OrderId);
            modelBuilder.Entity<Report>()
                .HasRequired<Organ>(o => o.Organ)
                .WithMany(r => r.Reports)
                .HasForeignKey<string>(o => o.OrganId);
            modelBuilder.Entity<Report>()
                .HasRequired<Tissue>(t => t.Tissue)
                .WithMany(r => r.Reports)
                .HasForeignKey<string>(t => t.TissueId);
            modelBuilder.Entity<Report>()
               .HasRequired<Stain>(s => s.Stain)
               .WithMany(r => r.Reports)
               .HasForeignKey<string>(s => s.StainId);
            modelBuilder.Entity<Order>()
               .HasRequired<Metric>(m => m.Metric)
               .WithMany(o => o.Orders)
               .HasForeignKey<string>(m => m.MetricId);
        }
    }


}

