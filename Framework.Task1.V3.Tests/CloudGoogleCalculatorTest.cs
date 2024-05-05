using Framework.Task1.V3.Pages;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Task1.V3.Tests
{
    internal class CloudGoogleCalculatorTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private readonly string searchText = "Google Cloud Platform Pricing Calculator";
        private readonly string numberOfInstances = "4";

        [SetUp]
        public void SetUp()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var browserName = builder["browser"];
            driver = WebDriverFactory.GetDriver(browserName);
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [Test]
        public void CloudGoogleCalculator()
        {
            MainPage mainPage = new(driver, wait);
            mainPage.Navigate();
            mainPage.Search(searchText);

            SearchResultPage searchResultPage = new(driver, wait);
            searchResultPage.ClickPricingCalculatorResult();

            CalculatorPage calculatorPage = new(driver, wait);
            calculatorPage.ClickAddToEstimateButton();
            calculatorPage.ClickComputeEngineButton();
            calculatorPage.SelectNumberOfInstances(numberOfInstances);
            calculatorPage.ExpandOperatingSystemDropdown();
            calculatorPage.SelectFreeDebianEtcOs();
            calculatorPage.SelectProvisioningModelRegular();
            calculatorPage.ExpandMachineFamilyDropDown();
            calculatorPage.SelectMachineFamilyGeneral();
            calculatorPage.ExpandSeriesDropdown();
            calculatorPage.SelectSeriesN1();
            calculatorPage.ExpandMachineTypeDropdown();
            calculatorPage.SelectN1Standard8();
            calculatorPage.ClickAddGpusButton();
            calculatorPage.ExpandGpuModelDropdown();
            calculatorPage.SelectTeslaV100Gpu();
            calculatorPage.ExpandNumberOfGpusDropdown();
            calculatorPage.SelectNumberOfGpus1();
            calculatorPage.ExpandLocalSsdDropdown();
            calculatorPage.SelectSsd2x375();
            calculatorPage.ExpandDatacenterLocationDropdown();
            calculatorPage.SelectDatacenterLocationJohanesburg();
            calculatorPage.SelectCommitedUsage1Year();

            Assert.IsTrue(calculatorPage.IsPriceCalculated());

            calculatorPage.ClickShareButton();
            string originalWindow = driver.CurrentWindowHandle;
            calculatorPage.ClickOpenEstimateSummaryButton();
            wait.Until(wd => wd.WindowHandles.Count == 2);
            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }

            //Not asserting all the fields, principle stays the same.
            //Feels like it is done another way...
            EstimateSummaryPage summaryPage = new(driver, wait);
            Assert.That(summaryPage.GetNumberOfInstances(), Is.EqualTo(numberOfInstances));
            Assert.That(summaryPage.GetOs(), Is.EqualTo("Free: Debian, CentOS, CoreOS, Ubuntu or BYOL (Bring Your Own License)"));
            Assert.That(summaryPage.GetProvisoningModel().ToLower(), Is.EqualTo("regular"));
            Assert.That(summaryPage.GetMachineType(), Is.EqualTo("n1-standard-8, vCPUs: 8, RAM: 30 GB"));
            Assert.That(summaryPage.GetGpuType(), Is.EqualTo("NVIDIA Tesla V100"));
            Assert.That(summaryPage.GetNumberOfGpus(), Is.EqualTo("1"));

        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.FailCount > 0)
            {
                Screenshot screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
                screenshot.SaveAsFile(Directory.GetCurrentDirectory());
            }
            driver.Quit();
        }
    }
}
