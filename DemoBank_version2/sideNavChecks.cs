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
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
                Assert.Equal("https://parabank.parasoft.com/parabank/index.htm", driver.Url);
            }

        }

        [Fact]
        [Trait("Category", "Nav")]
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
                Assert.Equal("https://parabank.parasoft.com/parabank/about.htm", driver.Url);
            }

        }

        [Fact]
        [Trait("Category", "Nav")]
        public void servicesPage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            using IWebDriver driver = new ChromeDriver(options);
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
                Assert.Equal("https://parabank.parasoft.com/parabank/index.htm", driver.Url);

                IWebElement servicesLink = driver.FindElement(By.LinkText("Services"));
                servicesLink.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                IWebElement servicesLinkAgain = driver.FindElement(By.LinkText("Services"));
                servicesLinkAgain.Click();
                Assert.Equal("https://parabank.parasoft.com/parabank/services.htm", driver.Url);
            }

        }

        [Fact]
        [Trait("Category", "Nav")]
        public void adminPage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            using IWebDriver driver = new ChromeDriver(options);
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
                Assert.Equal("https://parabank.parasoft.com/parabank/index.htm", driver.Url);

                IWebElement adminLink = driver.FindElement(By.LinkText("Admin Page"));
                adminLink.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                IWebElement adminLinkAgain = driver.FindElement(By.LinkText("Admin Page"));
                adminLinkAgain.Click();
                Assert.Equal("https://parabank.parasoft.com/parabank/admin.htm", driver.Url);
            }

        }

    }

    public class UIChecks
    {
        [Fact]
        [Trait("Category", "UI")]
        public void landingPageUIChecks()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "--incognito");
            using IWebDriver driver = new ChromeDriver(options);
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
                Assert.Equal("https://parabank.parasoft.com/parabank/index.htm", driver.Url);

                IWebElement headerPanel = driver.FindElement(By.Id("headerPanel"));
                Assert.True(headerPanel.Displayed);
                //simple assertion to see if header is visible
                //will probably consider another assertion to check if correct image
                //also considering writing for loop on header button to check if correct number of button visible
            }

        }
    }
}