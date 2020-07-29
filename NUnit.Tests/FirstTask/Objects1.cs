using OpenQA.Selenium;

namespace Objects1
{
    public class ObjectsClass1
    {
        private IWebDriver _driver;
        public ObjectsClass1(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SearchInput => _driver.FindElement(By.CssSelector("[title='Szukaj']"));
        public IWebElement Link => _driver.FindElement(By.ClassName("ad_cclk"));
    }
}
