using SynetecAssessmentApi.Domain.SeedWork;
using SynetecAssessmentApi.Persistence.Data.DbContexts;

namespace SynetecAssessmentApi.Persistence.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = _dbContext = dbContext;
            ;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
