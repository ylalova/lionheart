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
    public class CreateModePage : BasePage
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

        public CreateModePage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Method which populated summary field
        /// </summary>
        /// <param name="summary"></param>
        /// <returns></returns>
        public CreateModePage EnterSummary(string summary)
        {
            Wait.ForElementClickable(driver, SummaryField);

            SummaryField.Click();
            SummaryField.SendKeys(summary);
            return new CreateModePage(driver);
        }

        /// <summary>
        /// Method which populates the description field
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public CreateModePage EnterDescription(string description)
        {
            Wait.ForElementClickable(driver, DescriptionField);

            DescriptionField.Click();
            DescriptionField.SendKeys(description);

            return new CreateModePage(driver);
        }

        /// <summary>
        /// Method which clicks on show all fields link
        /// </summary>
        /// <returns></returns>
        public CreateModePage ClickOnShowAllFields()
        {
            ShowAllFieldsLink.Click();

            return new CreateModePage(driver);
        }

        /// <summary>
        /// Method which clicks on create issue button
        /// </summary>
        /// <returns></returns>
        public CreateModePage ClickCreateIssueButton()
        {
            Wait.ForVisibleElement(driver, (By)SubmitButton);
            SubmitButton.Click();

            return this;
        }

        /// <summary>
        /// This method selects Jira ticket type
        /// </summary>
        /// <returns></returns>
        public CreateModePage SelectJiraTicketType(string type)
        {
            SelectElement selectDrp = new SelectElement(SelectJiraTicket);
            selectDrp.SelectByText(type);

            return new CreateModePage(driver);
        }
    }
}
