using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;

namespace TestWebApp
{
    [TestClass]
    public class VerifyShoppingCart
    {
        IWebDriver driver;
        string baseUrl = "https://app.qa.ordr.no/location/L3an5V40Apr";

        [TestInitialize]
        public void TestSetup()
        {
            //Open Browser
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);
        }
        [TestMethod]
        public void AddBurgerToShoppingCart()
        {
            //Add Burger to Shopping Cart and Checkout
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[1]/ion-content[1]/div[4]/div[1]/ion-button[3]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//ion-label/h4[text()='Burger']//parent::ion-label/following-sibling::div/div[2]/ion-button")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[2]/ion-content[1]/ion-grid[1]/ion-grid[1]/ion-radio-group[1]/ion-item[2]/ion-radio[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[2]/ion-content[1]/ion-grid[1]/ion-grid[2]/ion-item[2]/ion-checkbox[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[2]/ion-grid[1]/ion-row[1]/ion-button[2]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[2]/ion-content[1]/ion-grid[1]/ion-grid[6]/ion-radio-group[1]/ion-item[3]/ion-radio[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[2]/ion-grid[1]/ion-row[1]/ion-button[2]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//ion-button[contains(text(),'Til betaling')]")).Click();
            System.Threading.Thread.Sleep(1000);
            




        }

        [TestMethod]
        public void ProceedtoCheckOut()
        {

        }

        [TestCleanup]
        public void TestCleanUp()
        {
            //Close Browser
            driver.Quit();
        }
    }
}
