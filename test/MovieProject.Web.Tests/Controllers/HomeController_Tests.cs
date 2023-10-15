using System.Threading.Tasks;
using MovieProject.Models.TokenAuth;
using MovieProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace MovieProject.Web.Tests.Controllers
{
    public class HomeController_Tests: MovieProjectWebTestBase
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