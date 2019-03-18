using RestSharp;
using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

[SetupFixture]
public abstract class ATestClass
{
    private RestClient client;
    private Uri target = new Uri("https://restful-booker.herokuapp.com/");

    [OneTimeSetup]
    public void OneTimeSetup()
    {
        client.CookieContainer = new System.Net.CookieContainer();
        client = new RestClient(target.Host);
    }
    private IRestResponse SendRequest(string endpoint, Method method, string requestJson = null)
    {
        var request = new RestRequest(endpoint);
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Accept", "application/json");
        if (requestJson != null)
            request.AddParameter("application/json", requestJson, ParameterType.RequestBody);
        var response = client.Execute(request, method);
        return response;
    }
}

