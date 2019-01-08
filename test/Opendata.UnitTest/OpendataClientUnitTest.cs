
namespace Opendata.UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading.Tasks;
    using Opendata;
    using System.Threading;

    [TestClass]
    public class OpendataClientUnitTest
    {
        [TestMethod]
        public async Task GetAsyncTest()
        {
            var token = "CWB-";
            var client = new OpendataClient(apikey: token);
            var subject = QueryBy.F_C0032_001;
            var result = await client.GetAsync(queryBy: subject, token: default(CancellationToken));

            Assert.AreEqual(result.datasetDescription, "三十六小時天氣預報"); 

        }
    }
}
