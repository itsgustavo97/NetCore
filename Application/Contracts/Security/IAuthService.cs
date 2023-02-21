using Application.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Security
{
    public interface IAuthService : IDisposable
    {
        Task<AuthResponse> LoginAsync(AuthRequest request);
    }
}
