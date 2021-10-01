using LionHeartSolution.WebServiceModel.APICalls;
using LionHeartSolution.WebServiceModel.JsonObjects;
using NUnit.Framework;
using RestSharp;

namespace LionHeartSolution.WebServiceTests
{
    public class CreateIssueTests
    {
        public static IRestResponse<CreateIssue> createIssueResponse;
        public const string ProjectKey = "LH";

        /// <summary>
        /// Send Post create issue call to validate status code
        /// </summary>
        [Test]
        public void PostCreateIssueValidateStatusCode()
        {
            createIssueResponse = CreateIssueCalls.PostCreateIssue(ProjectKey, "Test Summary", "Test Description", "Bug");
            Assert.AreEqual(201, (int)createIssueResponse.StatusCode, "The response code is not 201 Created");
        }

        /// <summary>
        /// Send Post create issue call to validate for missing required fields
        /// </summary>
        [Test]
        public void PostLoginValidateMissingRequiredField()
        {
            createIssueResponse = CreateIssueCalls.PostCreateIssue(null, "Test Summary", "Test Description", "Bug");
            Assert.AreEqual(400, (int)createIssueResponse.StatusCode, "The response code is not 400 Bad Request");
        }

        /// <summary>
        /// Send Post create issue call to validate for returned values
        /// </summary>
        [Test]
        public void PostLoginValidateValues()
        {
            createIssueResponse = CreateIssueCalls.PostCreateIssue(ProjectKey, "Test Summary", "Test Description", "Bug");

            Assert.Multiple(() =>
            {
                Assert.IsNotNull(createIssueResponse.Data.Id, "The value is null");
                Assert.IsNotEmpty(createIssueResponse.Data.Key, "Key value parameter is empty");
                Assert.IsNotEmpty(createIssueResponse.Data.Self, "Self value parameter is empty");

            });
        }

        /// <summary>
        /// Send Post create issue call to validate it's properties
        /// </summary>
        [Test]
        public void PostLoginValidateProperties()
        {
            createIssueResponse = CreateIssueCalls.PostCreateIssue(ProjectKey, "Test Summary", "Test Description", "Bug");

            Assert.Multiple(() =>
            {
                Assert.True(createIssueResponse.Content.Contains("id"), "Properties are not the same");
                Assert.True(createIssueResponse.Content.Contains("key"), "Properties are not the same");
                Assert.True(createIssueResponse.Content.Contains("self"), "Properties are not the same");
            });
        }
    }
}
