using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SynetecAssessmentApi.Persistence.Data.Models;

namespace SynetecAssessmentApi.Persistence.Data.DbContexts.EntityConfiguration
{
    class DepartmentConfiguration : IEntityTypeConfiguration<DepartmentModel>
    {
        public void Configure(EntityTypeBuilder<DepartmentModel> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id).ValueGeneratedNever();

            builder.ToTable("Departments");

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<DepartmentModel> builder) 
        {
            builder.HasData(
                new DepartmentModel(1, "Finance", "The finance department for the company"),
                new DepartmentModel(2, "Human Resources", "The Human Resources department for the company"),
                new DepartmentModel(3, "IT", "The IT support department for the company"),
                new DepartmentModel(4, "Marketing", "The Marketing department for the company")
            );
        }
    }
}
