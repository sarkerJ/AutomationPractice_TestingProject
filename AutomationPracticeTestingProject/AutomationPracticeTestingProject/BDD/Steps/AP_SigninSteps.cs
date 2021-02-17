using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutomationPracticeTestingProject.BDD
{
    [Binding]
    public class AP_SigninSteps
    {
        public AP_Website<ChromeDriver> AP_Website;

        [BeforeScenario("@Signin")]
        public void Method()
        {
            AP_Website = new AP_Website<ChromeDriver>();
        }

        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
        }

        [Given(@"I have entered an  (.*) and a (.*)")]
        public void GivenIHaveEnteredAnAndA(string email, string password)
        {
            AP_Website.AP_SigninPage.SubmitEmailAndPassword(email, password);
        }

        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            AP_Website.AP_SigninPage.ClickSubmit();
        }

        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string expected)
        {
            Thread.Sleep(2000);
            Assert.That(AP_Website.AP_SigninPage.GetErrorMessage().Contains(expected));
        }

        [Then(@"I should see a page with the title ""(.*)""")]
        public void ThenIShouldSeeAPageWithTheTitle(string expected)
        {
            Thread.Sleep(3000);
            Assert.That(AP_Website.SeleniumDriver.Title, Is.EqualTo(expected));
        }


        [AfterScenario("@Signin")]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
