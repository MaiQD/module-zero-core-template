using System.Threading.Tasks;
using Dat.Quiz.Configuration.Dto;

namespace Dat.Quiz.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

