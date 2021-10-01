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
    public class BasePage
    {
        [FindsBy(How = How.Name, Using = "issues-tab")]
        protected IWebElement IssuesButton;

        [FindsBy(How = How.Id, Using = "search")]
        protected IWebElement SearchInput;

        /// <summary>
        /// Base page constructor
        /// </summary>
        /// <param name="driver"></param>
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Getter for driver
        /// </summary>
        protected IWebDriver driver { get; }

        public IssuesPage NavigateToIssuesPage()
        {
            IssuesButton.Click();
            return new IssuesPage(driver);
        }

        /// <summary>
        /// Method which inputs search criteria in the quick search
        /// </summary>
        /// <param name="searchCriteria"></param>
        /// <returns></returns>
        public ResultsPage SearchFromHeaderIssue(string searchCriteria)
        {
            Wait.ForVisibleElement(driver, (By)SearchInput);

            SearchInput.Click();
            SearchInput.SendKeys(searchCriteria);
            SearchInput.SendKeys(Keys.Enter);

            return new ResultsPage(driver);
        }
    }
}
