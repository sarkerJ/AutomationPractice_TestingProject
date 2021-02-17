using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTestingProject
{
    //Controller class through which we can control our POMs
    public class AP_Website<T> where T : IWebDriver, new()
    {
        //Accessible Page Objects
        public IWebDriver SeleniumDriver { get; internal set; }
        public AP_HomePage AP_HomePage { get; internal set; }
        public AP_SigninPage AP_SigninPage { get; internal set; }
        public AP_DressesPage AP_DressesPage { get; internal set; }
        public AP_CreateAccountPage AP_CreateAccountPage { get; internal set; }

        //Constructor for driver and condig for the service
        public AP_Website(int pageLoadInSecs = 10, int implicitWaitInSecs = 10)
        {
            //intantiate the driver
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInSecs, implicitWaitInSecs).Driver;

            //instantiate our page ojects with the selenium driver
            AP_HomePage = new AP_HomePage(SeleniumDriver);
            AP_SigninPage = new AP_SigninPage(SeleniumDriver);
            AP_DressesPage = new AP_DressesPage(SeleniumDriver);
            AP_CreateAccountPage = new AP_CreateAccountPage(SeleniumDriver);
        }

        //delete cookies (optional)
        public void DeleteCookies() => SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        public string GetPageTitle() => SeleniumDriver.Title;

    }
}
