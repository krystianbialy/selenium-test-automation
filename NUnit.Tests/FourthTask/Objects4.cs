using OpenQA.Selenium;

namespace Objects4
{
    public class ObjectsClass4
    {
        private IWebDriver _driver;
        public ObjectsClass4(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SearchInput => _driver.FindElement(By.CssSelector("[title='Szukaj']"));
        public IWebElement Link => _driver.FindElement(By.ClassName("DKV0Md"));
        public IWebElement ButtonTry => _driver.FindElements(By.CssSelector(".w3-code+a"))[0];
        public IWebElement iframe => _driver.FindElement(By.Id("iframeResult"));
        public IWebElement Dropdown => _driver.FindElement(By.Id("cars"));
        public IWebElement DropdownItem => _driver.FindElement(By.CssSelector("[value='audi']"));
        public IWebElement Submit => _driver.FindElement(By.CssSelector("[value='Submit']"));
        public IWebElement Result => _driver.FindElements(By.CssSelector(".w3-container"))[1];
    }
}
