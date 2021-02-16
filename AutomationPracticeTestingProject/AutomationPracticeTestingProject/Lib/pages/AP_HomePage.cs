using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTestingProject
{
    public class AP_HomePage
    {
        private IWebDriver _seleniumDriver;
        //Set the homepageurl
        private string _homePageUrl = AppConfigReader.BaseUrl;
        //Create a private property that models the sign in link
        // the reason we did => instead of = is because seleniumDriver is not instantiated and if it is we would have to make it static which means it would keep constant values tht we dont need
        private IWebElement _signInLink => _seleniumDriver.FindElement(By.LinkText("Sign in"));
        public AP_HomePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void VisitHomePage() => _seleniumDriver.Navigate().GoToUrl(_homePageUrl);
        public void VisitSignInPage() => _signInLink.Click();


    }
}
