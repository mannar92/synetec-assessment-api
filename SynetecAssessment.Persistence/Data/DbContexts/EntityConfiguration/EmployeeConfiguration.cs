using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;

namespace SynetecAssessmentApi.Persistence.Data.DbContexts.EntityConfiguration
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.ToTable("Employees");

            builder
                .HasOne<Department>()
                .WithMany()
                .HasForeignKey(d => d.DepartmentId)
                .IsRequired();

            builder
                .HasOne<JobTitle>()
                .WithMany()
                .HasForeignKey(d => d.JobTitleId)
                .IsRequired();

            // Seeding is don in DbInitializer Class
            // SeedData(builder);
        }

        //private void SeedData(EntityTypeBuilder<Employee> builder)
        //{
        //    builder.HasData(
        //        new Employee(1, "John", "Smith", 1, 60000, 1),
        //        new Employee(2, "Janet", "Jones", 2, 90000, 2),
        //        new Employee(3, "Robert", "Rinser", 3, 95000, 3),
        //        new Employee(4, "Jilly", "Thornton", 4, 55000, 4),
        //        new Employee(5, "Gemma", "Jones", 5, 45000, 4),
        //        new Employee(6, "Peter", "Bateman", 6, 35000, 3),
        //        new Employee(7, "Azimir", "Smirkov", 7, 62500, 4),
        //        new Employee(8, "Penelope", "Scunthorpe", 8, 38750, 4),
        //        new Employee(9, "Amil", "Kahn", 6, 36000, 3),
        //        new Employee(10, "Joe", "Masters", 6, 36500, 3),
        //        new Employee(11, "Paul", "Azgul", 9, 53000, 2),
        //        new Employee(12, "Jennifer", "Smith", 10, 48000, 1)
        //    );
        //}
    }
}
