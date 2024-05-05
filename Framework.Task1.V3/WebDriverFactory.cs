using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Framework.Task1.V3
{
    public sealed class WebDriverFactory
    {
        private static IWebDriver? driver;

        private WebDriverFactory()
        {
        }

        public static IWebDriver GetDriver(string driverName)
        {
            if (driver is null)
            {
                switch (driverName.ToLower())
                {
                    case "firefox":
                        new DriverManager().SetUpDriver(new FirefoxConfig());
                        driver = new FirefoxDriver();
                        break;

                    case "ie":
                        new DriverManager().SetUpDriver(new InternetExplorerConfig());
                        driver = new InternetExplorerDriver();
                        break;

                    default:
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        driver = new ChromeDriver();
                        break;
                }
            }

            return driver;
        }
    }
}
