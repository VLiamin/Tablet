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

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}