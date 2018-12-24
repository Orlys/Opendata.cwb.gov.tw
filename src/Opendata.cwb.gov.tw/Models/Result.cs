
namespace Opendata.cwb.gov.tw
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    namespace Models
    {
        internal class Result
        {
            [JsonProperty("resource_id")]
            public string ResourceId { get; set; }

            [JsonProperty("fields")]
            public List<Field> Fields { get; set; }
        }
    }
}