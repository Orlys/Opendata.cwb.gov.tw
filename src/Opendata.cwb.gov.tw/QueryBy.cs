
namespace Opendata.cwb.gov.tw
{
    using Opendata.cwb.gov.tw.Models;
    using Newtonsoft.Json;

    public class QueryBy<T>
    {
        internal QueryBy(string dataId)
        {
            this.DataId = dataId.Replace("_", "-");
        }

        internal string DataId { get;private set; }

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
