using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhotoShare.MultiTenancy.Dto;

namespace PhotoShare.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
