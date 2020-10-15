using System;
using System.Configuration;

namespace FinalWeekProjectAPI
{
    public static class ConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string v1Books = ConfigurationManager.AppSettings["v1books_url"];
    }
}
