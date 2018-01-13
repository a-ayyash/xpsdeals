using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpediaInterview.REST;
using Moq;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Schema.Generation;
using ExpediaInterview.Models;

namespace ExpediaInterviewUnitTests
{
    [TestClass]
    public class RESTOperatorUnitTests
    {
        private static string URL;

        [ClassInitialize()]
        public static void Init(TestContext context)
        {
            URL = TargetURL.GenerateDefaultURL();
        }

        [TestMethod]
        public void TestURLReturnsValidJSON()
        {
            string expectedSchema = System.IO.File.ReadAllText("ExpectedSchema.json");
            var content = RESTOperator.GETContent(URL);
            JObject response = JObject.Parse(content);
            JSchema schema = JSchema.Parse(expectedSchema);
            Assert.IsTrue(response.IsValid(schema));
        }

        /* TODO: Does not run on Travis, invistigate.
        [TestMethod]
        public void TestThrowsExceptionOnInvalidContentType()
        {
            var op = new RESTOperator();
            Assert.ThrowsException<AggregateException>(() => op.GETContent("http://www.google.com"));
        }
        */
    }
}
