using NUnit.Framework;
using PageObjectPatternDemo.Pages;

namespace PageObjectPatternDemo.Tests
{
    public class LoginTestsWithChaining : BaseTest
    {
        [Test]
        public void SuccessfulLoginTestWithChaining()
        {
            new LoginPage(driver)
                .TypeEmail("test@test.com")
                .TypePassword("Test1!")
                .Submit()
                    .AssertLogoutButtonIsDisplayed();
        }

        [Test]
        public void NegativeLoginTestWithChaining()
        {
            new LoginPage(driver)
                .TypeEmail("test@test.com")
                .SubmitWithFailure()
                    .AssertLoginErrorIsDisplayed("Invalid login attempt.");
        }
    }
}