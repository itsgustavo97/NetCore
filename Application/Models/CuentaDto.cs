using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class CuentaDto
    {
        public long Id { get; set; }
        public long NumeroCuenta { get; set; }
        public int TipoCuenta { get; set; }
        public decimal Saldo { get; set; }
        public bool Borrado { get; set; }
        public DateTime FechaCreado { get; set; }
    }
}
