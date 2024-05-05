using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Framework.Task1.V3.PageElements;

namespace Framework.Task1.V3.Pages
{
    public class SearchResultPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public SearchResultPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        private SearchResultPageElements Map
        {
            get
            {
                return new SearchResultPageElements(wait);
            }
        }

        public void ClickPricingCalculatorResult()
        {
            Map.GooglecloudPricingCalculator.Click();
        }
    }
}
