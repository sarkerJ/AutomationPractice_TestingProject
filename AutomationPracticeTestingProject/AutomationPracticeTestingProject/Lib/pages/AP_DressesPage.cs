using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace AutomationPracticeTestingProject
{
    public class AP_DressesPage
    {
        private IWebDriver _seleniumDriver;
        private string _dressesPageUrl = AppConfigReader.DressesPageUrl;
        private ReadOnlyCollection<IWebElement> _listOfProductContainers => _seleniumDriver.FindElements(By.ClassName("product-container"));
        private IWebElement _confirmationPopUp => _seleniumDriver.FindElement(By.ClassName("clearfix"));
        private IWebElement _addToCart => _seleniumDriver.FindElement(By.LinkText("Add to cart"));
        private IWebElement _clearFixPopUpContinue => _seleniumDriver.FindElement(By.CssSelector(".continue > span"));
        private IWebElement _clearFixPopUpCheckOut => _seleniumDriver.FindElement(By.LinkText("Proceed to checkout"));
        private IWebElement _totalPrice => _seleniumDriver.FindElement(By.Id("total_price"));
        public AP_DressesPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public string GetTotalPrice() => _totalPrice.Text;
        public bool ClearFixIsDisplayed() => _confirmationPopUp.Displayed;

        public void VisitDressesPage()
        {
            _seleniumDriver.Navigate().GoToUrl(_dressesPageUrl);
            _seleniumDriver.Manage().Window.Maximize();
        }
        //Hover over a specific product to see the options
        public void HoverOverElementInCollection(int index)
        {
            Actions action = new Actions(_seleniumDriver);
            action.MoveToElement(_listOfProductContainers[index]).Perform();
        }
        //Click add to cart and then click continue
        public void AddProductToCart() => _addToCart.Click();
        public void continueShopping() => _clearFixPopUpContinue.Click();
        public void proceedWithCheckout() => _clearFixPopUpCheckOut.Click();

        //Click add to cart and then checkout
        public void AddProductToCartAndCheckOut() => _addToCart.Click();

    }
}
