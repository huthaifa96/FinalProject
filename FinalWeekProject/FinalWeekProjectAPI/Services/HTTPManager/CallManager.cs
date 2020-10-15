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

        public void AddBook(string[] names, string[] values)
        {
            if (names.Length > 0)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    var request = new RestRequest(ConfigReader.v1Books + names[i] + ConfigReader.v1Books + values[i]); ;
                    var response = _client.Execute(request, Method.POST);
                    Json_Features = JsonConvert.DeserializeObject<JObject>(response.Content);
                }
            }
        }
    }
}
