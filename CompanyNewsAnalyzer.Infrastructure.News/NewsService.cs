using CompanyNewsAnalyzer.Application.Interfaces;
using CompanyNewsAnalyzer.Domain.News;
using Newtonsoft.Json;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyNewsAnalyzer.Infrastructure.News
{
    public class NewsService : INewsService
    {

        private readonly Settings _settings;

        public NewsService(Settings settings)
        {
            _settings = settings;
        }

        public async Task<ResponseNews> GetNewsAsync(string companyName) {
            var client = new RestClient();
            var request = new RestRequest(_settings.Url + "everything?language=en&q=" + companyName + "&sortBy=publishedAt&apiKey=" + _settings.ApiKey);
            var cancellationTokenSource = new CancellationTokenSource();

            var restResponse = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);

            return JsonConvert.DeserializeObject<ResponseNews>(restResponse.Content);
        }

    }
}
