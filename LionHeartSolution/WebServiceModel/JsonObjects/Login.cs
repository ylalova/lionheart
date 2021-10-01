using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Deserializers;

namespace LionHeartSolution.WebServiceModel.JsonObjects
{
  public class Login
    {
        /// <summary>
        /// Constructor for json serialization
        /// </summary>
        public Login() {}

        /// <summary>
        /// Json property session
        /// </summary>

        [DeserializeAs(Name = "session")]
        public Session Session { get; set; }
    }
}
