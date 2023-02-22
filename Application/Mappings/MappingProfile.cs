using Application.Features.FeatureCuenta.Commands.Insert;
using Application.Features.FeatureCuenta.Commands.Update;
using Application.Features.FeatureTransferencia.Commands.Insert.CreateTransferencia;
using Application.Models;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Se registra cada endpoint, match entre vmModel o Dto y entidad

            //Cuenta
            CreateMap<Cuenta, CuentaDto>();
            CreateMap<UpdateCommand, Cuenta>();
            CreateMap<InsertCommand, Cuenta>();
            //Transferencia
            CreateMap<CreateTransferenciaCommand, Transferencia>();
            CreateMap<Transferencia, TransferenciaDto>();
        }
    }
}
