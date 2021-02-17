using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutomationPracticeTestingProject.BDD
{
    [Binding]
    public class AP_DressesSteps
    {
        public AP_Website<ChromeDriver> AP_Website;

        [BeforeScenario("@Dresses")]
        public void Method()
        {
            AP_Website = new AP_Website<ChromeDriver>();
        }

        [Given(@"I am on the dresses page")]
        public void GivenIAmOnTheDressesPage()
        {
            AP_Website.AP_DressesPage.VisitDressesPage();
        }

        [When(@"I add (.*) product to cart")]
        public void WhenIAddProductToCart(int value)
        {
            AP_Website.AP_DressesPage.HoverOverElementInCollection(value);
            AP_Website.AP_DressesPage.AddProductToCart();
        }

        [When(@"I click continue shopping on the PopUp")]
        public void WhenIClickContinueShoppingOnThePopUp()
        {
            AP_Website.AP_DressesPage.continueShopping();
        }

        [When(@"I click proceed to checkout on the PopUp")]
        public void WhenIClickProceedToCheckoutOnThePopUp()
        {
            AP_Website.AP_DressesPage.proceedWithCheckout();
        }

        [Then(@"I should see a PopUp confirmation")]
        public void ThenIShouldSeeAPopUpConfirmation()
        {
            Thread.Sleep(5000);
            Assert.That(AP_Website.AP_DressesPage.ClearFixIsDisplayed);
        }

        [Then(@"I should see the dressespage with the title ""(.*)""")]
        public void ThenIShouldSeeTheDressespageWithTheTitle(string expected)
        {
            //var x = AP_Website.GetPageTitle();
            Assert.That(AP_Website.GetPageTitle(), Is.EqualTo(expected));
        }


        [Then(@"I should see the total price ""(.*)""")]
        public void ThenIShouldSeeTheTotalPrice(string expected)
        {
            Assert.That(AP_Website.AP_DressesPage.GetTotalPrice, Is.EqualTo(expected));
        }



        [AfterScenario("@Dresses")]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();

        }
    }
}
