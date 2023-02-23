using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Specification.CuentaSpecification
{
    public class CuentaPaginationCount : BaseSpecification<Cuenta>
    {
        public CuentaPaginationCount(CuentaPaginationParams pagParams) :
            base(p => string.IsNullOrEmpty(pagParams.Search) ||
            (p.NumeroCuenta.ToString().Contains(pagParams.Search)))
        {

        }
    }
}
