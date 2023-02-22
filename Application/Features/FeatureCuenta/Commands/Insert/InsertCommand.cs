using MediatR;

namespace Application.Features.FeatureCuenta.Commands.Insert
{
    public class InsertCommand : IRequest
    {
        public long NumeroCuenta { get; set; }
        public int TipoCuenta { get; set; }
        public decimal Saldo { get; set; }
    }
}
