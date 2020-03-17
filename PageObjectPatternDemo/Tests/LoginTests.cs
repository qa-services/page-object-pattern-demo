using NUnit.Framework;
using PageObjectPatternDemo.Pages;

namespace PageObjectPatternDemo.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            var loginPage = new LoginPage(driver);
            loginPage.TypeEmail("test@test.com");
            loginPage.TypePassword("Test1!");
            var homePage = loginPage.Submit();
            homePage.AssertLogoutButtonIsDisplayed();
        }

        [Test]
        public void SuccessfulLoginTestWithChaining()
        {
            new LoginPage(driver)
                .TypeEmail("test@test.com")
                .TypePassword("Test1!")
                .Submit()
                .AssertLogoutButtonIsDisplayed();
        }
    }
}