using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace WebProject
{
    public class Wait
    {
        private static int TimeToWait = int.Parse(ConfigurationManager.AppSettings["Wait"]);

        /// <summary>
        /// Method which verifies if element is clickable
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        public static void ForElementClickable(IWebDriver driver, IWebElement element)
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(TimeToWait));
            waiter.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        /// <summary>
        /// Method which verifies if element is visible
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        public static void ForVisibleElement(IWebDriver driver, By by)
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(TimeToWait));
            waiter.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
