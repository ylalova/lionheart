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
    public class Session
    {
        /// <summary>
        /// Constructor for json serialization
        /// </summary>
        public Session() {}

        /// <summary>
        /// Json property name
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Json property value
        /// </summary>
        [DeserializeAs(Name = "value")]
        public string Value { get; set; }
    }
}
