using Domain.ModelBase;

namespace Domain
{
    public class Transferencia : BaseModel
    {
        public long IdCuentaOrigen { get; set; }
        public long IdCuentaDestino { get; set; }
        public decimal Monto { get; set; }
        public string Motivo { get; set; } = string.Empty;
    }
}
