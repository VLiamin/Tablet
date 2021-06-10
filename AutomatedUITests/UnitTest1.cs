using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomatedUITests
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:44351/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Assert.IsNotNull(driver.Title);
        }

        [Test]
        public void Test3()
        {
            By by = By.XPath("//a[text()='Добавить проект']");
            Assert.IsNotNull(driver.FindElement(by));
        }
    }
}