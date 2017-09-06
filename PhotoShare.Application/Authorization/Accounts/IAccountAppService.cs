using System.Threading.Tasks;
using Abp.Application.Services;
using PhotoShare.Authorization.Accounts.Dto;

namespace PhotoShare.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
