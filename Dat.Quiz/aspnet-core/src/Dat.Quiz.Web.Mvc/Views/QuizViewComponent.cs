using Abp.AspNetCore.Mvc.ViewComponents;

namespace Dat.Quiz.Web.Views
{
    public abstract class QuizViewComponent : AbpViewComponent
    {
        protected QuizViewComponent()
        {
            LocalizationSourceName = QuizConsts.LocalizationSourceName;
        }
    }
}

