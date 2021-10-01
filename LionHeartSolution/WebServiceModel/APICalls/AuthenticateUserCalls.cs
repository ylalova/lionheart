using LionHeartSolution.WebServiceModel.JsonObjects;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LionHeartSolution.WebServiceModel.Common
{
    /// <summary>
    /// Send call to login user with valid username and password
    /// </summary>
    public class AuthenticateUserCalls
    {
        public static IRestResponse<Login> PostLoginUser(string validUsername, string validPassword) 
            => GenerateAuthentication.RetreiveCookie(Routes.LoginCall, validUsername, validPassword);
    }
}
