using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Objects1;

namespace FirstTask
{
    [TestFixture]
    public class FirstTaskClass
    {
        public IWebDriver driver;
        private ObjectsClass1 obj;

        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            obj = new ObjectsClass1(driver);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com";
        }

        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(1000);
            driver.Quit();
        }

        [Test]
        public void TestMethod()
        {
            obj.SearchInput.SendKeys("mediaexpert");
            Thread.Sleep(1000);
            obj.SearchInput.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            obj.Link.Click();
            Thread.Sleep(1000);
            Assert.That(driver.Url, Does.Contain("https://www.mediaexpert.pl"));
        }
    }
}

