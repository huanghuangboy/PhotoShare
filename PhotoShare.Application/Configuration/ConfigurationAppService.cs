using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PhotoShare.Configuration.Dto;

namespace PhotoShare.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PhotoShareAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
