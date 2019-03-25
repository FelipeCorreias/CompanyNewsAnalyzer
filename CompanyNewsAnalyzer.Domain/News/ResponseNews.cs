using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyNewsAnalyzer.Domain.News
{

    public class ResponseNews
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<Article> Articles { get; set; }
    }
}
