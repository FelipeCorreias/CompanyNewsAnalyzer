using CompanyNewsAnalyzer.Application.Interfaces;
using CompanyNewsAnalyzer.Application.News.Models;
using CompanyNewsAnalyzer.Domain.Analyzes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyNewsAnalyzer.Application.News.Querys.GetNews
{
   public class GetNewsQuery : IGetNewsQuery
    {
        private readonly INewsService _newsService;
        private readonly INaturalLanguageService _naturalLanguageService;

        public GetNewsQuery(INewsService newsService, INaturalLanguageService naturalLanguageService)
        {
            _newsService = newsService;
            _naturalLanguageService = naturalLanguageService;
        }

        public async Task<IEnumerable<NewsModel>> ExecuteAsync(string companyName) {
            var responseNews = await _newsService.GetNewsAsync(companyName);
            List<NewsModel> newsModels = new List<NewsModel>();

            foreach (var article in responseNews.Articles)
            {
                NewsModel newsModel = new NewsModel();
                Sentiment sentiment = new Sentiment();

                newsModel.Title = article.Title;
                newsModel.Description = article.Description;
                newsModel.Url = article.Url;

                sentiment = _naturalLanguageService.GetNewsSentiment(article.Url);

                newsModel.Score = sentiment.Document.Score;
                newsModel.Label = sentiment.Document.Label;

                newsModels.Add(newsModel);

            }

            return newsModels;

        }
    }
}
