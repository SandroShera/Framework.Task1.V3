using Framework.Task1.V3.PageElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Task1.V3.Pages
{
    public class MainPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly string url = "https://cloud.google.com/";
        public MainPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        private MainPageElements Map
        {
            get
            {
                return new MainPageElements(wait);
            }
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Search(string text)
        {
            Map.SearchIcon.Click();
            Map.SearchInput.Clear();
            Map.SearchInput.SendKeys(text + Keys.Enter);
        }
    }
}
