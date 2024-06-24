using System.Security.Cryptography.X509Certificates;

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

                driver.FindElement(By.XPath("//*[@id=\"headerPanel\"]/ul[1]/li[2]/a")).Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                driver.FindElement(By.XPath("//*[@id=\"headerPanel\"]/ul[1]/li[2]/a")).Click(); 
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

                driver.FindElement(By.LinkText("Services")).Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                driver.FindElement(By.LinkText("Services")).Click();
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

                driver.FindElement(By.LinkText("Admin Page")).Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                driver.FindElement(By.LinkText("Admin Page")).Click();
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

        [Fact]
        [Trait("Category", "UI")]
        public void aboutUsUIChecks()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "--incognito");
            using IWebDriver driver = new ChromeDriver(options);
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
                Assert.Equal("https://parabank.parasoft.com/parabank/index.htm", driver.Url);

                driver.FindElement(By.XPath("//*[@id=\"headerPanel\"]/ul[1]/li[2]/a")).Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                driver.FindElement(By.XPath("//*[@id=\"headerPanel\"]/ul[1]/li[2]/a")).Click();
                Assert.Equal("https://parabank.parasoft.com/parabank/about.htm", driver.Url);

                IWebElement titleText = driver.FindElement(By.TagName("h1"));
                IList<IWebElement> pageText = driver.FindElements(By.TagName("p"));
                foreach (IWebElement element in pageText)
                {
                    Assert.True(element.Displayed);
                }

                IWebElement bodytext = driver.FindElement(By.Id("rightPanel"));
                Assert.Contains("ParaBank is a demo site used for demonstration of Parasoft software solutions.\r\nAll materials herein are used solely for simulating a realistic online banking website.", bodytext.Text);
                Assert.Contains("In other words: ParaBank is not a real bank!", bodytext.Text);
                Assert.Contains("For more information about Parasoft solutions please visit us at:\r\nwww.parasoft.com or call 888-305-0041", bodytext.Text);


                //simple assertion to see if all p tag text is visible
                //will write assertion that checks paragraphs in displaying right text
            }

        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void test()
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
        [Trait("Category", "Smoke")]
        public void test2()
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


    }
}
