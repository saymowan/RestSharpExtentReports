using System;
using NUnit.Framework;
using RestSharp;
using RestSharpExtentReports.Bases;
using RestSharpExtentReports.Helpers;

namespace RestSharpExtentReports.Tests
{    
    [TestFixture]
    public class ListUsersTests : TestBase
    {


        [Test]
        public void BuscarUsuarios2()
        {
            string statusCodeEsperado = "OK";
            string url = "https://reqres.in";
            string requestService = "/api/users?page=2";
            Method method = Method.GET;

            IRestResponse<dynamic> response = RestSharpHelpers.ExecuteRequest(url, requestService, method);

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
            Assert.Greater((int)response.Data["total"], 1);
        }
        
    }
}
