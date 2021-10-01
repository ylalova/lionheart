using LionHeartSolution.WebServiceModel.JsonObjects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionHeartSolution.WebServiceModel.Common
{
    public class GenerateAuthentication
    {
        /// <summary>
        /// Method which retrieves cookie
        /// </summary>
        /// <param name="path"></param>
        /// <param name="jiraUser"></param>
        /// <param name="userPsrw"></param>
        /// <returns></returns>
        public static IRestResponse<Login> RetreiveCookie(string path, string jiraUser, string userPsrw)
        {
            var client = new RestClient(path);
            var request = new RestRequest(Method.POST);

            var body = new
            {
                username = jiraUser,
                password = userPsrw
            };

            request.AddJsonBody(body);
            request.AddHeader("contentType", "application/json");
            var response = client.Post<Login>(request);

            return response;
        }
    }
}
