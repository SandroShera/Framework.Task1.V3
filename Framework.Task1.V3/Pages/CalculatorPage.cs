using Framework.Task1.V3.PageElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Framework.Task1.V3.Pages
{
    public class CalculatorPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private Actions actions;

        public CalculatorPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            actions = new(this.driver);
        }

        private CalculatorPageElements Map
        {
            get
            {
                return new CalculatorPageElements(wait);
            }
        }

        public void ClickAddToEstimateButton()
        {
            Map.AddToEstimateButton.Click();
        }

        public void ClickComputeEngineButton()
        {
            Map.ComputeEngineButton.Click();
        }

        public void SelectNumberOfInstances(string numberOfInstances)
        {
            Map.NumberOfInstancesInput.Clear();
            Map.NumberOfInstancesInput.SendKeys(numberOfInstances);
        }

        public void ExpandOperatingSystemDropdown()
        {
            actions.MoveToElement(Map.OperatingSystemDropdown);
            actions.Perform();
            Map.OperatingSystemDropdown.Click();
        }

        public void SelectFreeDebianEtcOs()
        {
            Map.FreeDebianEtc.Click();
        }

        public void SelectProvisioningModelRegular()
        {
            actions.MoveToElement(Map.ProvisioningModelRegular);
            actions.Perform();
            Map.ProvisioningModelRegular.Click();
        }

        public void ExpandMachineFamilyDropDown()
        {
            actions.MoveToElement(Map.MachineFamilyDropDown);
            actions.Perform();
            Map.MachineFamilyDropDown.Click();
        }

        public void SelectMachineFamilyGeneral()
        {
            Map.MachineFamilyGeneral.Click();
        }

        public void ExpandSeriesDropdown()
        {
            actions.MoveToElement(Map.SeriesDropdown);
            actions.Perform();
            Map.SeriesDropdown.Click();
        }

        public void SelectSeriesN1()
        {
            Map.SeriesN1.Click();
        }

        public void ExpandMachineTypeDropdown()
        {
            actions.MoveToElement(Map.MachineTypeDropdown);
            actions.Perform();
            Map.MachineTypeDropdown.Click();
        }

        public void SelectN1Standard8()
        {
            Map.N1Standard8.Click();
        }

        public void ClickAddGpusButton()
        {
            actions.MoveToElement(Map.AddGpusButton);
            actions.Perform();
            Map.AddGpusButton.Click();
        }

        public void ExpandGpuModelDropdown()
        {
            actions.MoveToElement(Map.GpuModelDropdown);
            actions.Perform();
            Map.GpuModelDropdown.Click();
        }

        public void SelectTeslaV100Gpu()
        {
            Map.TeslaV100Gpu.Click();
        }

        public void ExpandNumberOfGpusDropdown()
        {
            actions.MoveToElement(Map.NumberOfGpusDropdown);
            actions.Perform();
            Map.NumberOfGpusDropdown.Click();
        }

        public void SelectNumberOfGpus1()
        {
            Map.NumberOfGpus1.Click();
        }

        public void ExpandLocalSsdDropdown()
        {
            actions.MoveToElement(Map.LocalSsdDropdown);
            actions.Perform();
            Map.LocalSsdDropdown.Click();
        }

        public void SelectSsd2x375()
        {
            Map.Ssd2x375.Click();
        }

        public void ExpandDatacenterLocationDropdown()
        {
            actions.MoveToElement(Map.DatacenterLocationDropdown);
            actions.Perform();
            Map.DatacenterLocationDropdown.Click();
        }

        public void SelectDatacenterLocationJohanesburg()
        {
            Map.DatacenterLocationJohanesburg.Click();
        }

        public void SelectCommitedUsage1Year()
        {
            actions.MoveToElement(Map.CommitedUsage1Year);
            actions.Perform();
            Map.CommitedUsage1Year.Click();
        }

        public bool IsPriceCalculated()
        {
            try
            {
                _ = Map.Price.Text;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void ClickShareButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", Map.ShareButton);
        }

        public void ClickOpenEstimateSummaryButton()
        {
            Map.OpenEstimateSummaryButton.Click();
        }
    }
}
