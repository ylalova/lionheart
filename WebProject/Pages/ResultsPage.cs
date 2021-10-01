using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Pages
{
    public class ResultsPage : BasePage
    {
        /// <summary>
        /// Pass through to the base constructor
        /// </summary>
        /// <param name="driver"></param>
        public ResultsPage(IWebDriver driver) : base(driver)
        { }

        public void CheckResultIsDisplayed()
        {
            //This method will verify if the searched issue is displayed
        }
    }
}
