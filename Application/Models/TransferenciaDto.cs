namespace Application.Models
{
    public class TransferenciaDto
    {
        public long Id { get; set; }
        public long CuentaOrigen { get; set; }
        public long CuentaDestino { get; set; }
        public decimal Monto { get; set; }
        public string Motivo { get; set; }
        //public string IdUsuarioCreo { get; set; }
        public DateTime FechaCreado { get; set; }
    }
}
