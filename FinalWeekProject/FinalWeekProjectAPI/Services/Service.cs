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
    class Service
    {
        public RestClient client { get; set; } // A RESTSharp object that handles communication with the API and this is where we make our calls
        public CallManager CallManager { get; set; } = new CallManager();
        public BooksLatestDTO BooksLatestDTO { get; set; } = new BooksLatestDTO();
        public JObject BookResponseContent { get; set; } // Stores our responses
        public string BookSelected { get; set; } // The book that is selected
                
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