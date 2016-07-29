using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using BaseClass;

namespace UnitTestProjectC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task CTestMethod1()
        {
            await Task.Delay(5000);
        }

        [TestMethod]
        public async Task Add()
        {
            int result = await Class1.Add(1, 2);
            
            Assert.AreEqual(3, result);
            
        }


    }
}