using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class TransferenciaDto
    {
        public long Id { get; set; }
        public long IdCuentaOrigen { get; set; }
        public long IdCuentaDestino { get; set; }
        public decimal Monto { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaCreado { get; set; }
    }
}
