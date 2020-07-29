using OpenQA.Selenium;

namespace Objects2
{
    public class ObjectsClass2
    {
        private IWebDriver _driver;
        public ObjectsClass2(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement GoogleAplicationButton => _driver.FindElement(By.CssSelector("[title='Aplikacje Google']"));
        public IWebElement GoogleTranslateButton => _driver.FindElement(By.CssSelector("a[href='https://translate.google.pl/?hl=pl&tab=wT']"));
        public IWebElement LanguagePL => _driver.FindElement(By.CssSelector(".sl-sugg #sugg-item-pl"));
        public IWebElement LanguageEN => _driver.FindElement(By.CssSelector(".tl-sugg #sugg-item-en"));
        public IWebElement LeftTranslateTextarea => _driver.FindElement(By.Id("source"));
        public IWebElement RightTranslateTextarea => _driver.FindElement(By.CssSelector(".translation span"));
    }
}
