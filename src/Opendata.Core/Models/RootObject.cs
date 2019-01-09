// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Opendata
{
    using Newtonsoft.Json;

    namespace Models
    {
        internal class RootObject<TRecords>
        {
            [JsonProperty("records")]
            public TRecords Records { get; set; }

            [JsonProperty("result")]
            public Result Result { get; set; }

            [JsonProperty("success")]
            public bool Success { get; set; }
        }
    }
}