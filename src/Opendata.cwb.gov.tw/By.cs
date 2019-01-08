
namespace Opendata
{
    using Opendata.Models;
    using Newtonsoft.Json;

    public class By<T> : IQueryBy
    {
        internal By(string dataId)
        {
            this.DataId = dataId.Replace("_", "-");
        }

        public string DataId { get;private set; }

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
