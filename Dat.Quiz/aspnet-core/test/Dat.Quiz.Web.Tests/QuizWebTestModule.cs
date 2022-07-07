using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dat.Quiz.EntityFrameworkCore;
using Dat.Quiz.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Dat.Quiz.Web.Tests
{
    [DependsOn(
        typeof(QuizWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class QuizWebTestModule : AbpModule
    {
        public QuizWebTestModule(QuizEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(QuizWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(QuizWebMvcModule).Assembly);
        }
    }
}
