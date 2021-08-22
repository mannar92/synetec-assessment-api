using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Persistence.Data.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        T GetById(object id);

        void Create(T entity);

        void Update(T entity);

        void Delete(object id);
    }
}
