using Microsoft.EntityFrameworkCore;
using SynetecAssessmentApi.Persistence.Data.Models;
using System.Reflection;

namespace SynetecAssessmentApi.Persistence.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<JobTitleModel> JobTitles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

    }
}
