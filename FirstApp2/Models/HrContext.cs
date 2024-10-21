
using System;
using Microsoft.EntityFrameworkCore;


namespace FirstApp2.Models
{
    public class HrContext : DbContext
    {
        public HrContext() 
        {
        
        }
        public DbSet<EmployeeModel> TbEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-NRE4E8S; Database=HRApp; Trusted_Connection=True; TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>(entity =>
            {
                entity.Property(a => a.Description).HasMaxLength(2000);
            });
        }
    }

   
}
