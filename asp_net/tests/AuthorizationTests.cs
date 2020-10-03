using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace asp_net.tests
{
    public class AuthorizationTests : BaseTest
    {
        private const int _mailNameSize = 10;
        private const int _theSizeOfThePassword = 15;

        [Test]
        public void LoginAsUser_StandartBehavior_Logined()
        {
          //  var CreateNewUser = (GenerateData.GenerateRandomMail("gmail"), GenerateData.GenerateRandomPassword(_theSizeOfThePassword));
        }
        /*
        public void LoginAsUser_StandartBehavior_Logined()
        {
            mainMenu
                .SignIn();
                .CreateNewUser(GenerateData.Ge...
        }
        */
    }
}
