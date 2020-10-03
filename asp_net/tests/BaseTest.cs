using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asp_net.serializing;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace asp_net.tests
{
    public class BaseTest
    {
       
        protected IWebDriver driver;
        protected EnvironmentConstant environmentConstant;
     //  protected MainMenuPageObject mainMenu;


        [OneTimeSetUp]
        protected void BeforeAllTests()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-fullscreen");
            driver = new ChromeDriver(chromeOptions);
            //    mainMenu = new MainMenuPageObject(driver);

           
        }

        private void InitializeData()
        {
            new EnvironmentConstantProvider().Provide(out EnvironmentConstant environmentConstantObject);
            environmentConstant = environmentConstantObject;
        }


        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("https://localhost:5001");
        }

        [Test]
        public void TestMethod1()
        {
      
            Serialize test = new Serialize();
            test.Login();
            InitializeData();
        }
          

        [OneTimeTearDown]
        public void QuitDriver()
        {
            if (driver != null)
                driver.Quit();
        }

     


    }
}
