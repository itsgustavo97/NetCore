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
    public class CuentaConfig
    {
        public CuentaConfig(EntityTypeBuilder<Cuenta> typeBuilder)
        {
            typeBuilder.Property(c => c.NumeroCuenta).IsRequired();
            typeBuilder.Property(c => c.TipoCuenta).IsRequired();
            typeBuilder.Property(c => c.Saldo).IsRequired().HasColumnType("decimal(20,8)");

            ////Data test
            //typeBuilder.HasData(new Cuenta()
            //{
            //    Id = 1,
            //    NumeroCuenta = 001,
            //    TipoCuenta = 1,
            //    Saldo= 900,
            //    FechaCreado = DateTime.Now,
            //    Borrado = false
            //}, new Cuenta()
            //{
            //    Id = 2,
            //    NumeroCuenta = 001,
            //    TipoCuenta = 1,
            //    Saldo = 900,
            //    FechaCreado = DateTime.Now,
            //    Borrado = false
            //}, new Cuenta()
            //{
            //    Id = 3,
            //    NumeroCuenta = 001,
            //    TipoCuenta = 1,
            //    Saldo = 900,
            //    FechaCreado = DateTime.Now,
            //    Borrado = false
            //});
        }
    }
}
