using Abp.Application.Services;
using MovieProject.MultiTenancy.Dto;

namespace MovieProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

