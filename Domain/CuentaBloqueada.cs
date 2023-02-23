using Domain.ModelBase;

namespace Domain
{
    public class CuentaBloqueada : BaseModel
    {
        public long IdCuenta { get; set; }
        public string Archivo { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
