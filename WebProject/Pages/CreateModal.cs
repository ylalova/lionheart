using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using WebProject.Helpers;

namespace WebProject.Pages
{
    public class CreateModal : BasePage
    {
        [FindsBy(How = How.Id, Using = "create-issue-submit")]
        protected IWebElement SubmitButton;

        [FindsBy(How = How.Id, Using = "summary")]
        protected IWebElement SummaryField;

        [FindsBy(How = How.Id, Using = "mce_0_ifr")]
        protected IWebElement DescriptionFieldIFrame;

        [FindsBy(How = How.Id, Using = "tinymce")]
        protected IWebElement DescriptionFieldId;

        [FindsBy(How = How.Id, Using = "priority-field")]
        protected static IWebElement PriorityField;

        [FindsBy(How = How.Id, Using = "assign-to-me-trigger")]
        protected IWebElement AssignTomeLink;

        /// <summary>
        /// Pass through to the base constructor
        /// </summary>
        /// <param name="driver"></param>
        public CreateModal(IWebDriver driver) : base(driver)
        { }

        /// <summary>
        /// Method which populates the summary field
        /// </summary>
        /// <param name="summary"></param>
        /// <returns></returns>
        public CreateModal EnterSummary(string summary)
        {
            Wait.ForElementClickable(driver, SummaryField);

            SummaryField.Click();
            SummaryField.SendKeys(summary);
            return this;
        }

        /// <summary>
        /// Method which populates the description field
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public CreateModal EnterDescription(string description)
        {
            driver.SwitchTo().Frame(DescriptionFieldIFrame);

            Wait.ForElementClickable(driver, DescriptionFieldId);

            DescriptionFieldId.Click();
            DescriptionFieldId.SendKeys(description);

            return this;
        }

        /// <summary>
        /// Method which selects the priority option
        /// </summary>
        /// <returns></returns>
        public CreateModal SelectPriority()
        {
            SelectElement dropdownSelect = new SelectElement(PriorityField);
            dropdownSelect.SelectByValue("1");

            return this;
        }

        /// <summary>
        /// Method which clicks on assign to me link
        /// </summary>
        /// <returns></returns>
        public CreateModal ClickAssignToMe()
        {
            Wait.ForElementClickable(driver, AssignTomeLink);

            AssignTomeLink.Click();

            string actualResult = driver.FindElement((By)AssignTomeLink).Text;
            Assert.AreEqual("yoanaslalova@gmail.com", actualResult, "Assignee text is not correct.");

            return this;
        }

        /// <summary>
        /// Method which clicks on create issue button
        /// </summary>
        /// <returns></returns>
        public SystemDashboard ClickCreateIssueButton()
        {
            SubmitButton.Click();

            return new SystemDashboard(driver);
        }

        /// <summary>
        /// This method scrolls to assign to me link
        /// </summary>
        /// <returns></returns>
        public CreateModal ScrollToAssignToMeLink()
        {
            string elementToFocusScrollScript = String.Format("window.scrollTo({0}, {1})", 0, AssignTomeLink.Location.Y);
            JSExecutor.RunJS(driver, elementToFocusScrollScript);
            return this;
        }

    }
}
