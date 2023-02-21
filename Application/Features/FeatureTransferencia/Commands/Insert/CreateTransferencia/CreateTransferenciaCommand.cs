using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.FeatureTransferencia.Commands.Insert.CreateTransferencia
{
    public class CreateTransferenciaCommand : IRequest //devuelve un tipo de mediaTr
    {
        public long IdCuentaOrigen { get; set; }
        public long IdCuentaDestino { get; set; }
        public decimal Monto { get; set; }
        public string Motivo { get; set; } = string.Empty;
    }
}
