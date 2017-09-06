using System.Threading.Tasks;
using Abp.Application.Services;
using PhotoShare.Configuration.Dto;

namespace PhotoShare.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}