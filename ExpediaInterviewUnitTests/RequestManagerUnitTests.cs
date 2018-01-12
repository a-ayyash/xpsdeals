using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpediaInterview.REST;

namespace ExpediaInterviewUnitTests
{
    [TestClass]
    public class RequestManagerUnitTests
    {

        [TestMethod]
        public void TestDefaultDeal()
        {
            var deal = RequestManager.GetDeal(TargetURL.GenerateDefaultURL());

            Assert.IsTrue(deal.IsValidDeal());
        }
    }
}
