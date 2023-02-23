﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Specification
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        public Expression<Func<T, object>> OrderBy { get; private set; }

        public Expression<Func<T, object>> OrderByDescending { get; private set; }

        public int Take { get; private set; }

        public int Skip { get; private set; }

        public bool IsPagingEnabled { get; private set; }

        public BaseSpecification(Expression<Func<T, bool>> expression)
        {
            Criteria= expression;
        }
        public BaseSpecification()
        {

        }

        protected void AddInclude(Expression<Func<T, object>> includeExpression) =>
            Includes.Add(includeExpression);
        protected void AddOrderBy(Expression<Func<T, object>> includeExpression) =>
            OrderBy = includeExpression;
        protected void AddOrderByDescending(Expression<Func<T, object>> includeExpression) =>
            OrderByDescending = includeExpression;
        protected void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled= true;
        }
            
    }
}
