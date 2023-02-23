using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Specification.CuentaSpecification
{
    public class CuentaPagination : BaseSpecification<Cuenta>
    {
        public CuentaPagination(CuentaPaginationParams pagParams) : 
            base(p => string.IsNullOrEmpty(pagParams.Search) || 
            (p.NumeroCuenta.ToString().Contains(pagParams.Search)))
        {
            ApplyPaging(pagParams.PageSize * (pagParams.PageIndex - 1), pagParams.PageSize);
            if (!string.IsNullOrEmpty(pagParams.Sort))
            {
                switch (pagParams.Sort)
                {
                    case "numerocuentaasc":
                        AddOrderBy(c => c.NumeroCuenta);
                        break;
                    case "numerocuentadesc":
                        AddOrderByDescending(c => c.NumeroCuenta);
                        break;
                }
            }
            else
            {
                AddOrderBy(x => x.Id);
            }
        }
    }
}
