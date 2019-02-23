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
   public class DashBoardPage : BasePage
    {
       

        #region PageElements

        [FindsBy(How = How.Name, Using = "userName")]
        private IWebElement UserIDTextBox;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement UserPasswordTextBox;

        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement LoginSubmitButton;

        [FindsBy(How = How.LinkText, Using = "REGISTER")]
        private IWebElement RegisterLink;

        [FindsBy(How = How.LinkText, Using = "SUPPORT")]
        private IWebElement SupportLink;

        [FindsBy(How = How.LinkText, Using = "CONTACT")]
        private IWebElement ContactLink;

        #endregion


        #region PageActoins

        public string Title
        {
            get { return ObjectRepository.Driver.Title; }
        }


        #endregion



        #region PageNavigations


        #endregion



    }
}
