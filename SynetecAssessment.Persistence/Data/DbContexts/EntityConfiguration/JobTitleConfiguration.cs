using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;

namespace SynetecAssessmentApi.Persistence.Data.DbContexts.EntityConfiguration
{
    class JobTitleConfiguration : IEntityTypeConfiguration<JobTitle>
    {
        public void Configure(EntityTypeBuilder<JobTitle> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id).ValueGeneratedNever();

            builder.ToTable("JobTitles");

            // Seeding is don in DbInitializer Class
            // SeedData(builder);
        }

        //private void SeedData(EntityTypeBuilder<JobTitle> builder)
        //{
        //    builder.HasData(
        //        new JobTitle(1, "Accountant (Senior)", "The Accountant (Senior) of the company"),
        //        new JobTitle(2, "HR Director", "The HR Director of the company"),
        //        new JobTitle(3, "IT Director", "The IT Director of the company"),
        //        new JobTitle(4, "Marketing Manager (Senior)", "The Marketing Manager (Senior) of the company"),
        //        new JobTitle(5, "Marketing Manager (Junior)", "The Marketing Manager (Junior) of the company"),
        //        new JobTitle(6, "IT Support Engineer", "The IT Support Engineer of the company"),
        //        new JobTitle(7, "Creative Director", "The Creative Director of the company"),
        //        new JobTitle(8, "Creative Assistant", "The Creative Assistant of the company"),
        //        new JobTitle(9, "HR Manager", "The HR Manager of the company"),
        //        new JobTitle(10, "Accountant (Junior)", "The Accountant (Junior) of the company")
        //    );
        //}
    }
}
