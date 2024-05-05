using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Framework.Task1.V3.PageElements
{
    public class SearchResultPageElements
    {
        private readonly WebDriverWait wait;

        public SearchResultPageElements(WebDriverWait wait)
        {
            this.wait = wait;
        }

        public IWebElement GooglecloudPricingCalculator
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[2]/div/div/div/div/div/div[3]/c-wiz/div[1]/div[1]/div/div[1]/a[text() = 'Google Cloud Pricing Calculator' ]")));
            }
        }
    }
}
