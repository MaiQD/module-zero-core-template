using System.Threading.Tasks;
using Abp.Application.Services;
using Dat.Quiz.Sessions.Dto;

namespace Dat.Quiz.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

