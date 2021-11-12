using Coypu;
using Coypu.Drivers.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotmartTest.Common
{
    public class BaseTeste
    {
        public BrowserSession browser;

        [SetUp]
        public void Setup()
        {
            var config = new SessionConfiguration
            {
                SSL = false,
                Driver = typeof(SeleniumWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome,
                Timeout = TimeSpan.FromSeconds(10),
            };

            browser = new BrowserSession(config);
            browser.MaximiseWindow();

        }

        [TearDown]
        public void Finish()
        {
            browser.Dispose();
        }
    }
}
