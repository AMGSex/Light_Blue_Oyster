using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light_Blue_Oyster.Classes
{
    class Employe
    {
        public ObjectId _id { get; set; }
        public string FIO { get; set; }
        public string Photo { get; set; }
        public string WorkName { get; set; }
        public string Birthday { get; set; }
        public string Sex { get; set; }
        public string City { get; set; }
        public int Passport { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    public static void AddToMongo(Employe employe)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("Maksos");
        var collection = database.GetCollection<Employe>("Marseks");
        collection.InsertOneAsync(employe);
    }
    }

}
