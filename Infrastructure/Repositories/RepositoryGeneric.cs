using Application.Contracts.Infrastructure;
using Application.Specification;
using Domain.ModelBase;
using Infrastructure.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RepositoryGeneric<T> : IRepositoryGeneric<T> where T : BaseModel
    {
        private ApplicationDBContext DBContext;

        public RepositoryGeneric(ApplicationDBContext dBContext)
        {
            DBContext = dBContext;
        }

        public void Add(T entity)
        {
            DBContext.Set<T>().Add(entity);
        }


        public void DeleteById(long id)
        {
            var model = DBContext.Set<T>()!.Find(id);
            DBContext.Set<T>().Remove(model);
        }

        public async Task<IReadOnlyList<T>> GetAllActiveAsync() =>
            await DBContext.Set<T>().ToListAsync();

        public async Task<IReadOnlyList<T>> GetAllAsync() =>
            await DBContext.Set<T>().ToListAsync();


        public async Task<T> GetByIdAsync(long id) =>
            await DBContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

        public IQueryable<T> GetQuery() =>
            DBContext.Set<T>().AsQueryable();

        public void Update(T entity)
        {
            DBContext.Entry(entity).State = EntityState.Modified;
        }
        public async Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> spec) =>
            await ApplySpecification(spec).ToListAsync();
        public async Task<T> GetByIdWithSpecAsync(ISpecification<T> spec) =>
            await ApplySpecification(spec).FirstOrDefaultAsync();
        public async Task<int> CountAsync(ISpecification<T> spec) =>
            await ApplySpecification(spec).CountAsync();
        private IQueryable<T> ApplySpecification(ISpecification<T> specification) =>
            SpecificationEvaluator<T>.GetQuery(DBContext.Set<T>().AsQueryable(), specification);
    }
}
