using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QAautomtest.NewFolder;

namespace QAautomtest
{
    public class Tests
    {
        IWebDriver driver;
        LoginPage login = new LoginPage();
        BillingPage billing = new BillingPage();
        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://qaauto.co.nz/billing-order-form/");
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void TearDown()
        {
             driver.Close();
             driver.Dispose();
        }
        [Test]
        public void Test1()
        {
            login.Login(driver);
            billing.Billing(driver);
        }
    }
}