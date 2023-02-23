using Application.Features.FeatureCuenta.Commands.Insert;
using Application.Features.FeatureCuenta.Commands.Update;
using Application.Features.FeatureCuenta.Queries.GetCuentaPagination;
using Application.Features.FeatureCuentaBloqueada.Commands.InsertCuentaBloqueada;
using Application.Features.FeatureTransferencia.Commands.Insert.CreateTransferencia;
using Application.Models;
using Application.Specification.CuentaSpecification;
using AutoMapper;
using Domain;

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
            //File Cloud Storage
            CreateMap<InsertCuentaBloqueadaCommand, CuentaBloqueada>();
            //Pagination Cuenta
            CreateMap<CuentaPaginationParams, GetCuentaPaginationQuery>()
                .ForMember(c => c.PageIndex, x => x.MapFrom(v => v.PageIndex))
                .ForMember(c => c.Search, x => x.MapFrom(v => v.Search))
                .ForMember(c => c.PageSize, x => x.MapFrom(v => v.PageSize))
                .ForMember(c => c.SortBy, x => x.MapFrom(v => v.Sort)).ReverseMap();
        }
    }
}
