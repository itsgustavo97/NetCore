using Application.Models;

namespace Application.Contracts.Infrastructure
{
    public interface IRepositoryTransferencia
    {
        Task<IEnumerable<TransferenciaDto>> GetAllAsync(long IdCuentaOrigen);
    }
}
