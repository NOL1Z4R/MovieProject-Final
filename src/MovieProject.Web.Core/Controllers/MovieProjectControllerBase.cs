using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MovieProject.Controllers
{
    public abstract class MovieProjectControllerBase: AbpController
    {
        protected MovieProjectControllerBase()
        {
            LocalizationSourceName = MovieProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
