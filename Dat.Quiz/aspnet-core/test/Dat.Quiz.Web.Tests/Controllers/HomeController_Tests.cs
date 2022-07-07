using System.Threading.Tasks;
using Dat.Quiz.Models.TokenAuth;
using Dat.Quiz.Web.Controllers;
using Shouldly;
using Xunit;

namespace Dat.Quiz.Web.Tests.Controllers
{
    public class HomeController_Tests: QuizWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
