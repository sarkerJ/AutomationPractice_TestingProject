using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;

namespace AutomationPracticeTestingProject
{
    public class AP_CreateAccountPage
    {
        private IWebDriver _seleniumDriver;
        private string _signinPageUrl = AppConfigReader.SigninPageUrl;

        private IWebElement _emailCreate => _seleniumDriver.FindElement(By.Id("email_create"));
        private IWebElement _createAccountBtn => _seleniumDriver.FindElement(By.Id("SubmitCreate"));
        private IWebElement _pageHeading => _seleniumDriver.FindElement(By.ClassName("page-heading"));

        private IWebElement _male => _seleniumDriver.FindElement(By.Id("id_gender1"));
        private IWebElement _female => _seleniumDriver.FindElement(By.Id("id_gender2"));
        private IWebElement _fName => _seleniumDriver.FindElement(By.Id("customer_firstname"));
        private IWebElement _lName => _seleniumDriver.FindElement(By.Id("customer_lastname"));
        private IWebElement _password => _seleniumDriver.FindElement(By.Id("passwd"));
        private IWebElement _dobDays => _seleniumDriver.FindElement(By.Id("days"));
        private IWebElement _dobMonths => _seleniumDriver.FindElement(By.Id("months"));
        private IWebElement _dobYears => _seleniumDriver.FindElement(By.Id("years"));
        private IWebElement _company => _seleniumDriver.FindElement(By.Id("company"));
        private IWebElement _address => _seleniumDriver.FindElement(By.Id("address1"));
        private IWebElement _city => _seleniumDriver.FindElement(By.Id("city"));
        private IWebElement _state => _seleniumDriver.FindElement(By.Id("id_state"));
        private IWebElement _zip => _seleniumDriver.FindElement(By.Id("postcode"));
        private IWebElement _country => _seleniumDriver.FindElement(By.Id("id_country"));
        private IWebElement _phone => _seleniumDriver.FindElement(By.Id("phone"));
        private IWebElement _mobile => _seleniumDriver.FindElement(By.Id("phone_mobile"));
        private IWebElement _register => _seleniumDriver.FindElement(By.Id("submitAccount"));

        public AP_CreateAccountPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void VisitSigninPage()
        {
            _seleniumDriver.Navigate().GoToUrl(_signinPageUrl);
            _seleniumDriver.Manage().Window.Maximize();
        }
        public void CreateAndSubmitEmail(string email)
        {
            _emailCreate.SendKeys(email);
            _createAccountBtn.Click();
        }

        public string HeaderText() => _pageHeading.Text;


        public void PopulateFields(Credentials defaultValues)
        {

            if (defaultValues.Gender == Gender.male) _male.Click();
            else _female.Click();

            _fName.SendKeys(defaultValues.FirstName);
            _lName.SendKeys(defaultValues.LastName);
            _password.SendKeys(defaultValues.Password);
            _address.SendKeys(defaultValues.Address);
            _city.SendKeys(defaultValues.City);
            _state.SendKeys(defaultValues.State);
            _zip.SendKeys(defaultValues.Postcode);
            _phone.SendKeys(defaultValues.HomePhone);
            _mobile.SendKeys(defaultValues.MobilePhone);

        }

        public void ClickRegister() => _register.Click();
        public string GetErrorMessage() => _seleniumDriver.FindElement(By.ClassName("alert")).Text;

    }
}
