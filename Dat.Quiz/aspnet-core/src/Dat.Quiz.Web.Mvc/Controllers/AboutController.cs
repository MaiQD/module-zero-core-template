using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Dat.Quiz.Controllers;

namespace Dat.Quiz.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : QuizControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}

