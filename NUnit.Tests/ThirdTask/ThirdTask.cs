using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Objects3;

namespace ThirdTask
{
    [TestFixture]
    public class ThirdTaskClass
    {
        public IWebDriver driver;
        private ObjectsClass3 obj;

        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            obj = new ObjectsClass3(driver);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.gmail.com";
        }

        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }

        [Test]
        public void TestMethod()
        {
            obj.Login.SendKeys("your email / phone");
            Thread.Sleep(1000);
            obj.NextButton.Click();
            Thread.Sleep(5000);
            obj.Password.SendKeys("your password");
            Thread.Sleep(1000);
            obj.NextButton.Click();
            Thread.Sleep(6000);
            obj.Profile.Click();
            Thread.Sleep(1000);
            obj.Logout.Click();
        }
    }
}
