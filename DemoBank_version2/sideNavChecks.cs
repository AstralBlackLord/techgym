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
        [Trait("Category", "Smoke")]
        public void aboutPage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "--incognito");
            using IWebDriver driver = new ChromeDriver(options);
            {
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
                Assert.Equal("https://parabank.parasoft.com/parabank/index.htm", driver.Url);

                IWebElement aboutLink = driver.FindElement(By.LinkText("About Us"));
                aboutLink.Click();
                Thread.Sleep(3000);
                Assert.Equal("https://parabank.parasoft.com/parabank/about.htm", driver.Url);
            }

        }

    }
}