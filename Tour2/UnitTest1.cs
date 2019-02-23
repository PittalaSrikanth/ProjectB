using Tour2.ExcelReader;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Tour2.Settings;
using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tour2.Configuration;
using Tour2.PageObjects;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Tour2
{
    [TestClass]
    public class UnitTest1
    {

         ScenarioContext _cenarioContext { get; set; }
        public TestContext TestContext { get; set; }
         
         public static IWebDriver _driver;
        public static DateTime StartTimeValue;
        public static DateTime EndTimeValue;
        HomePage homePage = new HomePage();

        [TestMethod]
        public void TestMethod1()
        {
            Thread.Sleep(2000);
          // Console.WriteLine(ExcelReader.ExcelReader.ReadData(@"D:\PractiveFiles\ExcelReaderFile.xlsx", "Login", "RF_WEB_POU_SetPhy_000001", "UserID"));
          homePage.Login("admin123", "admin123");

           Console.WriteLine("############"+ ScenarioContext.Current.ScenarioExecutionStatus.ToString());
            
        }
        
        [TestInitialize]
        public  void StartTime()
        {
            Console.WriteLine("Method Start Time : {0}", DateTime.Now);
            StartTimeValue = DateTime.Now;
           
        }
        [TestCleanup]
        public void EndTime()
        {
            Console.WriteLine("Method End Time : {0}     Method Compleated in  {1} Seconds", DateTime.Now,TimeDifference());
            EndTimeValue = DateTime.Now;
           
        }

        public int TimeDifference()
        {
            return (StartTimeValue.Subtract(EndTimeValue)).Seconds;
        }
        
    }
}
