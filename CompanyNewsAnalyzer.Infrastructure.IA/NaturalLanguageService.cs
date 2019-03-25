using CompanyNewsAnalyzer.Application.Interfaces;
using CompanyNewsAnalyzer.Domain.Analyzes;
using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1;
using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;
using IBM.WatsonDeveloperCloud.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyNewsAnalyzer.Infrastructure.IA
{
    public class NaturalLanguageService : INaturalLanguageService
    {
        private readonly Settings _settings;
        private readonly TokenOptions _tokenOptions;
        private readonly NaturalLanguageUnderstandingService _naturalLanguageUnderstandingService;

        public NaturalLanguageService(Settings settings)
        {
            _settings = settings;
            _tokenOptions = new TokenOptions
            {
                IamApiKey = _settings.ApiKey,
                ServiceUrl = _settings.Url
            };
            _naturalLanguageUnderstandingService = new NaturalLanguageUnderstandingService(_tokenOptions, _settings.VersionDate);
        }

        public Sentiment GetNewsSentiment(string url)
        {

            Parameters parameters = new Parameters()
            {
                Url = url,
                Features = new Features()
                {
                    Sentiment = new SentimentOptions()
                    {
                        Document = true
                    }
                }
            };

            var result = _naturalLanguageUnderstandingService.Analyze(parameters);
            return JsonConvert.DeserializeObject<Analyze>(result.ResponseJson).Sentiment;
        }

      
    }
}
