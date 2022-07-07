using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Dat.Quiz.Web.Views
{
    public abstract class QuizRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected QuizRazorPage()
        {
            LocalizationSourceName = QuizConsts.LocalizationSourceName;
        }
    }
}

