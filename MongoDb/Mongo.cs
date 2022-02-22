using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CustomerForm.MongoDb
{
    public class Mongo
    {
        private MongoClient client;
        public Mongo()
        {
            client = new MongoClient();
        }

        // Creates a database

        public IMongoDatabase GetDB(string databaseObject)
        {
            var db = client.GetDatabase(databaseObject);
            return db;
        }
    }
}
