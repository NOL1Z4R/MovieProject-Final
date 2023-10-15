using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MovieProject.Authorization;

namespace MovieProject
{
    [DependsOn(
        typeof(MovieProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MovieProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MovieProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MovieProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
