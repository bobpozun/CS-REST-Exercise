# CS-REST-Exercise  

To run: `dotnet test --verbosity=normal --logger:"nunit;LogFilePath=test-result.xml"`  

RestSharp is included (https://github.com/restsharp/RestSharp/wiki)  
Feel free to install any other packages you would like  

Here are the API docs: `https://restful-booker.herokuapp.com/apidoc/index.html`  

Don't bother with the https://www.mwtestconsultancy.co.uk base url in the docs. Use https://restful-booker.herokuapp.com/  

Exercise:  
    Ping the api, assert a 201/Created status code  
    Get an auth token, assert 200/OK response with token in body  
    Store token as a cookie  
    Get booking 1, assert 200/OK response  
    Update booking 1 firstname to Robert, assert a 201/Created status code  
    Get booking 1, assert firstname is Robert  
    