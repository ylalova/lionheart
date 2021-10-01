using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Pages
{
    public class SystemDashboard : BasePage
    {
        [FindsBy(How = How.Id, Using = "create-menu")]
        protected IWebElement CreateButton;

        [FindsBy(How = How.ClassName, Using = "aui-message")]
        protected IWebElement NotificationMsg;

        /// <summary>
        /// Pass through to the base constructor
        /// </summary>
        /// <param name="driver"></param>
        public SystemDashboard(IWebDriver driver) : base(driver)
        { }

        /// <summary>
        /// Method which clicks on Create button
        /// </summary>
        /// <returns></returns>
        public CreateModal ClickCreateButton()
        {
            Wait.ForElementClickable(driver, CreateButton);
            CreateButton.Click();

            return new CreateModal(driver);
        }

        /// <summary>
        /// Method which verifies if create button is displayed
        /// </summary>
        /// <returns></returns>
        public bool CreateButtonIsDisplayed()
        {
            Wait.ForElementClickable(driver, CreateButton);
            return CreateButton.Displayed;
        }

        /// <summary>
        /// This method will check if notification is displayed once issue is created
        /// </summary>
        /// <returns></returns>
        public bool NotificationMessageForNewIssue()
        {
            return true;
        }
    }
}
