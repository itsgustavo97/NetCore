using Domain.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Infrastructure
{
    public interface IRepositoryGeneric<T> where T : BaseModel
    {
        IQueryable<T> GetQuery();
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);
        void DeleteById(long id);
        void Update(T entity);
        void Add(T entity);

        Task<IReadOnlyList<T>> GetAllActiveAsync();
    }
}
