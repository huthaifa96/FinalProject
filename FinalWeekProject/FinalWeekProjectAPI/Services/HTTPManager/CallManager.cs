﻿using Newtonsoft.Json;
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
        public JObject Json_Features { get; set; }
        public CallManager()
        {
            _client = new RestClient(ConfigReader.BaseUrl);
        }

        public string GetResults()
        {
            var request = new RestRequest(ConfigReader.v1Books);
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }

        
    }
}
