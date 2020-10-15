using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWeekProjectAPI
{
    public class CallManager
    {
        //The restsharp object which handles the call
        readonly IRestClient _client;
        public JObject Json_SessionID { get; set; }
        public CallManager()
        {
            _client = new RestClient(ConfigReader.BaseUrl);
            GetResults();
        }

        public string GetResults()
        {
            var request = new RestRequest();
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }


    }
}
