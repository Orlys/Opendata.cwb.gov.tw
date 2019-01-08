
namespace Opendata.ConsoleDebugger
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Opendata;
    class Program
    {
        static async Task Main(string[] args)
        {
            var token = "CWB-AUTH-TOKEN-GUID";
            var client = new OpendataClient(apikey: token);
            var subject = QueryBy.F_C0032_001;
            var result = await client.GetAsync(queryBy: subject, token: default(CancellationToken));
            Console.WriteLine(result.datasetDescription);
            Console.ReadKey();
        }
    }
}
