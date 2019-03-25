using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyNewsAnalyzer.Application.News.Models
{
   public class NewsModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public double Score { get; set; }
        public string Label { get; set; }
    }
}
