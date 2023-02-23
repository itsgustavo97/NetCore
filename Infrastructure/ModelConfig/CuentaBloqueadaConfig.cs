using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.ModelConfig
{
    public class CuentaBloqueadaConfig
    {
        public CuentaBloqueadaConfig(EntityTypeBuilder<CuentaBloqueada> typeBuilder)
        {
            typeBuilder.Property(p => p.Archivo).IsRequired().HasMaxLength(500);
            typeBuilder.HasOne(p => p.Cuenta).WithMany().HasForeignKey(c => c.IdCuenta);
        }
    }
}
