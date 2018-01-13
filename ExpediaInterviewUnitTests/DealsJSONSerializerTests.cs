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
            DealsJSONSerializer s = new DealsJSONSerializer();
            var deal = s.ReadDealFromJSON("{}");

            Assert.IsFalse(deal.IsValidDeal());
        }

        [TestMethod]
        public void TestInavlidDealOnEmptyContent()
        {
            DealsJSONSerializer s = new DealsJSONSerializer();
            Assert.IsFalse(s.ReadDealFromJSON("").IsValidDeal());
        }

        [TestMethod]
        public void TestValidJSON()
        {
            DealsJSONSerializer s = new DealsJSONSerializer();
            var expectedContent = System.IO.File.ReadAllText("ExpectedSchema.json");
            var deal = s.ReadDealFromJSON(expectedContent);

            Assert.IsTrue(deal.IsValidDeal());
        }

        [TestMethod]
        public void TestSerialization()
        {
            DealsJSONSerializer s = new DealsJSONSerializer();
            var expectedContent = System.IO.File.ReadAllText("ExpectedSchema.json");
            var deal = s.ReadDealFromJSON(expectedContent);

            Assert.IsTrue(string.Equals(deal.User.UserID, "awesome_user_ID"));
            //Assert.AreEqual(deal.Hotels[0].Hotel.ID, 10980182);
            Assert.AreEqual(deal.OfferDetails.SiteID, 42);
        }
    }
}
