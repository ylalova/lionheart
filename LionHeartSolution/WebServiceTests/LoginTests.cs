using LionHeartSolution.WebServiceModel.Common;
using LionHeartSolution.WebServiceModel.JsonObjects;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionHeartSolution.WebServiceTests
{
    [TestFixture]
    public class LoginTests
    {
        public static IRestResponse<Login> loginResponse;

        /// <summary>
        /// Send Post create issue call to validate status code
        /// </summary>
        [Test]
        public void PostLoginValidateStatusCode()
        {
            loginResponse = AuthenticateUserCalls.PostLoginUser("yoanaslalova", "Yoana!123");
            Assert.AreEqual(200, (int)loginResponse.StatusCode, "The response code is not 200 OK");
        }

        /// <summary>
        /// Send Post create issue call to validate for wrong credentials
        /// </summary>
        [Test]
        public void PostLoginValidateWrongCredentials()
        {
            loginResponse = AuthenticateUserCalls.PostLoginUser("dummydata", "DummyData!123");
            Assert.AreEqual(401, (int)loginResponse.StatusCode, "The response code is not 401 Unauthorized");
        }

        /// <summary>
        /// Send Post create issue call to validate for returned values
        /// </summary>
        [Test]
        public void PostLoginValidateValues()
        {
            loginResponse = AuthenticateUserCalls.PostLoginUser("yoanaslalova", "Yoana!123");

            Assert.Multiple(() => 
            {
                Assert.AreEqual(200, (int)loginResponse.StatusCode, "The response code is not 200 OK");
                Assert.AreEqual(loginResponse.Data.Session.Name, "JSESSIONID", "The values are not the same");
                Assert.IsNotEmpty(loginResponse.Data.Session.Value, "Session value parameter is empty");
            });
        }

        /// <summary>
        /// Send Post create issue call to validate for properties
        /// </summary>
        [Test]
        public void PostLoginValidateProperties()
        {
            loginResponse = AuthenticateUserCalls.PostLoginUser("yoanaslalova", "Yoana!123");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(200, (int)loginResponse.StatusCode, "The response code is not 200 OK");
                Assert.True(loginResponse.Content.Contains("session"), "Properties are not the same");
                Assert.True(loginResponse.Content.Contains("name"), "Properties are not the same");
                Assert.True(loginResponse.Content.Contains("value"), "Properties are not the same");
            });
        }

        /// <summary>
        /// Send Post create issue call to validate for missing required fields
        /// </summary>
        [Test]
        public void PostLoginMissingRequiredField()
        {
            loginResponse = AuthenticateUserCalls.PostLoginUser(null, "DummyData!123");
            Assert.AreEqual(401, (int)loginResponse.StatusCode, "The response code is not 401 Unauthorized");
        }
    }
}
