using RestSharp;
using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace CS_REST_Exercise
{
    [TestFixture]
    class TestClass: ATestClass
    {
        [Test]
        public void test_method()
        {
            // Write code here:
            // Ping the api, assert a 201/Created status code
            // Get an auth token and store it, assert 200/OK response with token in body
            // Create a booking, assert 200/OK response
            // Delete the booking, assert a 201/Created status code

        }
    }
}
