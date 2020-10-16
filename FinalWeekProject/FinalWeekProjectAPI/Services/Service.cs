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
    public class Service
    {
        public RestClient client { get; set; } 
        public CallManager CallManager { get; set; } = new CallManager();
        public BooksLatestDTO BooksLatestDTO { get; set; } = new BooksLatestDTO();
        public JObject BookResponseContent { get; set; } 
        public string BookSelected { get; set; } 
        
                
        public Service()
        {

        }

        public void GetResults()
        {
            BookSelected = CallManager.GetResults(); 
            BooksLatestDTO.DeserializeBooks(BookSelected);
            BookResponseContent = JsonConvert.DeserializeObject<JObject>(BookSelected);
        }

        

    }
}
