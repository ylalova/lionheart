using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSolution.Pages
{
    public class ProjectsPage : BasePage
    {
        /// <summary>
        /// Pass through to the base constructor
        /// </summary>
        /// <param name="driver"></param>
        public ProjectsPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Assert if user is on projects page
        /// </summary>
        public void CheckUserIsOnProjectsPage()
        {
            //here will be created method which will assert if user is placed on Projects page
        }
    }
}
