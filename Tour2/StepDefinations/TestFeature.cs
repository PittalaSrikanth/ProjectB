using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System.Configuration;
using Tour2.Settings;
using OpenQA.Selenium;
using Tour2.Configuration;
using Tour2.ComponentHelper;
using Tour2.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;
using Tour2.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tour2.StepDefinations
{
    [Binding]
    public sealed class TestFeature
    {
        HomePage homePage = new HomePage();
        DashBoardPage dashBoardPage = new DashBoardPage();

        #region Given

        [Given(@"user is at login page with title ""(.*)""")]
        public void GivenUserIsAtLoginPageWithTitle(string title)
        {
            NavigateHelper.WebSite(ConfigurationManager.AppSettings.Get(AppConfigKeys.WebSite));
            Assert.AreEqual(title, ObjectRepository.Driver.Title);
        }
        [Given(@"Title of the page should be ""(.*)""")]
        public void GivenTitleOfThePageShouldBe(string title)
        {
            Assert.AreEqual(title, ObjectRepository.Driver.Title);
        }
    



    #endregion

    #region When
    [When(@"i enter ""(.*)"" and ""(.*)"" and click login button")]
    public void WhenIEnterAndAndClickLoginButton(string userId, string Password)
    {
        dashBoardPage = homePage.Login(userId, Password);
    }


        #endregion

        #region Then

        [Then(@"user should be at Dashboard page with title ""(.*)""")]
        public void ThenUserShouldBeAtDashboardPageWithTitle(string title)
        {
            Assert.AreEqual(title, ObjectRepository.Driver.Title);
        }

        [Then(@"Title of the page should be ""(.*)""")]
        public void ThenTitleOfThePageShouldBe(string title)
        {
            Assert.AreEqual(title, ObjectRepository.Driver.Title);
            
        }

        


        #endregion
    }
}
