using System.Threading.Tasks;
using Abp.Application.Services;
using PhotoShare.Sessions.Dto;

namespace PhotoShare.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
