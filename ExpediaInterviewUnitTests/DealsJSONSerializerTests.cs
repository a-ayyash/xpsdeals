using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ExpediaInterview.REST;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpediaInterviewUnitTests
{

    [TestClass]
    public class DealsJSONSerializerTests
    {
        [TestMethod]
        public void TestWrongJSON()
        {
            var deal =  DealsJSONSerializer.ReadDealFromJSON("{}");

            Assert.IsFalse(deal.IsValidDeal());
        }

        [TestMethod]
        public void TestInavlidDealOnEmptyContent()
        {
            Assert.IsFalse(DealsJSONSerializer.ReadDealFromJSON("").IsValidDeal());
        }

        [TestMethod]
        public void TestValidJSON()
        {
            var expectedContent = System.IO.File.ReadAllText("FullResponse.json");
            var deal = DealsJSONSerializer.ReadDealFromJSON(expectedContent);

            Assert.IsTrue(deal.IsValidDeal());
        }

        [TestMethod]
        public void TestSerialization()
        {
            var expectedContent = System.IO.File.ReadAllText("ExpectedSchema.json");
            var deal = DealsJSONSerializer.ReadDealFromJSON(expectedContent);

            Assert.IsTrue(string.Equals(deal.User.UserID, "awesome_user_ID"));
            Assert.AreEqual(deal.OfferDetails.SiteID, 42);
        }
    }
}
