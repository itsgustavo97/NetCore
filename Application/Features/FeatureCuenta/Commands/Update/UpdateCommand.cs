using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FeatureCuenta.Commands.Update
{
    public class UpdateCommand : IRequest
    {
        public long Id { get; set; }
        public long NumeroCuenta { get; set; }
        public int TipoCuenta { get; set; }
        public decimal Saldo { get; set; }
    }
}
