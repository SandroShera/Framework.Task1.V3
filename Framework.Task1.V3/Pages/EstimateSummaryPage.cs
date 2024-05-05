using Framework.Task1.V3.PageElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Framework.Task1.V3.Pages
{
    public class EstimateSummaryPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private Actions actions;

        public EstimateSummaryPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            actions = new(this.driver);
        }

        private EstimateSummaryPageElements Map
        {
            get
            {
                return new EstimateSummaryPageElements(wait);
            }
        }

        public string GetNumberOfInstances()
        {
            actions.MoveToElement(Map.NumberOfInstances);
            actions.Perform();
            return Map.NumberOfInstances.Text;
        }

        public string GetOs()
        {
            actions.MoveToElement(Map.Os);
            actions.Perform();
            return Map.Os.Text;
        }

        public string GetProvisoningModel()
        {
            actions.MoveToElement(Map.ProvisioningModel);
            actions.Perform();
            return Map.ProvisioningModel.Text;
        }

        public string GetMachineType()
        {
            actions.MoveToElement(Map.MachineType);
            actions.Perform();
            return Map.MachineType.Text;
        }

        public string GetGpuType()
        {
            actions.MoveToElement(Map.GpuType);
            actions.Perform();
            return Map.GpuType.Text;
        }

        public string GetNumberOfGpus()
        {
            actions.MoveToElement(Map.NumberOfGpus);
            actions.Perform();
            return Map.NumberOfGpus.Text;
        }
    }
}
