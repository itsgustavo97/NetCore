using Application.Contracts.Infrastructure;
using Domain.ModelBase;
using Infrastructure.Persistencia;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System.Collections;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext db;
        private Hashtable repositories;
        private readonly SqlConnection conn;
        private readonly IConfiguration config;
        private IFileStorage _fileStorage;
        private IRepositoryTransferencia _irepositorioTransferencia;

        public UnitOfWork(ApplicationDBContext db, IConfiguration config)
        {
            this.db = db;
            this.config = config;
            conn = new SqlConnection(config.GetConnectionString("DBBanco"));
        }

        public IRepositoryTransferencia RepositoryTransferencia => _irepositorioTransferencia ??= new RepositoryTransferencia(conn);
        //public IFileStorage FileStorage => _fileStorage ??= new RepositoryCloudFileStorage(config);
        public IFileStorage FileStorage => _fileStorage ??= new RepositoryLocalFileStorage(config);

        public async Task<IDbContextTransaction> BeginTransactionAsync() =>
            await db.Database.BeginTransactionAsync();

        public void Dispose()
        {
            db.Dispose();
            conn.Dispose();
        }

        public IRepositoryGeneric<T> genericRepository<T>() where T : BaseModel
        {
            if (repositories == null)
                repositories = new Hashtable();

            var tipo = typeof(T).Name;
            if (!repositories.ContainsKey(tipo))
            {
                var repositoryType = typeof(RepositoryGeneric<>);
                var instanceRepo = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), db);
                repositories.Add(tipo, instanceRepo);
            }
            return (IRepositoryGeneric<T>)repositories[tipo];
        }

        public async Task<int> SaveChangesAsync() => await db.SaveChangesAsync();
    }
}
