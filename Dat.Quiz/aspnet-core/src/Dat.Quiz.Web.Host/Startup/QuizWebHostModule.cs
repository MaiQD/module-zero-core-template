using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dat.Quiz.Configuration;

namespace Dat.Quiz.Web.Host.Startup
{
    [DependsOn(
       typeof(QuizWebCoreModule))]
    public class QuizWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public QuizWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuizWebHostModule).GetAssembly());
        }
    }
}

