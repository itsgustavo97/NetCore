using Domain.ModelBase;

namespace Domain
{
    public class Cuenta :BaseModel
    {
        public long NumeroCuenta { get; set; }
        public int TipoCuenta { get; set; }
        public decimal Saldo { get; set; }
    }
}
