using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MovieProject.Configuration;

namespace MovieProject.Web.Host.Startup
{
    [DependsOn(
       typeof(MovieProjectWebCoreModule))]
    public class MovieProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MovieProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MovieProjectWebHostModule).GetAssembly());
        }
    }
}
