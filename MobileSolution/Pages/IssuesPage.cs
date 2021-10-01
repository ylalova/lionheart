using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject;

namespace MobileSolution.Pages
{
    public class IssuesPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "issues")]
        protected IWebElement IssuesTitle;

        [FindsBy(How = How.Id, Using = "add-issue")]
        protected IWebElement AddIssue;

        [FindsBy(How = How.Id, Using = "create-issue-submit")]
        protected IWebElement SubmitButton;

        [FindsBy(How = How.Id, Using = "summary")]
        protected IWebElement SummaryField;

        [FindsBy(How = How.Id, Using = "description")]
        protected IWebElement DescriptionField;

        [FindsBy(How = How.LinkText, Using = "show-all-fields")]
        protected static IWebElement ShowAllFieldsLink;

        [FindsBy(How = How.Name, Using = "issues-type")]
        protected IWebElement SelectJiraTicket;

        /// <summary>
        /// Pass through to the base constructor
        /// </summary>
        /// <param name="driver"></param>
        public IssuesPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Assert if title is displayed
        /// </summary>
        public IssuesPage TitleIssuesIsDisplayed()
        {
            Wait.ForVisibleElement(driver, (By)IssuesTitle);

            return this;
        }

        /// <summary>
        /// Assert if title is displayed
        /// </summary>
        public CreateModePage ClickOnAddIssueButton()
        {
            Wait.ForVisibleElement(driver, (By)AddIssue);

            AddIssue.Click();
            return new CreateModePage(driver);
        }


    }
}
