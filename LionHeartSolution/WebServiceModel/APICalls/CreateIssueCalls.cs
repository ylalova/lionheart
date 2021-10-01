using LionHeartSolution.WebServiceModel.Common;
using LionHeartSolution.WebServiceModel.JsonObjects;
using RestSharp;

namespace LionHeartSolution.WebServiceModel.APICalls
{
    /// <summary>
    /// Call for creation of issues
    /// </summary>
    public class CreateIssueCalls
    {
        public static IRestResponse<CreateIssue> PostCreateIssue(string projectKey, string issueSummary, string issueDescription, string issueTypeName)
        {
         
            var body = new
            {
                fields = new {
                    project = new {
                        key = projectKey 
                    },
                    summary = issueSummary,
                    description = issueDescription,
                    issuetype = new {
                        name = issueTypeName  
                    }
                }
            };

            var retrieveCookie = GenerateAuthentication.RetreiveCookie(Routes.LoginCall, "yoanaslalova", "Yoana!123");

            var client = new RestClient(Routes.CreateIssueCall);
            var request = new RestRequest(Method.POST);

            request.AddCookie(retrieveCookie.Data.Session.Name, retrieveCookie.Data.Session.Value);
            request.AddJsonBody(body);

            var response = client.Post<CreateIssue>(request);

            return response;

        }
    }
}
