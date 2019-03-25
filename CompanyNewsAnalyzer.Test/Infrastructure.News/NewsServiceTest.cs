using CompanyNewsAnalyzer.Domain.News;
using CompanyNewsAnalyzer.Infrastructure.News;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CompanyNewsAnalyzer.Test
{
    [TestClass]
    public class NewsServiceTest
    {
        [TestMethod]
        public async Task GetNewsAsync()
        {
            Settings settings = new Settings();
            NewsService newsService = new NewsService(settings);

            ResponseNews data = await newsService.GetNewsAsync("Petrobras");

            Assert.IsTrue(data.TotalResults > 0);
        }
    }
}
