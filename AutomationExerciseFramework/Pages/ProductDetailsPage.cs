using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExerciseFramework.Pages
{
    class ProductDetailsPage
    {
        readonly IWebDriver _driver;
        public By page = By.ClassName("product-details");
        public By addBtn = By.CssSelector(".product-information .btn");
        public By viewCart = By.XPath("//*[@id='cartModal']//a");
        public By prodName = By.XPath("//*[@class='product-information']//h2");

        public ProductDetailsPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(page));
        }
    }
}
