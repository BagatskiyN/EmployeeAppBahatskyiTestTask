using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.WorkExperiences)
                .WithOne(we => we.Employee)
                .HasForeignKey(we => we.EmployeeId);

            modelBuilder.Entity<WorkExperience>()
                .HasKey(we => new { we.EmployeeId, we.ProgrammingLanguageId });

            modelBuilder.Entity<WorkExperience>()
                .HasOne(we => we.Employee)
                .WithMany(e => e.WorkExperiences)
                .HasForeignKey(we => we.EmployeeId);

            modelBuilder.Entity<WorkExperience>()
                .HasOne(we => we.ProgrammingLanguage)
                .WithMany(pl => pl.WorkExperiences)
                .HasForeignKey(we => we.ProgrammingLanguageId);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "HR", Floor = 1 },
                new Department { Id = 2, Name = "IT", Floor = 2 },
                new Department { Id = 3, Name = "Finance", Floor = 3 }
            );

            modelBuilder.Entity<ProgrammingLanguage>().HasData(
                new ProgrammingLanguage { Id = 1, Name = "C#" },
                new ProgrammingLanguage { Id = 2, Name = "Java" },
                new ProgrammingLanguage { Id = 3, Name = "JavaScript" }
            );
        }
    }
}