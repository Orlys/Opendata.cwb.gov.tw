

namespace Opendata.cwb.gov.tw
{
    using Newtonsoft.Json;

    namespace Models
    {
        internal class RootObject<TRecords>
        {
            [JsonProperty("success")]
            public bool Success { get; set; }

            [JsonProperty("result")]
            public Result Result { get; set; }

            [JsonProperty("records")]
            public TRecords Records { get; set; }
        }
    }
}