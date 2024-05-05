using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Framework.Task1.V3.PageElements
{
    public class MainPageElements
    {
        private readonly WebDriverWait wait;

        public MainPageElements(WebDriverWait wait)
        {
            this.wait = wait;
        }

        public IWebElement SearchIcon
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"kO001e\"]/div[2]/div[1]/div/div[2]/div[2]/div[1]/div/div")));
            }
        }

        public IWebElement SearchInput
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"i4\"]")));
            }
        }
    }
}
