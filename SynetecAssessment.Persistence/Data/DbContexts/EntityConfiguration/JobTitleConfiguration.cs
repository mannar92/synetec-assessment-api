using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SynetecAssessmentApi.Persistence.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynetecAssessmentApi.Persistence.Data.DbContexts.EntityConfiguration
{
    class JobTitleConfiguration : IEntityTypeConfiguration<JobTitleModel>
    {
        public void Configure(EntityTypeBuilder<JobTitleModel> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id).ValueGeneratedNever();

            builder.ToTable("JobTitles");

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<JobTitleModel> builder)
        {
            builder.HasData(
                new JobTitleModel(1, "Accountant (Senior)", "The Accountant (Senior) of the company"),
                new JobTitleModel(2, "HR Director", "The HR Director of the company"),
                new JobTitleModel(3, "IT Director", "The IT Director of the company"),
                new JobTitleModel(4, "Marketing Manager (Senior)", "The Marketing Manager (Senior) of the company"),
                new JobTitleModel(5, "Marketing Manager (Junior)", "The Marketing Manager (Junior) of the company"),
                new JobTitleModel(6, "IT Support Engineer", "The IT Support Engineer of the company"),
                new JobTitleModel(7, "Creative Director", "The Creative Director of the company"),
                new JobTitleModel(8, "Creative Assistant", "The Creative Assistant of the company"),
                new JobTitleModel(9, "HR Manager", "The HR Manager of the company"),
                new JobTitleModel(10, "Accountant (Junior)", "The Accountant (Junior) of the company")
            );
        }
    }
}
