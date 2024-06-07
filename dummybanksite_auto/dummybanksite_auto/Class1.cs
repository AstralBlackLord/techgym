using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace dummybanksite_auto
{
    public class navChecks
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void reachSite()
        {
            using ChromeDriver driver = new ChromeDriver();
            {
                driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
                Assert.Equal("https://parabank.parasoft.com/parabank/index.htm", driver.Url);
            }

        }
        
    }
}