using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Objects2;

namespace SecondTask
{
    [TestFixture]
    public class SecondTaskClass
    {
        public IWebDriver driver;
        private ObjectsClass2 obj;

        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            obj = new ObjectsClass2(driver);
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
            obj.GoogleAplicationButton.Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Frame(0);
            obj.GoogleTranslateButton.Click();
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            obj.LanguagePL.Click();
            obj.LanguageEN.Click();
            Thread.Sleep(1000);
            obj.LeftTranslateTextarea.SendKeys("Mediaexpert jest fajne");
            Thread.Sleep(1000);
            Assert.That(obj.RightTranslateTextarea.Text, Is.EqualTo("Mediaexpert is fun"));
        }
    }
}
