using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionHeartSolution.WebServiceModel.JsonObjects
{
    /// <summary>
    /// Json Object class which contains the necessary properties
    /// </summary>
    public class CreateIssue
    {

        /// <summary>
        /// Constructor for json serialization
        /// </summary>
        public CreateIssue() {}

        /// <summary>
        /// Json property id
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Json property key
        /// </summary>
        [DeserializeAs(Name = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Json property self
        /// </summary>
        [DeserializeAs(Name = "self")]
        public string Self { get; set; }

    }
}
