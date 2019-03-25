using System.Threading.Tasks;
using CompanyNewsAnalyzer.Domain.News;

namespace CompanyNewsAnalyzer.Application.Interfaces
{
    public interface INewsService
    {
        Task<ResponseNews> GetNewsAsync(string companyName);
    }
}