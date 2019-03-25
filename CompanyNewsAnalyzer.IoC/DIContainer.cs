using CompanyNewsAnalyzer.Application.Interfaces;
using CompanyNewsAnalyzer.Application.News.Querys.GetNews;
using CompanyNewsAnalyzer.Infrastructure.IA;
using CompanyNewsAnalyzer.Infrastructure.News;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CompanyNewsAnalyzer.IoC
{
    public static class DIContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            //Infrastrucuture
            services.AddScoped<Infrastructure.News.Settings>();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<Infrastructure.IA.Settings>();
            services.AddScoped<INaturalLanguageService, NaturalLanguageService>();

            //News
            services.AddTransient<IGetNewsQuery, GetNewsQuery>();
        }
    }
}
