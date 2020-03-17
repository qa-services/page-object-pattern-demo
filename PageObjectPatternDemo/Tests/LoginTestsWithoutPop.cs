using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectPatternDemo.Tests
{
    public class LoginTestsWithoutPop
    {
        [Test]
        public void LoginTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://qa-services.github.io/simple-test-page/login.html");

            IWebElement txtEmail = driver.FindElement(By.CssSelector("#email"));
            txtEmail.SendKeys("test@test.com");

            IWebElement txtPassword = driver.FindElement(By.CssSelector("#password"));
            txtPassword.SendKeys("Test1!");

            IWebElement btnLogin = driver.FindElement(By.CssSelector("#sign-in"));
            btnLogin.Click();

            IWebElement btnLogout = driver.FindElement(By.CssSelector("#logout"));
            Assert.IsTrue(btnLogout.Displayed, "Check if logout button is displayed");

            driver.Quit();
        }
    }
}