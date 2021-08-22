using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;
using SynetecAssessmentApi.Domain.SeedWork;
using SynetecAssessmentApi.Persistence.Data.DbContexts;

namespace SynetecAssessmentApi.Persistence.Data.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext dbContext)
:           base(dbContext)
        {

        }
    }
}
