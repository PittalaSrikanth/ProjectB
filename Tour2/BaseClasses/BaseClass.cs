 
using Tour2.ComponentHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Microsoft.VisualStudio.TestTools;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Tour2.Configuration;
using Tour2.Settings;
using NUnit.Framework;

namespace Tour2.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
      //  public static IWebDriver driver;
        public static IWebDriver GetChromeBrowseer()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }
        public static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        public static InternetExplorerOptions GetIEDriver()
        {
            InternetExplorerOptions driver = new InternetExplorerOptions();
            driver.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            driver.IgnoreZoomLevel = true;
            driver.EnsureCleanSession = true;
            return driver;
        }
      //  [AssemblyInitialize]
        public static void Initialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext tc)
        {
            switch (ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser))
            {
                case "Firefox":
                   ObjectRepository.Driver = GetFirefoxDriver();
                    NavigateHelper.WebSite(ConfigurationManager.AppSettings.Get(AppConfigKeys.WebSite));
                    break;
                case "Chrome":
                    ObjectRepository.Driver =  GetChromeBrowseer();
                    NavigateHelper.WebSite(ConfigurationManager.AppSettings.Get(AppConfigKeys.WebSite));
                    break;
                case "IE":
                 //   ObjectRepository.IEOptions = GetIEDriver();
                    ObjectRepository.Driver = new InternetExplorerDriver(GetIEDriver());
                    NavigateHelper.WebSite(ConfigurationManager.AppSettings.Get(AppConfigKeys.WebSite));
                    break;
            }
        }
      //  [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                Console.WriteLine("Hai");
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }


    }   
}
