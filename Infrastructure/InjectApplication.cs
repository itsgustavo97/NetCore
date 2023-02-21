using Application.Contracts.Infrastructure;
using Infrastructure.Persistencia;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class InjectApplication
    {
        public static IServiceCollection InjectService(this IServiceCollection services, IConfiguration IConfig)
        {
            services.AddDbContext<ApplicationDBContext>(c => c.UseSqlServer(IConfig.GetConnectionString("DBBanco")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepositoryGeneric<>), typeof(RepositoryGeneric<>));
            return services;
        }
    }
}
