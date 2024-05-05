using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Framework.Task1.V3.PageElements
{
    public class EstimateSummaryPageElements
    {
        private readonly WebDriverWait wait;

        public EstimateSummaryPageElements(WebDriverWait wait)
        {
            this.wait = wait;
        }

        public IWebElement NumberOfInstances
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='yDmH0d']/c-wiz[1]//span[text() = 'Number of Instances']/following-sibling::span")));
            }
        }

        public IWebElement Os
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='yDmH0d']/c-wiz[1]//span[text() = 'Operating System / Software']/following-sibling::span")));
            }
        }

        public IWebElement ProvisioningModel
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]//span[text()='Provisioning Model']/following-sibling::span")));
            }
        }

        public IWebElement MachineType
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]//span[text()='Machine type']/following-sibling::span")));
            }
        }

        public IWebElement GpuType
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]//span[text() = 'GPU Model']/following-sibling::span")));
            }
        }

        public IWebElement NumberOfGpus
        {
            get
            {
                return wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]//span[text()='Number of GPUs']/following-sibling::span")));
            }
        }
    }
}
