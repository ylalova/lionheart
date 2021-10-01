using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Pages
{
    public class Dashboard : BasePage
    {

        private static string pageUrl = ConfigurationManager.AppSettings["WebUrl"];

        /// <summary>
        /// Pass through to the base constructor
        /// </summary>
        /// <param name="driver"></param>
        public Dashboard(IWebDriver driver) : base(driver)
        {

        }

        /// <summary>
        /// Method which navigates to Dashboard page
        /// </summary>
        public void NavigateToDashBoardPage()
        {
            driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
