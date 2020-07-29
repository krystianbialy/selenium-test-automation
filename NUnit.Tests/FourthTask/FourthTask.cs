using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Linq;
using System.Threading;
using Objects4;

namespace FourthTask
{
    [TestFixture]
    public class FourthTaskClass
    {
        public IWebDriver driver;
        private ObjectsClass4 obj;

        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            obj = new ObjectsClass4(driver);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com";

        }

        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void TestMethod()
        {
            obj.SearchInput.SendKeys("select html");
            Thread.Sleep(1000);
            obj.SearchInput.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            obj.Link.Click();
            Thread.Sleep(2000);
            for (int i = 0; i < 3; i++)
            {
                new Actions(driver).SendKeys(OpenQA.Selenium.Keys.ArrowDown).Perform();
            }
            Thread.Sleep(1000);
            obj.ButtonTry.Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.SwitchTo().Frame(obj.iframe);
            obj.Dropdown.Click();
            Thread.Sleep(1000);
            obj.DropdownItem.Click();
            Thread.Sleep(1000);
            obj.Submit.Click();
            Thread.Sleep(1000);
            Assert.That(obj.Result.Text.TrimEnd(' '), Is.EqualTo("cars=audi"));
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Close();
        }
    }
}