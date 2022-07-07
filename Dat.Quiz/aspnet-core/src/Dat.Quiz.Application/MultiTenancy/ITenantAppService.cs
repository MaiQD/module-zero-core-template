using Abp.Application.Services;
using Dat.Quiz.MultiTenancy.Dto;

namespace Dat.Quiz.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


