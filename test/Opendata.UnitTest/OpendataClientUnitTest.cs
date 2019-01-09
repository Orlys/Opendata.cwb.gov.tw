
namespace Opendata.UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading.Tasks;
    using System.Threading;
    using Opendata.Core;
    using System.Diagnostics;
    using System.IO;

    [TestClass]
    public class OpendataClientUnitTest
    {
        [TestMethod]
        public async Task GetAsyncTest()
        {
            var token = default(string);
            try
            {
                token = File.ReadAllText("../../../../.././misc/.token");
            }
            catch
            {
                Assert.Fail();
            }

            var client = new OpendataClient(apikey: token);
            var subject = QueryBy.F_C0032_001;
            var result = await client.GetAsync(queryBy: subject);

            const string _36HrsWeatherReport = "\u4E09\u5341\u516D\u5C0F\u6642\u5929\u6C23\u9810\u5831";

            Assert.AreEqual(result.datasetDescription, _36HrsWeatherReport);
            Debug.WriteLine(_36HrsWeatherReport);
        }
    }
}
