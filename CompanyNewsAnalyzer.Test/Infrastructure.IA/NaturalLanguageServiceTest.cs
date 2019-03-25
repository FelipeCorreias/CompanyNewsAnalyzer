using CompanyNewsAnalyzer.Infrastructure.IA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyNewsAnalyzer.Test.Infrastructure.IA
{
    [TestClass]
   public class NaturalLanguageServiceTest
    {
        [TestMethod]
        public void GetNewsSentiment() {
            Settings settings = new Settings();
            NaturalLanguageService naturalLanguageService = new NaturalLanguageService(settings);

           var sentiment = naturalLanguageService.GetNewsSentiment("https://www1.folha.uol.com.br/mercado/2019/03/daniel-lima-renuncia-a-presidencia-da-petros-fundo-de-pensao-da-petrobras.shtml");

            Assert.IsTrue(sentiment.Document.Score == 0);
        }
    }
}
