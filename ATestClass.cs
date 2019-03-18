namespace CS_REST_Exercise
{
    using RestSharp;
    using System;
    using System.Linq;
    using System.Net;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using NUnit.Framework;

    [SetUpFixture]
    public abstract class ATestClass
    {
        private RestClient client;
        private static string baseUrl = "https://restful-booker.herokuapp.com/";

        [OneTimeSetUp]
        public virtual void OneTimeSetup()
        {
            client = new RestClient(baseUrl);
            client.CookieContainer = new System.Net.CookieContainer();
        }
        public IRestResponse SendRequest(string endpoint, Method method = Method.GET, string requestJson = null)
        {
            var request = new RestRequest(endpoint);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            if (requestJson != null)
                request.AddParameter("application/json", requestJson, ParameterType.RequestBody);
            var response = client.Execute(request, method);
            return response;
        }

        public void AddCookieToClient(string name, string value)
        {
            client.CookieContainer.Add(new Cookie(name, value) { Domain = new Uri(baseUrl).Host });
            Assert.That(client.CookieContainer.Count , Is.EqualTo(1));
        }
    }

}