using System.Threading.Tasks;
using Abp.Application.Services;
using MovieProject.Authorization.Accounts.Dto;

namespace MovieProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
