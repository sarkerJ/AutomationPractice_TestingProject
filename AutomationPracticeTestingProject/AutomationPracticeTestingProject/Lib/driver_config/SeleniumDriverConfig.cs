using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeTestingProject
{
    // the , new() means tht the T we are passing through must be of a class that has a default constructor! e.g. classes with param constructors lose their default 1
    public class SeleniumDriverConfig<T> where T : IWebDriver, new()
    {
        //Property driver for later ise
        public IWebDriver Driver { get; set; }

        //constructor calls a method to set up the driver depending on the type of browser we want
        public SeleniumDriverConfig(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver = new T();
            DriverSetUp(pageLoadInSecs, implicitWaitInSecs);
        }

        //Driver instantiation manager
        public void DriverSetUp(int pageLoadInSecs, int implicitWaitInSecs)
        {
            SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
        }

        private void SetDriverConfiguration(int pageLoadInSecs, int implicitWaitInSecs)
        {
            //This is the time the driver will wait for the page to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            //This is the time driver waits for the element before the test fails
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }
    }
}
