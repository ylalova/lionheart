using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSolution.Pages
{
    public class LandingPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "login")]
        protected IWebElement LoginButton;

        [FindsBy(How = How.Id, Using = "sign-up")]
        protected IWebElement SignUpButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Log in to your account')")]
        protected IWebElement LoginToAccTitle;

        /// <summary>
        /// Pass through to the base constructor
        /// </summary>
        /// <param name="driver"></param>
        public LandingPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Method which populates username field
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public LoginPage ClickLogin()
        {
            string actualTitle = LoginToAccTitle.Text;
            string expectedTitle = "Log in to your account";

            LoginButton.Click();

            Assert.AreEqual(expectedTitle ,actualTitle, "Titles are not the same");

            return new LoginPage(driver);
        }
    }
}
