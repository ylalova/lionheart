using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionHeartSolution.WebServiceModel
{
    public class Routes
    {
        /// <summary>
        /// The API base url
        /// </summary>
        public static string baseUrl = "http://localhost:8080";

        /// <summary>
        /// The login call
        /// </summary>
        public static string LoginCall = $"{baseUrl}/rest/auth/1/session";

        /// <summary>
        /// The create issue call
        /// </summary>
        public static string CreateIssueCall = $"{baseUrl}/rest/api/2/issue";
    }
}
