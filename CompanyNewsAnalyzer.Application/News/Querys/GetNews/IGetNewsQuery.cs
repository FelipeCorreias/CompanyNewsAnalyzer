using System.Collections.Generic;
using System.Threading.Tasks;
using CompanyNewsAnalyzer.Application.News.Models;

namespace CompanyNewsAnalyzer.Application.News.Querys.GetNews
{
    public interface IGetNewsQuery
    {
        Task<IEnumerable<NewsModel>> ExecuteAsync(string companyName);
    }
}