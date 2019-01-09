// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Opendata
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    namespace Models
    {
        internal class Result
        {
            [JsonProperty("fields")]
            public List<Field> Fields { get; set; }

            [JsonProperty("resource_id")]
            public string ResourceId { get; set; }
        }
    }
}