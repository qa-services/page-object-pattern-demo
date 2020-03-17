using NUnit.Framework;
using PageObjectPatternDemo.Pages;

namespace PageObjectPatternDemo.Tests
{
    public class NegativeLoginTests : BaseTest
    {
        [Test]
        public void NegativeLoginTest()
        {
            var loginPage = new LoginPage(driver);
            loginPage.TypeEmail("test@test.com");
            loginPage.SubmitWithFailure();
            loginPage.AssertLoginErrorIsDisplayed("Invalid login attempt.");
        }
    }
}