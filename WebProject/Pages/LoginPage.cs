using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WebProject.Pages
{
    public class LoginPage : BasePage
    {
        WebDriverWait wait;

        [FindsBy(How = How.Id, Using = "login-form-username")]
        protected IWebElement UsernameField;

        [FindsBy(How = How.Id, Using = "login-form-password")]
        protected IWebElement PasswordField;

        [FindsBy(How = How.Id, Using = "login")]
        protected IWebElement LoginButton;

        /// <summary>
        /// Pass through to the base constructor
        /// </summary>
        /// <param name="driver"></param>
        public LoginPage(IWebDriver driver) : base(driver){
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
        /// Method which clicks login button
        /// </summary>
        /// <returns></returns>
        public SystemDashboard ClickLoginButton()
        {
            LoginButton.Click();
            return new SystemDashboard(driver);
        }
    }
}
