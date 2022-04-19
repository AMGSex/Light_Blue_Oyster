using System;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Light_Blue_Oyster.Classes
{
    class Item
    {
        public ObjectId _id { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemDateBuy { get; set; }
        public int ItemCount  { get; set; }

        public static void AddToMongo(Item item)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Maksos");
            var collection = database.GetCollection<Item>("Marseks");
            collection.InsertOneAsync(item);
        }
    }
}
