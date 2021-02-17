using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutomationPracticeTestingProject.BDD
{
    [Binding]
    public class AP_AccountCreateSteps
    {
        public AP_Website<ChromeDriver> AP_Website;
        public Credentials credentials = new Credentials();
        private static Random rand = new Random();

        [BeforeScenario("@CreateAccount")]
        public void Method()
        {
            AP_Website = new AP_Website<ChromeDriver>();
        }

        [Given(@"I am on the SigninPage")]
        public void GivenIAmOnTheSigninPage()
        {
            AP_Website.AP_CreateAccountPage.VisitSigninPage();
        }

        [When(@"I enter an email ""(.*)""")]
        public void WhenIEnterAnEmail(string email)
        {
            AP_Website.AP_CreateAccountPage.CreateAndSubmitEmail(email);
        }

        [When(@"I enter an email")]
        public void WhenIEnterAnEmail()
        {
            AP_Website.AP_CreateAccountPage.CreateAndSubmitEmail($"testi{rand.Next()}@test.com");
            Thread.Sleep(5000);
        }

        [When(@"I click register")]
        public void WhenIClickRegister()
        {
            AP_Website.AP_CreateAccountPage.ClickRegister();
            Thread.Sleep(3000);
        }



        [Then(@"the result I should see an alert with a message ""(.*)""")]
        public void ThenTheResultIShouldSeeAnAlertWithAMessage(string expected)
        {
            Thread.Sleep(5000);
            Assert.That(AP_Website.AP_CreateAccountPage.GetErrorMessage(), Does.Contain(expected));
        }

        [When(@"I populate the required fields")]
        public void WhenIPopulateTheRequiredFields()
        {
            AP_Website.AP_CreateAccountPage.PopulateFields(credentials);
        }


        [Then(@"I should see ""(.*)"" page")]
        public void ThenIShouldSeePage(string createAccount)
        {
            Assert.That(AP_Website.AP_CreateAccountPage.HeaderText, Is.EqualTo(createAccount));
        }



        [AfterScenario("@CreateAccount")]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
