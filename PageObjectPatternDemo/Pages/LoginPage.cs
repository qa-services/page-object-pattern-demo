using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace PageObjectPatternDemo.Pages
{
    partial class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement TxtEmail => driver.FindElement(By.CssSelector("#email"));
        private IWebElement TxtPassword => driver.FindElement(By.CssSelector("#password"));
        private IWebElement BtnLogin => driver.FindElement(By.CssSelector("#sign-in"));
        private IWebElement ElmError => driver.FindElement(By.CssSelector(".errors-container>h4"));


        public LoginPage TypeEmail(string email)
        {
            TxtEmail.Clear();
            TxtEmail.SendKeys(email);

            return this;
        }

        public LoginPage TypePassword(string password)
        {
            TxtPassword.Clear();
            TxtPassword.SendKeys(password);

            return this;
        }

        public LoginPage SubmitWithFailure()
        {
            BtnLogin.Click();

            return this;
        }

        public HomePage Submit()
        {
            BtnLogin.Click();

            return new HomePage(driver);
        }

        public HomePage Login(string email, string password)
        {
            TypeEmail(email);
            TypePassword(password);
            BtnLogin.Click();

            return new HomePage(driver);
        }

        public LoginPage AssertLoginErrorIsDisplayed(string expError)
        {
            Assert.IsTrue(ElmError.Displayed, "Check whether error is shown.");
            Assert.AreEqual(expError, ElmError.Text, "Check error text.");

            return this;
        }
    }
}
