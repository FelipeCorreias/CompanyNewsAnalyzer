using CompanyNewsAnalyzer.Domain.Analyzes;

namespace CompanyNewsAnalyzer.Application.Interfaces
{
    public interface INaturalLanguageService
    {
        Sentiment GetNewsSentiment(string url);
    }
}