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

namespace Tour2.PageObjects
{
   public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(ObjectRepository.Driver, this);
        }

        #region PageElements

        [FindsBy(How = How.LinkText, Using = "SIGN-OFF")]
        private IWebElement SingOff;

        [FindsBy(How = How.LinkText, Using = "REGISTER")]
        private IWebElement RegisterLink;

        [FindsBy(How = How.LinkText, Using = "SUPPORT")]
        private IWebElement SupportLink;

        [FindsBy(How = How.LinkText, Using = "CONTACT")]
        private IWebElement ContactLink;
        


        #endregion


        #region PageActoins

        public void Logout()
        {
            if (ActionElement.IsElementPresent(SingOff)==true)
            {
                ActionElement.LinkClick(SingOff);
            }
        }
      
        #endregion



        #region PageNavigations

        public void NavigateToRegisterPage()
        {
            RegisterLink.Click();
        }
        public void NavigateToSupportPage()
        {
            SupportLink.Click();
        }
        public void NavigateToContactPage()
        {
            ContactLink.Click();
        }






        #endregion

    }
}
