using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haberler.Models;
using Haberler.Utility;
using Microsoft.AspNetCore.Mvc;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;

namespace Haberler.Controllers
{
    public class DefaultController : Controller
    {
        HomeModel model;
        public IActionResult Index(int id=48, int kategoriid=0)
        {
            
            model = new HomeModel();
            model.dilid = id;
            model.kategoriid = kategoriid;            
            model.haberler = GetNews(id,kategoriid);          
            model.dillistesi = Sabitler.Diller();
            Kategories kst = new Kategories();
            model.kategorilistesi = kst.GetKategoriler((Sabitler.Language)id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string searchKey, int id = 48, int kategoriid = 0)
        {
            model = new HomeModel();
            model.dilid = id;
            model.kategoriid = kategoriid;
            model.haberler = GetNewsEvery(searchKey);
            if (model.haberler.TotalResults < 6)
                model.haberler = GetNews(id, kategoriid);

            model.dillistesi = Sabitler.Diller();
            Kategories kst = new Kategories();
            model.kategorilistesi = kst.GetKategoriler((Sabitler.Language)id);
            return View(model);
        }

        private ArticlesResult GetNewsEvery(string searchKey = "")
        {
            var newsApiClient = new NewsApiClient("86fec14ae3a54bd8a8cbb0f9f3ab517a");
            var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {                                
                Q = searchKey
            });

            if (articlesResponse.Status == Statuses.Ok)
            {
                return articlesResponse;
            }
            return null;
        }

        private ArticlesResult GetNews(int dilid=48,int kategoriid=0, string searchKey="") {
            var newsApiClient = new NewsApiClient("86fec14ae3a54bd8a8cbb0f9f3ab517a");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest { 
                Country = (Countries)dilid,
                Category = (Categories)kategoriid,
                Q = searchKey
            });
            
            if (articlesResponse.Status == Statuses.Ok)
            {
                return articlesResponse;
            }
            return null;
        }

        private ArticlesResult GetNewsFind(int dilid = 48, string searchKey = "")
        {
            var newsApiClient = new NewsApiClient("86fec14ae3a54bd8a8cbb0f9f3ab517a");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                Country = (Countries)dilid,            
                Q = searchKey
            });

            if (articlesResponse.Status == Statuses.Ok)
            {
                return articlesResponse;
            }
            return null;
        }


    }
}
