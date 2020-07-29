using NUnit.Framework;
using OpenQA.Selenium;

namespace Objects3
{
    [TestFixture]
    public class ObjectsClass3
    {
        private IWebDriver _driver;
        public ObjectsClass3(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Login => _driver.FindElement(By.CssSelector("[type='email']"));
        public IWebElement NextButton => _driver.FindElement(By.ClassName("VfPpkd-RLmnJb"));
        public IWebElement Password => _driver.FindElement(By.CssSelector("[type='password']"));
        public IWebElement Profile => _driver.FindElement(By.ClassName("gb_Ua"));
        public IWebElement Logout => _driver.FindElement(By.ClassName("gb_Lb"));
    }
}
