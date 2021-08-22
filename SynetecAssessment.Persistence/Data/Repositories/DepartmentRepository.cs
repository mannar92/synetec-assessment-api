using SynetecAssessmentApi.Persistence.Data.DbContexts;
using SynetecAssessmentApi.Persistence.Data.Interfaces;
using SynetecAssessmentApi.Persistence.Data.Models;

namespace SynetecAssessmentApi.Persistence.Data.Repositories
{
    public class DepartmentRepository : GenericRepository<DepartmentModel>, IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext dbContext)
:           base(dbContext)
        {

        }
    }
}
