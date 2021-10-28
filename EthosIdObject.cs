using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenLearningAcademyService.Ethos.Entities
{
    public class GUIDObject
    {

        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
    }
}
