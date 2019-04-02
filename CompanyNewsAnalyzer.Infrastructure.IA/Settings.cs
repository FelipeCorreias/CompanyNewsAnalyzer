using System;

namespace CompanyNewsAnalyzer.Infrastructure.IA
{
    public class Settings
    {
        public const string _apiKey = "{APIKEY}";
        public const string _url = "https://gateway-wdc.watsonplatform.net/natural-language-understanding/api";
        public const string _versionDate = "2018-03-19";

        public string ApiKey => _apiKey;
        public string Url => _url;
        public string VersionDate => _versionDate;
    }
}
