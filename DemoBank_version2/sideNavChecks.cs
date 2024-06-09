namespace DemoBank_version2
{
    public class sideNavChecks
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void reachSite()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "--incognito");
            using IWebDriver driver = new ChromeDriver(options);
            {
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
                Assert.Equal("https://parabank.parasoft.com/parabank/index.htm", driver.Url);
            }

        }

        [Fact]
        [Trait("Category", "Navigation")]
        public void aboutPage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "--incognito");
            using IWebDriver driver = new ChromeDriver(options);
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
                Assert.Equal("https://parabank.parasoft.com/parabank/index.htm", driver.Url);

                IWebElement aboutLink = driver.FindElement(By.XPath("//*[@id=\"headerPanel\"]/ul[1]/li[2]/a"));
                aboutLink.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));

                IWebElement aboutLinkAgain = driver.FindElement(By.XPath("//*[@id=\"headerPanel\"]/ul[1]/li[2]/a"));
                aboutLinkAgain.Click(); 
                //driver.Manage().Cookies.AddCookie(new Cookie("Test", "123"));
                //var sessionID = driver.Manage().Cookies.GetCookieNamed("jsessionid").Value;
                // Fail Issue 1: URL upon page change via nav link adds session ID to the URL.
                // Cannot seem replicate this via manual checks. 
                Assert.Equal("https://parabank.parasoft.com/parabank/about.htm", driver.Url);
            }

        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void servicesPage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            using IWebDriver driver = new ChromeDriver(options);
            {
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
                Assert.Equal("https://parabank.parasoft.com/parabank/index.htm", driver.Url);

                IWebElement servicesLink = driver.FindElement(By.LinkText("Services"));
                servicesLink.Click();
                Thread.Sleep(3000);
                Assert.Equal("https://parabank.parasoft.com/parabank/services.htm", driver.Url);
            }

        }

    }
}