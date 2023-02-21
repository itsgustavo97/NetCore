using Application.Contracts.Infrastructure;
using Domain.ModelBase;
using Infrastructure.Persistencia;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext db;
        private Hashtable repositories;

        public UnitOfWork(ApplicationDBContext db)
        {
            this.db = db;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync() =>
            await db.Database.BeginTransactionAsync();

        public void Dispose() => db.Dispose();

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
