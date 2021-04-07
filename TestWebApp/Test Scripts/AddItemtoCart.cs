using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using System.Threading;

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
            //OpenBrowser
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);

        }
        [TestMethod]
        public void AddBurgerToShoppingCart()
        {
            //Add Burger to Shopping Cart and Checkout
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[1]/ion-content[1]/div[4]/div[1]/ion-button[3]")).Click();//Select Burger Menu
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//ion-label/h4[text()='Burger']//parent::ion-label/following-sibling::div/div[2]/ion-button")).Click();//Select Burger Item and add 1 Burger
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[2]/ion-content[1]/ion-grid[1]/ion-grid[1]/ion-radio-group[1]/ion-item[2]/ion-radio[1]")).Click();//Opt for 300g Burger
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[2]/ion-content[1]/ion-grid[1]/ion-grid[2]/ion-item[2]/ion-checkbox[1]")).Click();//Select Sylteagurk blæh 2
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[2]/ion-grid[1]/ion-row[1]/ion-button[2]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[2]/ion-content[1]/ion-grid[1]/ion-grid[6]/ion-radio-group[1]/ion-item[3]/ion-radio[1]")).Click(); // Add Tomataer
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//body/div[@id='root']/ion-app[1]/ion-router-outlet[1]/div[2]/ion-grid[1]/ion-row[1]/ion-button[2]")).Click(); // Add to Cart
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//ion-button[contains(text(),'Til betaling')]")).Click(); // Go to Payment
            System.Threading.Thread.Sleep(1000);

            Assert.AreEqual("Burger", driver.FindElement(By.XPath("//div[contains(text(),'Burger')]")).Text);
            Assert.AreEqual("300 gr", driver.FindElement(By.XPath("//ion-col[contains(text(),'300 gr')]")).Text);
            Assert.AreEqual("Sylteagurk blæh 2", driver.FindElement(By.XPath("//ion-col[contains(text(),'Sylteagurk blæh 2')]")).Text);
            Assert.AreEqual("Tomater", driver.FindElement(By.XPath("//ion-col[contains(text(),'Tomater')]")).Text);


        }

        [TestCleanup]
        public void CleanUpTask()
        {
            driver.Quit();
        }
    }
}
