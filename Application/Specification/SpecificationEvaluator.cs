using Domain.ModelBase;
using Microsoft.EntityFrameworkCore;

namespace Application.Specification
{
    public class SpecificationEvaluator<T> where T : BaseModel
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            if(specification.Criteria != null)
                inputQuery = inputQuery.Where(specification.Criteria);
            if(specification.OrderBy != null)
                inputQuery.OrderBy(specification.OrderBy);
            if(specification.OrderByDescending != null)
                inputQuery.OrderByDescending(specification.OrderByDescending);
            if (specification.IsPagingEnabled)
                inputQuery = inputQuery.Skip(specification.Skip).Take(specification.Take);
            inputQuery = specification.Includes.Aggregate(inputQuery, (current, include) => current.Include(include));
            return inputQuery;
        }
    }
}
