
namespace Opendata.cwb.gov.tw.ConsoleDebugger
{
    using System;
    using System.Threading.Tasks;
    using Opendata.cwb.gov.tw;
    class Program
    {
        static async Task Main(string[] args)
        {
            var token = args.Length > 0 ? args[0] : "CWB-ACCESS-TOKEN";
            var client = new OpendataClient(token);
            var result = await client.GetAsync(Queries.F_C0032_001);
            Console.WriteLine(result.datasetDescription);
            Console.ReadKey();
        }
    }
}
