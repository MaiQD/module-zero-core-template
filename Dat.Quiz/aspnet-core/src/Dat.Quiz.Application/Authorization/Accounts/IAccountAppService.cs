using System.Threading.Tasks;
using Abp.Application.Services;
using Dat.Quiz.Authorization.Accounts.Dto;

namespace Dat.Quiz.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

