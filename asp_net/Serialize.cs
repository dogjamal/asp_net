using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using asp_net.tests;



namespace asp_net
{
    public class Serialize : BaseTest
    {
        public void Login()
        {
            EnvironmentConstantWriter environmentConstantWriter = new EnvironmentConstantWriter();
            environmentConstantWriter.Write_down();
        }
    }
}
