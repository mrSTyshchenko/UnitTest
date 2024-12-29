using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace ZyiaUiTest
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://homePage");

            var loginPage = new LoginPage(driver);
            loginPage.ClickLogInButton("test", "test");


            Assert.Pass();
        }

        [TearDown]
        public void TearDown() {
            driver.Quit();
            driver.Dispose();
            }
    }
}