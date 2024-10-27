using System;
using Microsoft.EntityFrameworkCore;

namespace FirstApp2.Models
{
    public class HrContext : DbContext
    {
        public HrContext()
        {

        }
        public virtual DbSet<EmployeeModel> TbEmployees { get; set; }
        public virtual DbSet<DepartmentsModel> TbDepartments { get; set; }
        public virtual DbSet<EmployeeVacation> TbEmployeeVacation { get; set; }
        public virtual DbSet<PersonModel> TbPersons { get; set; }
        public virtual DbSet<AllawancesModel> TbAllawances { get; set; }
        public virtual DbSet<EmployeeAllawanceModel> EmployeeAllawances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-NRE4E8S; Database=HRApp; Trusted_Connection=True; TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>(entity =>
            {
                entity.Property(a => a.Description).HasMaxLength(2000);

                entity.HasOne(e => e.TbDepartment)  // الربط بين الموظف والقسم
                      .WithMany(d => d.Employees)
                      .HasForeignKey(e => e.DepartmentId);  // المفتاح الأجنبي في EmployeeModel
                entity.HasOne(p => p.TbPerson).WithOne(s => s.TbEmployee)
                .HasForeignKey<EmployeeModel>(s => s.PersonId);
            });

            modelBuilder.Entity<DepartmentsModel>(entity =>
            {
                entity.HasKey(a => a.DepartmentId);
                entity.Property(a => a.DepartmentName).HasMaxLength(200);
            });
            modelBuilder.Entity<EmployeeVacation>(entity =>
            {
                entity.HasKey(a => a.EmployeeVacationId);
                entity.HasOne(a => a.TbEmployee).WithMany(s => s.EmployeeVacations)
                .HasForeignKey(a => a.EmployeeId);
            });
            modelBuilder.Entity<EmployeeAllawanceModel>(entity =>
            {
                entity.HasOne(e => e.TbEmployee)
                       .WithMany(d => d.EmployeeAllawances)
                       .HasForeignKey(e => e.EmployeeId);

                entity.HasOne(e => e.Tballawances)
                     .WithMany(d => d.EmployeeAllawances)
                     .HasForeignKey(e => e.AllawancesId);
            });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(200);
            configurationBuilder.Properties<decimal>().HaveColumnType("decimal(8, 2");
            configurationBuilder.Properties<DateTime>().HaveColumnType("DateTime");
        }
    }
}
