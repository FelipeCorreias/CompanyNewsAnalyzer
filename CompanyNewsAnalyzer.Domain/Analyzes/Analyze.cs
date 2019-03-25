using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyNewsAnalyzer.Domain.Analyzes
{
   public class Analyze
    {
        public Usage Usage { get; set; }
        public Sentiment Sentiment { get; set; }
        public string Retrieved_url { get; set; }
        public string Language { get; set; }
    }
}
