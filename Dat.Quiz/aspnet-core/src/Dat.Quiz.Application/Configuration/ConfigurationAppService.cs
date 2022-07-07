using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Dat.Quiz.Configuration.Dto;

namespace Dat.Quiz.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QuizAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

