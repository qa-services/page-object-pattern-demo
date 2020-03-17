using NUnit.Framework;
using OpenQA.Selenium;

namespace PageObjectPatternDemo.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement BtnLogout => driver.FindElement(By.CssSelector("#logout"));


        public HomePage AssertLogoutButtonIsDisplayed()
        {
            Assert.IsTrue(BtnLogout.Displayed, "Check whether logout button is shown.");
            return this;
        }
    }
}
