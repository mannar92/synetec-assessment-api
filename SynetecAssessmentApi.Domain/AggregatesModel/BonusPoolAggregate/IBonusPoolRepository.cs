using SynetecAssessmentApi.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Domain.AggregatesModel.BonusPoolAggregate
{
    public interface IBonusPoolRepository : IRepository<BonusPool>
    {
        Task<List<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployee(int Id);
    }
}
