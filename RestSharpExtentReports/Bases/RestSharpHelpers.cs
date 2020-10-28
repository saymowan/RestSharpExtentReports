using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpExtentReports.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace RestSharpExtentReports.Bases
{
    public class RestSharpHelpers
    {

        public static IRestResponse<dynamic> ExecuteRequest(string url, string requestService, Method method){

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(requestService, method);

            request.AddParameter("Content-Type","application/json", ParameterType.HttpHeader);

            IRestResponse<dynamic> response = client.Execute<dynamic>(request);
                 
            ExtentReportHelpers.AddTestInfo(url, requestService, method.ToString(), response);

            return response;
        }

        

    }


}