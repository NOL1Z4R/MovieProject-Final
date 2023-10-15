using System.Threading.Tasks;
using Abp.Application.Services;
using MovieProject.Sessions.Dto;

namespace MovieProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
