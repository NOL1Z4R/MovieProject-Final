using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MovieProject.EntityFrameworkCore;
using MovieProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MovieProject.Web.Tests
{
    [DependsOn(
        typeof(MovieProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MovieProjectWebTestModule : AbpModule
    {
        public MovieProjectWebTestModule(MovieProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MovieProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MovieProjectWebMvcModule).Assembly);
        }
    }
}