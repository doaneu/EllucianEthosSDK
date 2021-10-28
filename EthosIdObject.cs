using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EllucianEthosSDK
{
    public class GUIDObject
    {

        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
    }
}
