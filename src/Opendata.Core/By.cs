// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Opendata.Core
{
    using Newtonsoft.Json;

    using Opendata.Models;

    public class By<T> : IQueryBy
    {
        public string DataId { get; }

        internal By(string dataId)
        {
            this.DataId = dataId.Replace("_", "-");
        }

        internal RootObject<T> Deserialize(string json)
        {
            try
            {
                var graph = JsonConvert.DeserializeObject<RootObject<T>>(json);
                return graph;
            }
            catch
            {
                throw;
            }
        }
    }
}