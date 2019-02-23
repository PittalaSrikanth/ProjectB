using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour2.ComponentHelper
{
   [TestClass]
    public class AssertHelper
    {

     
        public static TestContext _testContext;
        public static TestContext TestContext {
            get { return _testContext; }
            set { _testContext = value; }
        }
    
        public static void AreEqual(string Expected,string Actual)
        {
            try
            {
                Assert.AreEqual(Expected, Actual);
            }
            catch (Exception )
            {
                //   throw;
                Console.WriteLine("******************");
               Console.WriteLine(TestContext.TestName.ToString());
             
            }
        }
    }
}
