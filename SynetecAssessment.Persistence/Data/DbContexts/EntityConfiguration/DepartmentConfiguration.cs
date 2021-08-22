using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;

namespace SynetecAssessmentApi.Persistence.Data.DbContexts.EntityConfiguration
{
    class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id).ValueGeneratedNever();

            builder.ToTable("Departments");

            // Seeding is don in DbInitializer Class
            // SeedData(builder);
        }

        //private void SeedData(EntityTypeBuilder<Department> builder) 
        //{
        //    builder.HasData(
        //        new Department(1, "Finance", "The finance department for the company"),
        //        new Department(2, "Human Resources", "The Human Resources department for the company"),
        //        new Department(3, "IT", "The IT support department for the company"),
        //        new Department(4, "Marketing", "The Marketing department for the company")
        //    );
        //}
    }
}
