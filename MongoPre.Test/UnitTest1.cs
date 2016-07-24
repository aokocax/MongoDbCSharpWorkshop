using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using MongoDB.Bson;


namespace MongoPre.Test
{

    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Berk { get; set; }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertBson()
        {
            MongoDB.Driver.MongoClient mc = new MongoDB.Driver.MongoClient();
            var db = mc.GetDatabase("Test");
            var col = db.GetCollection<BsonDocument>("Brand");
            var brand = new BsonDocument { { "Id", 2 }, { "Name", "test" } };
            col.InsertOne(brand);

        }
        [TestMethod]
        public void Insert()
        {
            MongoDB.Driver.MongoClient mc = new MongoDB.Driver.MongoClient();
            var db = mc.GetDatabase("Test");
            var col = db.GetCollection<Brand>("Brand");
            var brand = new Brand { Id = 67, Name = "test" };
            col.InsertOne(brand);

        }
        [TestMethod]
        public void ReadBson()
        {
            MongoDB.Driver.MongoClient mc = new MongoDB.Driver.MongoClient();
            var db = mc.GetDatabase("Test");
            var col = db.GetCollection<BsonDocument>("Brand");
         var filter = Builders<BsonDocument>.Filter.Eq("Id", 1);
           var f= Builders<BsonDocument>.Filter.Empty;

            f = f & Builders<BsonDocument>.Filter.Eq("Name", "a");

         

            var brandBson = col.FindAsync(f ).Result.FirstOrDefault();

        }
        [TestMethod]
        public void Read()
        {
            MongoDB.Driver.MongoClient mc = new MongoDB.Driver.MongoClient();
            var db = mc.GetDatabase("Test");
            var col = db.GetCollection<Brand>("Brand");
            var filter = Builders<Brand>.Filter.Eq("Id", 1);
            var projection = Builders<Brand>.Projection.Include("Name");
            var sort = Builders<Brand>.Sort.Descending("Name");
            var brand = col.Find(filter).Project(projection).Sort(sort);

        }

        [TestMethod]
        public void Update()

        {
            MongoClient mc = new MongoClient();
            var db3 = mc.GetDatabase("Test");

            var col = db3.GetCollection<Brand>("Brand");
            var filt = Builders<Brand>.Filter.Eq("Id", 1);
            var upd = Builders<Brand>.Update.Set("Name", "Test1");
            col.UpdateManyAsync(filt, upd).Wait();
        }

        [TestMethod]
        public void Delete()
        {
            MongoClient mc = new MongoClient();
            var db = mc.GetDatabase("Test");
           
            var col = db.GetCollection<Brand>("Brand");

            var filt = Builders<Brand>.Filter.Eq("Id", 1);

            col.DeleteOne(filt);
        }

        [TestMethod]
        public void Aggregate()
        { 
            var agbrands = new MongoClient().GetDatabase("Banks").GetCollection<BsonDocument>("albarakacomtr_FollowerTweet")


                .Aggregate().Group(
                new BsonDocument { { "_id", "$url.expanded_url" },
                    { "count", new BsonDocument("$sum", 1) } }).ToListAsync().Result;
           

        }


    }
}
