using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Butce.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Butce.DataAccessLayer.Concrete
{
    public class BudgetContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-I7BINER\\SQLEXPRESS;initial Catalog=BudgettDB;integrated Security=true;TrustServerCertificate=True");
            
        }

        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Expenses> Expensess { get; set; }
        public DbSet<Levels> Levelss { get; set; }
        public DbSet<SubLevels> SubLevelss { get; set; }
        public DbSet<CompanyName> CompanyNames { get; set; }
        public DbSet<WorkDone> WorkDones { get; set; }
        public DbSet<WorkDoneType> WorkDoneTypes { get; set; }
        public DbSet<VAT> VATs { get; set; }
        public DbSet<Planning> Plannings { get; set; }
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<AppControl> AppControls { get; set; }
        public DbSet<Realization> Realizations { get; set; }
        public DbSet<BudgetAmount> BudgetAmounts { get; set; }
        public DbSet<Refuse> Refuses { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<AddUser> AddUsers { get; set; }
        public DbSet<Proxy> Proxies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         
            modelBuilder.Entity<Realization>()
                .HasOne(r => r.SubLevels)
                .WithMany()
                .HasForeignKey(r => r.SubLevelID)
                .OnDelete(DeleteBehavior.Restrict);

         
   
            modelBuilder.Entity<Realization>()
                .HasOne(r => r.Budget)
                .WithMany()
                .HasForeignKey(r => r.BudgetTypeID)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }
}
