using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace asp_net
{
    public class authorizationPage
    {
        // IWebDriver browser;
        //  IWebElement click_ob;
        //  IWebElement Search;

        /*
      private readonly By _loginInputButton = By.CssSelector("username");
       private readonly By _continueButton = By.CssSelector("continue");
       private readonly By _passwordInputButton = By.CssSelector("password");
        private readonly By _enterButton = By.CssSelector("enter");
       private readonly By _phoneNumberInputButton = By.CssSelector("phone");
        */

        public authorizationPage(IWebDriver webDriver)
        {
        //   _webDriver = webDriver;

        /*
        browser = new OpenQA.Selenium.Chrome.ChromeDriver();
        browser.Manage().Window.Maximize();

        browser.Navigate().GoToUrl("http://google.com");

        Search = browser.FindElement(By.Name("q"));
        Search.SendKeys("qa testing" + OpenQA.Selenium.Keys.Enter);

        // open "Картинки"
        click_ob = browser.FindElement(By.LinkText("Картинки"));
        click_ob.Click();
    
         */
        }
        /*
            public MainMenuPage CreateNewUser(string mail, string password, string phoneNumber)
            {
                WaitUntil.WaitElement(_webDriver, _loginInputButton);
                _webDriver.FindElement(_loginInputButton).SendKeys(mail);
                _webDriver.FindElement(_continuetButton).Click();
                WaitUntil.WaitElement(_webDriver, _passwordInputButton);
                _webDriver.FindElement(_passwordInputButton).SendKeys(password);
                _webDriver.FindElement(_phoneNumberInputButton).SendKeys(phoneNumber);

                return new MainMenuPage(_webDriver);
            }


        public MainMenuPage Login(string login, string password)
        {
            _webDriver.FindElement(_loginInputButton).SendKeys(login);
            _webDriver.FindElement(_continuetButton).Click();
            WaitUntil.WaitElement(_webDriver, _passwordInputButton);
            _webDriver.FindElement(_passwordInputButton).SendKeys(password);
            _webDriver.FindElement(_phoneNumberInputButton).SendKeys(phoneNumber);

            return new MainMenuPage(_webDriver);
        }
        */
    }
}
