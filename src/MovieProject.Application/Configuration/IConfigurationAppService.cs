using System.Threading.Tasks;
using MovieProject.Configuration.Dto;

namespace MovieProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
