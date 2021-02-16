using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTestingProject
{
    public class AP_SigninPage
    {
        private IWebDriver _seleniumDriver;
        private string _signInPageUrl = AppConfigReader.SigninPageUrl;
        //since driver is not instatiated we cannot assign values so we use expression operator instead
        private IWebElement _emailBox => _seleniumDriver.FindElement(By.Id("email"));
        private IWebElement _passwordBox => _seleniumDriver.FindElement(By.Id("passwd"));
        private IWebElement _signInButton => _seleniumDriver.FindElement(By.Id("SubmitLogin"));
        public AP_SigninPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void VisitSignInPage() => _seleniumDriver.Navigate().GoToUrl(_signInPageUrl);
        public void SubmitEmailAndPassword(string email, string password)
        {
            _emailBox.SendKeys(email);
            _passwordBox.SendKeys(password);
        }

        public void ClickSubmit() => _signInButton.Click();

        public string GetErrorMessage() => _seleniumDriver.FindElement(By.ClassName("alert")).Text;

    }
}
