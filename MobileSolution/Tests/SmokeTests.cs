using MobileSolution.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSolution.Tests
{
    public class SmokeTests : BaseTest
    {
        protected string username = "yoanaslalova";
        protected string password = "Yoana!123";

        protected static Random rnd = new Random();
        protected string summary = "Title of ticket - " + rnd.Next(100);
        protected string description = "Description of ticket - " + rnd.Next(100);

        protected string issueType = "Story";

        [SetUp]
        public void LoginUser()
        {
            LandingPage landingPage = new LandingPage(driver);
            landingPage.ClickLogin();

            LoginPage login = new LoginPage(driver);
            login.EnterUsername(username)
                .ClickContinue()
                .EnterPassword(password)
                .ClickLoginButton()
                .CheckUserIsOnProjectsPage();
        }

        /// <summary>
        /// Test which verifies if user can create issue
        /// </summary>
        [Test, Description("Verify user can create issue")]
        public void CreateIssue()
        {
            BasePage createIssue = new BasePage(driver);

            createIssue.NavigateToIssuesPage()
                .TitleIssuesIsDisplayed()
                .ClickOnAddIssueButton()
                .SelectJiraTicketType(issueType)
                .EnterSummary(summary)
                .EnterDescription(description)
                .ClickOnShowAllFields()
                .ClickCreateIssueButton();
            
                
        }

        /// <summary>
        /// Test which verifies if user can search issue
        /// </summary>
        [Test, Description("Verify user can search issues")]
        public void SearchForIssue()
        {
            BasePage searchIssue = new BasePage(driver);

            searchIssue.SearchFromHeaderIssue(summary)
                .CheckResultIsDisplayed();
        }
    }
}
