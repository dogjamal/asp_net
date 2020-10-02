using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace asp_net.tests
{
    public class BaseTest
    {
       
            public IWebDriver driver;

            public TestContext TestContext { get; set; }

         //   [TestInitialize]
         [OneTimeSetUp]
            public void CreateDriver()
            {
                driver = new ChromeDriver();
            }

          //  [TestCleanup]
          [OneTimeTearDown]
            public void QuitDriver()
            {
                if (driver != null)
                    driver.Quit();
            }
    }
}
