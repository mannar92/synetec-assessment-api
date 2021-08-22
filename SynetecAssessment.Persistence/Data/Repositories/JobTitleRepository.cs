using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;
using SynetecAssessmentApi.Domain.SeedWork;
using SynetecAssessmentApi.Persistence.Data.DbContexts;

namespace SynetecAssessmentApi.Persistence.Data.Repositories
{
    public class JobTitleRepository : GenericRepository<JobTitle>, IJobTitleRepository
    {
        public JobTitleRepository(AppDbContext dbContext)
:            base(dbContext)
        {

        }
    }
}
