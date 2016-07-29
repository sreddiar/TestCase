using NUnit.Framework;
using PNUnit.Framework;
using System;
using System.Web;
using System.Text;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture()]
    public class TestingBotTest
    {
      
        private string[] testParams;

        [SetUp]
        public void Init()
        {
            testParams = PNUnitServices.Get().GetTestParams();
            String params1 = String.Join(",", testParams);
            Console.WriteLine(params1);
            String browser = testParams[0];
            String version = testParams[1];
            String os = testParams[2];
          
         }
        [TestMethod]
        public async Task CTestMethod1()
        {
            await Task.Delay(5000);
        }


        [Test]
        public void TestCase()
        {
        
        }

        [TearDown]
        public void Cleanup()
        {
            
        }
    }
}