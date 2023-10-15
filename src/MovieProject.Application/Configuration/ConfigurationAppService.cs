using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MovieProject.Configuration.Dto;

namespace MovieProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MovieProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
