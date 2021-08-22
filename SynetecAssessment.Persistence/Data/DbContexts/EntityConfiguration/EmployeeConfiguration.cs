using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SynetecAssessmentApi.Persistence.Data.Models;

namespace SynetecAssessmentApi.Persistence.Data.DbContexts.EntityConfiguration
{
    class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeModel>
    {
        public void Configure(EntityTypeBuilder<EmployeeModel> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.ToTable("Employees");

            builder
                .HasOne<DepartmentModel>()
                .WithMany()
                .HasForeignKey(d => d.DepartmentId)
                .IsRequired();

            builder
                .HasOne<JobTitleModel>()
                .WithMany()
                .HasForeignKey(d => d.JobTitleId)
                .IsRequired();

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<EmployeeModel> builder)
        {
            builder.HasData(
                new EmployeeModel(1, "John", "Smith", 1, 60000, 1),
                new EmployeeModel(2, "Janet", "Jones", 2, 90000, 2),
                new EmployeeModel(3, "Robert", "Rinser", 3, 95000, 3),
                new EmployeeModel(4, "Jilly", "Thornton", 4, 55000, 4),
                new EmployeeModel(5, "Gemma", "Jones", 5, 45000, 4),
                new EmployeeModel(6, "Peter", "Bateman", 6, 35000, 3),
                new EmployeeModel(7, "Azimir", "Smirkov", 7, 62500, 4),
                new EmployeeModel(8, "Penelope", "Scunthorpe", 8, 38750, 4),
                new EmployeeModel(9, "Amil", "Kahn", 6, 36000, 3),
                new EmployeeModel(10, "Joe", "Masters", 6, 36500, 3),
                new EmployeeModel(11, "Paul", "Azgul", 9, 53000, 2),
                new EmployeeModel(12, "Jennifer", "Smith", 10, 48000, 1)
            );
        }
    }
}
