
namespace Opendata.cwb.gov.tw
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OpendataClient
    {
        private readonly HttpClient _client;

        public const string BASE_URL = "https://opendata.cwb.gov.tw";
        public const string URI_V1 = "/api/v1/rest/datastore/{0}";

        public OpendataClient(string apikey)
        {
            this._client = new HttpClient();
            this._client.BaseAddress = new Uri(BASE_URL);
            this._client.DefaultRequestHeaders.Add("Authorization", apikey); 
        }


        public virtual async Task<T> GetAsync<T>(QueryBy<T> queryBy, CancellationToken token = default)
        {
            try
            {
                var d = string.Format(URI_V1, queryBy.DataId);
                var response = await this._client.GetAsync(d, token);
                var json = await response.Content.ReadAsStringAsync();
                var tk = queryBy.Deserialize(json);
                if (!tk.Success)
                    return default;
                return tk.Records;
            }
            catch
            {
                throw;
            } 
        }
    }
}
