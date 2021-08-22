using SynetecAssessmentApi.Persistence.Data.DbContexts;
using SynetecAssessmentApi.Persistence.Data.Interfaces;
using SynetecAssessmentApi.Persistence.Data.Models;

namespace SynetecAssessmentApi.Persistence.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<EmployeeModel>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
