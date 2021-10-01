using NUnit.Framework;
using System;
using WebProject.Pages;

namespace WebProject.Tests
{
    [TestFixture]
    public class SmokeTests : BaseTest
    {
        protected string username = "yoanaslalova";
        protected string password = "Yoana!123";

        protected static Random rnd = new Random();
        protected string summary = "Title of ticket - " + rnd.Next(100);
        protected string description = "Description of ticket - " + rnd.Next(100);

        [SetUp]
        public void LoginUser()
        {
            LoginPage login = new LoginPage(driver);

            login.EnterUsername(username)
                .EnterPassword(password)
                .ClickLoginButton()
                .CreateButtonIsDisplayed();
        }

        /// <summary>
        /// Test which verifies if user can create issue
        /// </summary>
        [Test, Description("Verify user can create issue")]
        public void CreateIssue()
        {
            SystemDashboard systemDashboard = new SystemDashboard(driver);
            systemDashboard.ClickCreateButton()
                .EnterSummary(summary)
                .EnterDescription(description)
                .ScrollToAssignToMeLink()
                .ClickAssignToMe()
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
