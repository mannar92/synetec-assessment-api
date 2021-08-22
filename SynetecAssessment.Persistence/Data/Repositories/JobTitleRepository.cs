using SynetecAssessmentApi.Persistence.Data.DbContexts;
using SynetecAssessmentApi.Persistence.Data.Interfaces;
using SynetecAssessmentApi.Persistence.Data.Models;

namespace SynetecAssessmentApi.Persistence.Data.Repositories
{
    public class JobTitleRepository : GenericRepository<JobTitleModel>, IJobTitleRepository
    {
        public JobTitleRepository(AppDbContext dbContext)
:            base(dbContext)
        {

        }
    }
}
