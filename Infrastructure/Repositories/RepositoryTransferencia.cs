using Application.Contracts.Infrastructure;
using Application.Models;
using Dapper;
using Domain;
using Microsoft.Data.SqlClient;

namespace Infrastructure.Repositories
{
    public class RepositoryTransferencia : IRepositoryTransferencia
    {
        private readonly SqlConnection db;
        public RepositoryTransferencia(SqlConnection db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<TransferenciaDto>> GetAllAsync(long IdCuentaOrigen) //=>
        {
            var res = await db.QueryAsync<TransferenciaDto>("EXEC dbo.GetAllTransfersRealizadasByCuenta @IdCuentaOrigen", new { IdCuentaOrigen});
            return res;
        }
    }
}
