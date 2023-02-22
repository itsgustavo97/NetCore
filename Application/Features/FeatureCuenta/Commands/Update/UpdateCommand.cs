﻿using MediatR;

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
