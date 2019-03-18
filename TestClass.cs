namespace CS_REST_Exercise
{
    using RestSharp;
    using System;
    using System.Linq;
    using System.Net;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using NUnit.Framework;

    [TestFixture]
    class TestClass : ATestClass
    {
        [Test]
        public void test_method()
        {
            // Ping the api, assert a 201/Created status code
            var ping = SendRequest("ping");
            Assert.That(ping.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            
            // Get an auth token, assert 200/OK response with token in body
            var auth = SendRequest("auth", Method.POST, "{\"username\" : \"admin\",\"password\" : \"password123\"}");
            Assert.That(auth.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            
            // Store token as a cookie
            var authToken = JsonConvert.DeserializeObject<JObject>(auth.Content)["token"].ToString();
            // Delete this line and start here. We've got the token isolated, store it as a cookie and continue to the next steps.

            // Get booking 1, assert 200/OK response
            
            // Update booking 1 firstname to Robert, assert a 201/Created status code

            // Get booking 1, assert firstname is Robert
        }
    }
}
