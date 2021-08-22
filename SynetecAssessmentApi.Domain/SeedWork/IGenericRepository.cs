using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Domain.SeedWork
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        T GetById(object id);

        void Create(T entity);

        void Update(T entity);

        void Delete(object id);
    }
}
