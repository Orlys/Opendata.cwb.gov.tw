

namespace Opendata.cwb.gov.tw
{
    using Newtonsoft.Json;

    namespace Models
    {
        public class Field
        { 
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }
        }
    }
}