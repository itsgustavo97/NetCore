using Domain;
using Domain.ModelBase;
using Infrastructure.ModelConfig;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistencia
{
    public class ApplicationDBContext : DbContext
    {
        private readonly IHttpContextAccessor _accessor;
        //constructor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions, IHttpContextAccessor accessor) : base(dbContextOptions)
        {
            _accessor = accessor;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new CuentaConfig(builder.Entity<Cuenta>());
            new TransferenciaConfig(builder.Entity<Transferencia>());

            base.OnModelCreating(builder);
        }

        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Transferencia> Transferencia { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            string IdUser = _accessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == "IdUser")?.Value;
            foreach(var entidad in ChangeTracker.Entries<BaseModel>())
            {
                switch (entidad.State)
                {
                    case EntityState.Added:
                        entidad.Entity.FechaCreado = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entidad.Entity.FechaModificado = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
