using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyNewsAnalyzer.Application.News.Models;
using CompanyNewsAnalyzer.Application.News.Querys.GetNews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyNewsAnalyzer.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IGetNewsQuery _getNewsQuery;

        public NewsController(IGetNewsQuery getNewsQuery)
        {
            _getNewsQuery = getNewsQuery;
        }


        //// GET: api/News
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/News/Petrobras
        [HttpGet("{companyName}", Name = "Get")]
        public async Task<IEnumerable<NewsModel>> GetAsync(string companyName)
        {
            return await _getNewsQuery.ExecuteAsync(companyName);
        }

        //// POST: api/News
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/News/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
