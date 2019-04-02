using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyNewsAnalyzer.Infrastructure.News
{
    public class Settings
    {
        public const string _apiKey = "{APIKEY}";
        public const string _url = "https://newsapi.org/v2/";

        public string ApiKey => _apiKey;
        public string Url => _url;
    }
}
