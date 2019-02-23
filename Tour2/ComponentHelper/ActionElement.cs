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

namespace Tour2.ComponentHelper
{
    public class ActionElement

    {

        public static void EnterTextInTextBox(IWebElement WebElement, string TextToEnter)
        {
            if (WebElement.Displayed == true)
            {
                WebElement.SendKeys(TextToEnter);
            }
            else
            {
                Console.WriteLine("Element not found" + WebElement);
            }
            
        }
        public static void ButtonClick(IWebElement WebElement)
        {
            if (WebElement.Displayed == true)
            {
                WebElement.Click();
            }
            else
            {
                Console.WriteLine("Element not found" + WebElement);
            }
            
        }
        public static void LinkClick(IWebElement WebElement)
        {
            if (WebElement.Displayed == true)
            {
                WebElement.Click();
            }
            else
            {
                Console.WriteLine("Element not found" + WebElement);
            }
          
        }
        public static bool IsElementPresent(IWebElement WebElement)
        {
            if (WebElement.Displayed == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }










    }
}
