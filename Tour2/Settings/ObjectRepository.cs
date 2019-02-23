using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour2.PageObjects;

namespace Tour2.Settings
{
  public  class ObjectRepository
    {
        public static IWebDriver Driver;
        public static IWebElement Element;
        public static InternetExplorerOptions IEOptions;
        public static FirefoxOptions FirefoxOptions;
        public static ChromeOptions ChormeOptions;

        public static HomePage homePage;
        public static DashBoardPage dashBoardPage;
        public static BasePage basePage;
    }
}
