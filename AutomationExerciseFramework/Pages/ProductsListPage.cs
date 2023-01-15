using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExerciseFramework.Pages
{
    class ProductsListPage
    {
        readonly IWebDriver _driver;
        public By page = By.Id("advertisement");
        public By searchField = By.Id("search_product");
        public By searchLoop = By.Id("submit_search");
        public By viewProduct = By.ClassName("fa-plus-square");

        public ProductsListPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(page));
        }
    }
}
