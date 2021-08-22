using SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate;
using SynetecAssessmentApi.Domain.SeedWork;
using SynetecAssessmentApi.Persistence.Data.DbContexts;

namespace SynetecAssessmentApi.Persistence.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
