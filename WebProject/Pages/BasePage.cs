using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebProject.Pages
{
    public class BasePage
    {
        [FindsBy(How = How.Id, Using = "quickSearchInput")]
        protected IWebElement QuickSearchInputField;

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

        /// <summary>
        /// Method which inputs search criteria in the quick search
        /// </summary>
        /// <param name="searchCriteria"></param>
        /// <returns></returns>
        public ResultsPage SearchFromHeaderIssue(string searchCriteria)
        {
            Wait.ForVisibleElement(driver, (By)QuickSearchInputField);

            QuickSearchInputField.Click();
            QuickSearchInputField.SendKeys(searchCriteria);
            QuickSearchInputField.SendKeys(Keys.Enter);

            return new ResultsPage(driver);
        }
    }
}
