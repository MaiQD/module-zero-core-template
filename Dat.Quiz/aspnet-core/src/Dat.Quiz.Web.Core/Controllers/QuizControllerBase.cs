using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Dat.Quiz.Controllers
{
    public abstract class QuizControllerBase: AbpController
    {
        protected QuizControllerBase()
        {
            LocalizationSourceName = QuizConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

