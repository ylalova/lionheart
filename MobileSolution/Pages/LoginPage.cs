using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject;

namespace MobileSolution.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "login-username")]
        protected IWebElement UsernameField;

        [FindsBy(How = How.Id, Using = "login-password")]
        protected IWebElement PasswordField;

        [FindsBy(How = How.Id, Using = "login")]
        protected IWebElement LoginButton;

        [FindsBy(How = How.Id, Using = "continue")]
        protected IWebElement Continue;

        /// <summary>
        /// Pass through to the base constructor
        /// </summary>
        /// <param name="driver"></param>
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Method which populates username field
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public LoginPage EnterUsername(string username)
        {
            UsernameField.Clear();
            UsernameField.SendKeys(username);

            Wait.ForVisibleElement(driver, (By)Continue);

            return this;
        }

        /// <summary>
        /// Method which populates password field
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public LoginPage EnterPassword(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
            return this;
        }

        /// <summary>
        /// Click on continue button
        /// </summary>
        /// <returns></returns>
        public LoginPage ClickContinue()
        {
            Continue.Click();
            Assert.IsTrue(PasswordField.Displayed);

            return this;
        }
        /// <summary>
        /// Method which clicks login button
        /// </summary>
        /// <returns></returns>
        public ProjectsPage ClickLoginButton()
        {
            LoginButton.Click();
            return new ProjectsPage(driver);
        }
    }
}
