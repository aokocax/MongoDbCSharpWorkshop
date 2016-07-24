using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;

namespace MongoPre.Web.Controllers
{
    public class HomeController : Controller
    {
        MongoDB.Driver.MongoClient mc = new MongoDB.Driver.MongoClient();
        // GET: Home
        public ActionResult Index()
        {
            var col = mc.GetDatabase("Blog").GetCollection<BsonDocument>("Post");
            var posts = col.Find(new BsonDocument { }).ToList();
            ViewBag.Posts = posts;
            return View();
        }
    }
}