using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dat.Quiz.Authorization;

namespace Dat.Quiz
{
    [DependsOn(
        typeof(QuizCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class QuizApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<QuizAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(QuizApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

