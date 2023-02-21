using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ModelConfig
{
    public class TransferenciaConfig
    {
        public TransferenciaConfig(EntityTypeBuilder<Transferencia> typeBuilder)
        {
            typeBuilder.Property(c => c.Monto).IsRequired().HasColumnType("decimal(20,8)");
            typeBuilder.Property(c => c.IdCuentaOrigen).IsRequired();
            typeBuilder.Property(c => c.IdCuentaDestino).IsRequired();
            typeBuilder.Property(c => c.Motivo).IsRequired().HasMaxLength(100);
        }
    }
}
